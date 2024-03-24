using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.DataAcess.Data;
using BulkyBook.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        public readonly IRepositoryCategory _repoCategory;

        public CategoryController(IRepositoryCategory db)
        {
            _repoCategory = db;
        }
        public IActionResult Index()
        {
            List<Category> categories = _repoCategory.GetAll().ToList();
            return View(categories);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if(obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The displayOder Can not exacty math the name ");
            }
            if (ModelState.IsValid)
            {
                _repoCategory.Add(obj);
                _repoCategory.Save();
				TempData["success"] = " create category successfully";
				return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Edit(int? CategoryId)
        {
            if (CategoryId == null || CategoryId == 0)
            {
                return NotFound();
            }
            Category category = _repoCategory.Get(x=>x.CategoryId == CategoryId);
            if(category == null)
            {
                return NotFound();
            }
            return View(category);
        }
        [HttpPost]
		public IActionResult Edit(Category obj)
		{
            if (ModelState.IsValid)
            {
                _repoCategory.Update(obj);
                _repoCategory.Save();
                TempData["success"] = " Update category successfully";

				return RedirectToAction("Index");
            }
			return View(obj);
		}
		public IActionResult Delete(int? Id)
		{
			if (Id == null || Id == 0)
			{
				return NotFound();
			}
			var categoryFromDb = _repoCategory.Get(x=>x.CategoryId == Id);
			

			if (categoryFromDb == null)
			{
				return NotFound();
			}

			return View(categoryFromDb);
		}

		[HttpPost, ActionName("Delete")]
		public IActionResult DeletePost(int? CategoryId)
		{
			
			Category category = _repoCategory.Get(x=>x.CategoryId == CategoryId);
			if (category != null)
			{
                _repoCategory.Remove(category);
                _repoCategory.Save();
				TempData["success"] = " Delete category successfully";

			}
			return RedirectToAction("Index");
		}
	}
}
