using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using BulkyBook.Models.ViewModels;
using BulkyBook.Untility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stripe;
using Stripe.Checkout;
using System.Security.Claims;

namespace BulkyBookWeb.Areas.Customer.Controllers
{
    [Area("customer")]
    [Authorize]
    public class CartController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
		[BindProperty]//tu dong lay du lieu tu action get 
        public ShopppingCartVM ShopppingCartVM { get; set; }
        public CartController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
      
        public IActionResult Index()
        {
			var claimIdentity = (ClaimsIdentity)User.Identity;
			var userId = claimIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
            ShopppingCartVM = new()
            {
                ShoppingCartList = _unitOfWork.ShoppingCart.
                GetAll(x=> x.ApplicationUserId ==userId,includeProperties:"Product"),
                OrderHeader = new()
                
            };
			IEnumerable<ProductImage> productImages = _unitOfWork.ProductImage.GetAll().ToList();
            foreach (var cart in ShopppingCartVM.ShoppingCartList)
            {
				cart.Product.ProductImages = productImages.Where(u => u.ProductId == cart.Product.Id).ToList();
                cart.Price= GetPriceBasedOnQuantity(cart);
                ShopppingCartVM.OrderHeader.OrderTotal += (cart.Price * cart.Count);
            }
            return View(ShopppingCartVM);
		}
        public IActionResult Summary()
        {
			var claimIdentity = (ClaimsIdentity)User.Identity;
			var userId = claimIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
			ShopppingCartVM = new()
			{
				ShoppingCartList = _unitOfWork.ShoppingCart.
				GetAll(x => x.ApplicationUserId == userId, includeProperties: "Product"),
				OrderHeader = new()

			};
            ShopppingCartVM.OrderHeader.ApplicationUser = _unitOfWork.ApplicationUser.Get(x => x.Id == userId);
            ShopppingCartVM.OrderHeader.Name = ShopppingCartVM.OrderHeader.ApplicationUser.Name;
			ShopppingCartVM.OrderHeader.PhoneNumber = ShopppingCartVM.OrderHeader.ApplicationUser.PhoneNumber;
			ShopppingCartVM.OrderHeader.StreetAddress = ShopppingCartVM.OrderHeader.ApplicationUser.StreetAdress;
			ShopppingCartVM.OrderHeader.City = ShopppingCartVM.OrderHeader.ApplicationUser.City;
			ShopppingCartVM.OrderHeader.State = ShopppingCartVM.OrderHeader.ApplicationUser.State;
			ShopppingCartVM.OrderHeader.PostalCode = ShopppingCartVM.OrderHeader.ApplicationUser.PostalCode;
			foreach (var cart in ShopppingCartVM.ShoppingCartList)
			{
				cart.Price = GetPriceBasedOnQuantity(cart);
				ShopppingCartVM.OrderHeader.OrderTotal += (cart.Price * cart.Count);
			}
			return View(ShopppingCartVM);
        }
		[HttpPost]
		[ActionName("Summary")]
		public IActionResult SummaryPost(ShopppingCartVM ShopppingCartVM)
		{
			var claimIdentity = (ClaimsIdentity)User.Identity;
			var userId = claimIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

			ShopppingCartVM.ShoppingCartList = _unitOfWork.ShoppingCart.
			GetAll(x => x.ApplicationUserId == userId, includeProperties: "Product");

			ShopppingCartVM.OrderHeader.OrderDate = System.DateTime.Now;
			ShopppingCartVM.OrderHeader.ApplicationUserId = userId;

			ApplicationUser applicationUser = _unitOfWork.ApplicationUser.Get(x => x.Id == userId);

			foreach (var cart in ShopppingCartVM.ShoppingCartList)
			{
				cart.Price = GetPriceBasedOnQuantity(cart);
				ShopppingCartVM.OrderHeader.OrderTotal += (cart.Price * cart.Count);
			}

			if (applicationUser.CompanyId.GetValueOrDefault() == 0)
			{
				//xu ly customer k thuoc company
				ShopppingCartVM.OrderHeader.OrderStatus = SD.StatusPending;
				ShopppingCartVM.OrderHeader.PaymentStatus = SD.PaymentStatusPending;
			}
			else
			{
				ShopppingCartVM.OrderHeader.OrderStatus = SD.PaymentStatusApproved;
				ShopppingCartVM.OrderHeader.PaymentStatus = SD.PaymentStatusDelayedPayment;
			}
			
			_unitOfWork.OrderHeader.Add(ShopppingCartVM.OrderHeader ) ;
			_unitOfWork.Save();

			foreach (var cart in ShopppingCartVM.ShoppingCartList)
			{
				OrderDetail orderDetail = new OrderDetail()
				{
					ProductId = cart.ProductId,
					OrderHeaderId =ShopppingCartVM.OrderHeader.Id,
					Price = cart.Price,
					Count = cart.Count,
				};
				_unitOfWork.OrderDetail.Add(orderDetail);
				_unitOfWork.Save();
			}

			if (applicationUser.CompanyId.GetValueOrDefault() == 0)
			{
				//xu li customer k thuoc company
				var domain = "http://localhost:5170/";
				var options = new Stripe.Checkout.SessionCreateOptions
				{

					SuccessUrl = domain + $"customer/cart/OderComfirmation?id={ShopppingCartVM.OrderHeader.Id}",
					CancelUrl = domain + $"customer/cart/index",
                    LineItems = new List<Stripe.Checkout.SessionLineItemOptions>(),
					
                    Mode = "payment", 
                };
                foreach (var item in ShopppingCartVM.ShoppingCartList)
				{
					var sessionLineItem = new SessionLineItemOptions()
					{
						PriceData = new SessionLineItemPriceDataOptions
						{
							UnitAmount = (long)item.Price * 100,  //$10.05 =>1005
							Currency = "usd",
							ProductData = new SessionLineItemPriceDataProductDataOptions
							{
								Name = item.Product.Title,
							}
						},
						Quantity = item.Count,
					};
					options.LineItems.Add(sessionLineItem);
                }
				var service = new SessionService();
				var session =service.Create(options);
				_unitOfWork.OrderHeader.UpdateStripePaymentId(ShopppingCartVM.OrderHeader.Id, session.Id, session.PaymentIntentId);
				_unitOfWork.Save();
				Response.Headers.Add("Location", session.Url);
				return new StatusCodeResult(303);
               
            }

            return RedirectToAction(nameof(OrderConfirmation), new { id = ShopppingCartVM.OrderHeader.Id });
		}

       
        public IActionResult OrderConfirmation(int id)
	    {
			OrderHeader orderHeader = _unitOfWork.OrderHeader.Get(x => x.Id == id, includeProperties: "ApplicationUser");
			if(orderHeader.PaymentStatus != SD.PaymentStatusDelayedPayment)
			{
				var service = new SessionService();
				Session session = service.Get(orderHeader.SessionId);
				if(session.Status.ToLower() == "paid")
				{
					_unitOfWork.OrderHeader.UpdateStripePaymentId(id, session.Id, session.PaymentIntentId);
					_unitOfWork.OrderHeader.UpdateStatus(id, SD.StatusApproved, SD.PaymentStatusApproved);
					_unitOfWork.Save();
				}
			}
			List<ShoppingCart> shoppingCartList = _unitOfWork.ShoppingCart.GetAll(x => x.Id == id).ToList();
			_unitOfWork.ShoppingCart.RemoveRange(shoppingCartList);
			_unitOfWork.Save();

			return View(id);
		}
		public IActionResult Plus(int cartId)
		{
            var cartFormDb = _unitOfWork.ShoppingCart.Get(x => x.Id == cartId,tracked:true);
            cartFormDb.Count += 1;
            _unitOfWork.ShoppingCart.Update(cartFormDb);
            _unitOfWork.Save();
			return RedirectToAction(nameof(Index));
		}
        public IActionResult Minus(int cartId)
        {
            var cartFormDb = _unitOfWork.ShoppingCart.Get(x => x.Id == cartId,tracked:true);

            if (cartFormDb.Count <= 1)
            {
				_unitOfWork.ShoppingCart.Remove(cartFormDb);
				_unitOfWork.Save();
                HttpContext.Session.SetInt32(SD.SessionCart,
                _unitOfWork.ShoppingCart.GetAll(u => u.ApplicationUserId == cartFormDb.ApplicationUserId).ToList().Count);
            }
            else
            {
				cartFormDb.Count -= 1;
				_unitOfWork.ShoppingCart.Update(cartFormDb);
				_unitOfWork.Save();
			}
			return RedirectToAction(nameof(Index));
		}
		public IActionResult Remove(int cartId)
		{
			var cartFormDb = _unitOfWork.ShoppingCart.Get(x => x.Id == cartId);
			_unitOfWork.ShoppingCart.Remove(cartFormDb);
            HttpContext.Session.SetInt32(SD.SessionCart,
            _unitOfWork.ShoppingCart.GetAll(u => u.ApplicationUserId == cartFormDb.ApplicationUserId).ToList().Count - 1);
            _unitOfWork.Save();
            
            return RedirectToAction(nameof(Index));
		}


		public double GetPriceBasedOnQuantity(ShoppingCart shoppingCart)
        {
            if(shoppingCart.Count < 50)
            {
                return shoppingCart.Product.Price;
            }
			else
            {
				if (shoppingCart.Count < 100)
				{
					return shoppingCart.Product.Price50;
				}
                else
					return shoppingCart.Product.Price100;
			}
		}
    }
 
}