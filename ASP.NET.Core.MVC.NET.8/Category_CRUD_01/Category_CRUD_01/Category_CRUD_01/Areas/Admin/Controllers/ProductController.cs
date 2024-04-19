using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.DataAcess.Data;
using BulkyBook.Models;
using BulkyBook.Models.ViewModels;
using BulkyBook.Untility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BulkyBookWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            List<Product> products = _unitOfWork.Product.GetAll(includeProperties: "category").ToList();

            return View(products);
        }

        public IActionResult Upsert(int? id)
        {
            ProductVM productVm = new()
            {

                CategoryList = _unitOfWork.Category
                .GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.CategoryId.ToString()
                }),
                product = new Product()
            };
            if (id == null || id == 0)
            {
                return View(productVm);
            }
            else
            {
                productVm.product = _unitOfWork.Product.Get(u => u.Id == id,includeProperties: "ProductImages");
                return View(productVm);
            }
        }
        [HttpPost]
        public IActionResult Upsert(ProductVM productVM,List<IFormFile> files)
        {
            if (ModelState.IsValid)
            {
				if (productVM.product.Id == 0)
				{
					_unitOfWork.Product.Add(productVM.product);

				}
				else
				{
					_unitOfWork.Product.Update(productVM.product);
				}
				/*	C:\\Users\\VIETPT\\Desktop\\Binh_Traning\\ASP.NET.Core.MVC.NET.8\\Category_CRUD_01\\Category_CRUD_01\\Category_CRUD_01\\wwwroot*/
				string wwwroot = _webHostEnvironment.WebRootPath.ToString();

				if (files != null)
                {
                    foreach(var file in files)
                    {
						string filename = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                        string productPart = @"images\products\product-" + productVM.product.Id;
                        string finalPath = Path.Combine(wwwroot, productPart);
                        if (!Directory.Exists(finalPath))
                        {
                            Directory.CreateDirectory(finalPath);
                        }
						using (var fileStream = new FileStream(Path.Combine(finalPath, filename), FileMode.Create))
						{
							file.CopyTo(fileStream);
						}
                        ProductImage productImage = new()
                        {
                            ImageUrl = @"\" + productPart + @"\" + filename,
                            ProductId = productVM.product.Id
                        };

                        if (productVM.product.ProductImages == null)
                            productVM.product.ProductImages = new List<ProductImage>();
                        productVM.product.ProductImages.Add(productImage);
   
					}
                    _unitOfWork.Product.Update(productVM.product);
                    _unitOfWork.Save();
                   
                }
                TempData["success"] = " create update product successfully";
                return RedirectToAction("Index");
            }
            else
            {
                productVM.CategoryList = _unitOfWork.Category.GetAll().Select(u=> new SelectListItem
                {
                    Text = u.Name,
                    Value = u.CategoryId.ToString(),
                });
				return View(productVM);

			}   
        }
       
        public IActionResult DeleteImage(int imageId)
        {
            var imageTobeDelete = _unitOfWork.ProductImage.Get(u => u.Id == imageId);
            int productId = imageTobeDelete.ProductId;
            if(imageTobeDelete != null)
            {
                if (!string.IsNullOrEmpty(imageTobeDelete.ImageUrl))
                {
					string oldImagePart = Path.Combine(_webHostEnvironment.WebRootPath, imageTobeDelete.ImageUrl.TrimStart('\\'));
					if (System.IO.File.Exists(oldImagePart))
					{
						System.IO.File.Delete(oldImagePart);
					}
				}
                _unitOfWork.ProductImage.Remove(imageTobeDelete);
                _unitOfWork.Save();
				TempData["success"] = " Delete image product successfully";
			}
            return RedirectToAction(nameof(Upsert), new { id = productId });

        }
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Product> products = _unitOfWork.Product.GetAll().ToList();
            return Json(new { data = products });
        }
        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var productTobeDeltete = _unitOfWork.Product.Get(u => u.Id == id);
            if (productTobeDeltete == null)
            {
                return Json(new { success = false, message = "error while delete" });
            }
         
            string productPart = @"images\products\product-" + id;
			string finalPath = Path.Combine(_webHostEnvironment.WebRootPath, productPart);
			if (Directory.Exists(finalPath))
			{
                string[] filePaths = Directory.GetFiles(finalPath);
                foreach(var filePath in filePaths)
                {
                    System.IO.File.Delete(filePath);
                }
				Directory.Delete(finalPath);
			}
			_unitOfWork.Product.Remove(productTobeDeltete);
            _unitOfWork.Save();

            return Json(new { success = true, message = " delete success" });
        }
        #endregion
    }
}