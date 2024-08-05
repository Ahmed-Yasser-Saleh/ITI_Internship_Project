using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ITI_Project.Contex;
using ITI_Project.Models;

namespace ITI_Project.Controllers
{
    public class InstructorController : Controller
    {
        MyContex db = new MyContex();
        
        public IActionResult GetALL()
        {
            var res = db.Instructors
                .Include(e => e.Course)
                .Include(i => i.Department)
                .ToList();
            return View(res);
        }
        public IActionResult Details(int id)
        {
            var res = db.Instructors.Include(e => e.Course)
                .Include(i => i.Department).FirstOrDefault(i => i.InstructorId == id);
            return View("Details", res);
        }
        public IActionResult New()
        {
            var crs = db.Courses.ToList();
            var depts = db.Departments.ToList();
            ViewBag.crs = crs;
            ViewBag.depts = depts;
            return View();
        }
        [HttpPost]
        public IActionResult Save(Instructor inst)
        {
            if (inst.CourseId != 0 && inst.Deptid != 0 && inst.Name != null
              && inst.salary != null && inst.age != null)

            {
                db.Instructors.Add(inst);
                db.SaveChanges();
                return RedirectToAction("GetAll");
           }
            else
            {
                var crs = db.Courses.ToList();
                var depts = db.Departments.ToList();
                ViewBag.crs = crs;
                ViewBag.depts = depts;
                return View("New", inst);
            }
           
        }
        public IActionResult Edit(int id)
        {
			var crs = db.Courses.ToList();
			var depts = db.Departments.ToList();
			ViewBag.crs = crs;
			ViewBag.depts = depts;
			var inst = db.Instructors.FirstOrDefault(i => i.InstructorId==id);
            return View(inst);
        }
        public IActionResult EditSave(Instructor inst)
        {
			var crs = db.Courses.ToList();
			var depts = db.Departments.ToList();
			ViewBag.crs = crs;
			ViewBag.depts = depts;
            if (inst.CourseId != 0 && inst.Deptid != 0 && inst.Name != null
               && inst.salary != null && inst.age != null)
            {
                db.Instructors.Update(inst);
                db.SaveChanges();
                return RedirectToAction("GetAll", inst);
            }
            return View("Edit",inst);
        }
  
        public IActionResult Delete(Instructor inst)
        {
            db.Instructors.Remove(inst);
            db.SaveChanges();
            return RedirectToAction("GetAll");
        }
    }
}
