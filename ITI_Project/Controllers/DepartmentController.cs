using ITI_Project.Contex;
using ITI_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ITI_Project.Controllers
{
    public class DepartmentController : Controller
    {
        MyContex db = new MyContex();
	public IActionResult GetALL()
        {
            var res = db.Departments.ToList();
            return View(res);
        }
        public IActionResult Details(int id)
        {
            var res = db.Departments.FirstOrDefault(i => i.Id == id);
            return View("Details", res);
        }
        public IActionResult New()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Save(Department Dept)
        {
            //if (Dept.Name != null)
            if(ModelState.IsValid)
            {
                db.Departments.Add(Dept);
                db.SaveChanges();
                return RedirectToAction("GetAll");
            }
            else
            {
                return View("New", Dept);
            }

        }
        public IActionResult Edit(int id)
        {
            var dept = db.Departments.FirstOrDefault(i => i.Id == id);
            return View(dept);
        }
        [HttpPost]
        public IActionResult EditSave(Department Dept)
        {
            //if (Dept.Name != null)
            if (ModelState.IsValid)
            {
                db.Departments.Update(Dept);
                db.SaveChanges();
                return RedirectToAction("GetAll", Dept);
            }
            return View("Edit", Dept);
        }

        public IActionResult Delete(int id)
        {
            var Dept = db.Departments.FirstOrDefault(i => i.Id == id);
            db.Departments.Remove(Dept);
            db.SaveChanges();
            return RedirectToAction("GetAll");
        }
    }
}
