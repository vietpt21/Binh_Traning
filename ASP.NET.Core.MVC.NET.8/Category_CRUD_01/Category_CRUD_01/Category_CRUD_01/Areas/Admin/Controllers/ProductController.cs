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
                productVm.product = _unitOfWork.Product.Get(u => u.Id == id);
                return View(productVm);
            }
        }
        [HttpPost]
        public IActionResult Upsert(ProductVM productVM, IFormFile? file)
        {
            if (ModelState.IsValid)
            {

                /*	C:\\Users\\VIETPT\\Desktop\\Binh_Traning\\ASP.NET.Core.MVC.NET.8\\Category_CRUD_01\\Category_CRUD_01\\Category_CRUD_01\\wwwroot*/
                string wwwroot = _webHostEnvironment.WebRootPath.ToString();

                if (file != null)
                {
                    string filename = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    //duong dan luu tru image cua project
                    string productPart = Path.GetFullPath(wwwroot + @"\images\product");
                    if (!string.IsNullOrEmpty(productVM.product.ImageUrl))
                    {
                        string oldImagePart = Path.Combine(wwwroot, productVM.product.ImageUrl.TrimStart('\\'));
                        if (System.IO.File.Exists(oldImagePart))
                        {
                            System.IO.File.Delete(oldImagePart);
                        }
                    }
                    using (var fileStream = new FileStream(Path.Combine(productPart, filename), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    productVM.product.ImageUrl = @"\images\product\" + filename;
                }

                if (productVM.product.Id == 0)
                {
                    _unitOfWork.Product.Add(productVM.product);

                }
                else
                {
                    _unitOfWork.Product.Update(productVM.product);
                }

                _unitOfWork.Save();
                TempData["success"] = " create product successfully";
                return RedirectToAction("Index");
            }

            return View(productVM);
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
            string oldImagePart = Path.Combine(_webHostEnvironment.WebRootPath, productTobeDeltete.ImageUrl.TrimStart('\\'));
            if (System.IO.File.Exists(oldImagePart))
            {
                System.IO.File.Delete(oldImagePart);
            }
            _unitOfWork.Product.Remove(productTobeDeltete);
            _unitOfWork.Save();

            return Json(new { success = true, message = " delete success" });
        }
        #endregion
    }
}