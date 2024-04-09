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
    public class CompanyController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
      

        public CompanyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
           
        }
        public IActionResult Index()
        {
            List<Company> Companys = _unitOfWork.Company.GetAll().ToList();
         
            return View(Companys);
        }
   
        public IActionResult Upsert(int? id)
        {
           
            if(id == null || id == 0)
            {
                return View(new Company());
            }
            else
            {
                Company company= _unitOfWork.Company.Get(u => u.Id == id);
                return View(company);
            }
        }
        [HttpPost]
        public IActionResult Upsert(Company companyObj)
        {
            if (ModelState.IsValid)
            {
                if (companyObj.Id ==0)
                {
                    _unitOfWork.Company.Add(companyObj);
                }
                else
                {
					_unitOfWork.Company.Update(companyObj);
				}
                _unitOfWork.Save();
                TempData["success"] = " create Company successfully";
                return RedirectToAction("Index");
            }
          
            return View(companyObj);
        }
      
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Company> Companys = _unitOfWork.Company.GetAll().ToList();
            return Json(new {data= Companys});
        }
        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var CompanyTobeDeltete = _unitOfWork.Company.Get(u => u.Id == id);
            if(CompanyTobeDeltete == null)
            {
                return Json(new { success = false, message = "error while delete" });
            }
         
            _unitOfWork.Company.Remove(CompanyTobeDeltete);
            _unitOfWork.Save();
          
            return Json(new { success = true, message = " delete success" });
        }
        #endregion
    }
}
