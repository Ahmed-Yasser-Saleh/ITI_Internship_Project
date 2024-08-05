using ITI_Project.Contex;
using ITI_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ITI_Project.Controllers
{
    public class CourseController : Controller
    {
        MyContex db = new MyContex();
        public IActionResult GetALL()
        {
            var res = db.Courses.Include(d => d.Department).ToList();
            return View(res);
        }
        public IActionResult Details(int id)
        {
            var res = db.Courses.Include(d => d.Department).FirstOrDefault(i => i.CourseId == id);
            return View("Details", res);
        }
        public IActionResult New()
        {
            var depts = db.Departments.ToList();
            ViewBag.depts = depts;
            return View();
        }
        [HttpPost]
        public IActionResult Save(Course Crs)
        {
            if (Crs.DeptId != null && Crs.Name != null)
				{
                db.Courses.Add(Crs);
                db.SaveChanges();
                return RedirectToAction("GetAll");
            }
            else
            {
                var depts = db.Departments.ToList();
                ViewBag.depts = depts;
                return View("New", Crs);
            }

        }
        public IActionResult Edit(int id)
        {
            var depts = db.Departments.ToList();
            ViewBag.depts = depts;
            var inst = db.Courses.FirstOrDefault(i => i.CourseId == id);
            return View(inst);
        }
        public IActionResult EditSave(Course Crs)
        {
            var depts = db.Departments.ToList();
            ViewBag.depts = depts;
			if (Crs.DeptId != null && Crs.Name != null)   
			{
                db.Courses.Update(Crs);
                db.SaveChanges();
                return RedirectToAction("GetAll", Crs);
            }
            return View("Edit", Crs);
        }

        public IActionResult Delete(Course Crs)
        {
			db.Courses.Remove(Crs);
            db.SaveChanges();
            return RedirectToAction("GetAll");
        }
    }
}
