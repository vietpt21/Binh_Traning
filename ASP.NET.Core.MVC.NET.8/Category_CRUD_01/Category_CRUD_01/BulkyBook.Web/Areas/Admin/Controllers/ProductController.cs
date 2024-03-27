using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.DataAcess.Data;
using BulkyBook.Models;
using BulkyBook.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BulkyBookWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductController(IUnitOfWork unitOfWork,IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            List<Product> categories = _unitOfWork.Product.GetAll().ToList();
         
            return View(categories);
        }
        public IActionResult Upsert(int? ProductId)
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
            if(ProductId == null || ProductId == 0)
            {
                return View(productVm);
            }
            else
            {
                productVm.product = _unitOfWork.Product.Get(u => u.Id == ProductId);
                return View(productVm);
            }
        }
        [HttpPost]
        public IActionResult Upsert(ProductVM productVM, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                string wwwroot = _webHostEnvironment.WebRootPath;
				if (wwwroot != null)
                {
                    string filename = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    //duong dan luu tru image cua project
                    string productPart = Path.Combine(wwwroot, "@/images/product");
                    using (var fileStream = new FileStream(Path.Combine(productPart,filename) ,FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    productVM.product.ImageUrl = "@/image/product" + filename;
				}
                _unitOfWork.Product.Add(productVM.product);
                _unitOfWork.Save();
                TempData["success"] = " create product successfully";
                return RedirectToAction("Index");
            }
            else
                productVM.CategoryList = _unitOfWork.Category
               .GetAll().Select(u => new SelectListItem
               {
                   Text = u.Name,
                   Value = u.CategoryId.ToString()
               });
            return View(productVM);
        }
        public IActionResult Delete(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var ProductFromDb = _unitOfWork.Product.Get(x => x.Id == Id);


            if (ProductFromDb == null)
            {
                return NotFound();
            }

            return View(ProductFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? Id)
        {

            Product product = _unitOfWork.Product.Get(x => x.Id == Id);
            if (product != null)
            {
                _unitOfWork.Product.Remove(product);
                _unitOfWork.Save();
                TempData["success"] = " Delete product successfully";

            }
            return RedirectToAction("Index");
        }
    }
}
