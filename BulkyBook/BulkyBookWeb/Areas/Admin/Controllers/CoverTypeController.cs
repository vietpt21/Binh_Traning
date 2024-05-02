using BulkyBook.DataAccess;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using BulkyBook.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]

    public class CoverTypeController : Controller
    {
        private readonly IUnitOfWork _db;
        public CoverTypeController(IUnitOfWork db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<CoverType> coverTypes = _db.CoverType.GetAll();
            return View(coverTypes);
        }
        //Get
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CoverType obj)
        {
          
            if (ModelState.IsValid)
            {
                _db.CoverType.Add(obj);
                _db.Save();
                TempData["success"] = "Create CoverType successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        //Get
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var coverType = _db.CoverType.GetFirstOrDefault(u => u.Id == id);
            if (coverType == null)
            {
                return NotFound();
            }

            return View(coverType);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CoverType obj)
        {
         
            if (ModelState.IsValid)
            {
                _db.CoverType.Update(obj);
                _db.Save();
                TempData["success"] = "Edit CoverType successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        //Get
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var coverType = _db.CoverType.GetFirstOrDefault(u => u.Id == id);
            return View(coverType);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            CoverType obj = _db.CoverType.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.CoverType.Remove(obj);
            _db.Save();
            TempData["success"] = "Delete CoverType successfully";
            return RedirectToAction("Index");
        }
    }
}
