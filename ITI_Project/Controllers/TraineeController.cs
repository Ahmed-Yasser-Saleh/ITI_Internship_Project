﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ITI_Project.Contex;
using ITI_Project.Models;



namespace ITI_Project.Controllers
{
	public class TraineeController : Controller
	{
		MyContex db = new MyContex();
		public IActionResult GetALL()
		{
			var trainee = db.Trainees
				.Include(i => i.Department)
				.ToList();
			return View(trainee);
		}
		public IActionResult Details(int id)
		{
			var trainee = db.Trainees
				.Include(i => i.Department).FirstOrDefault(i => i.Id == id);
			return View("Details", trainee);
		}
		public IActionResult New()
		{
            List<string> grades = new List<string> { "F", "D-", "D", "D+", "C-", "C", "C+", "B-", "B", "B+", "A-", "A" };
            ViewBag.grades = grades;
			var depts = db.Departments.ToList();
			ViewBag.depts = depts;
			return View();
		}
		[HttpPost]
		public IActionResult Save(Trainee trainee)
		{
     //       if (trainee.Deptid != 0 && trainee.Name != null
			  //&& trainee.grade != null && trainee.address != null)
			if(ModelState.IsValid)
			{
				db.Trainees.Add(trainee);
				db.SaveChanges();
				return RedirectToAction("GetAll");
			}
			else
			{
                List<string> grades = new List<string> { "F","D-", "D", "D+", "C-", "C", "C+", "B-", "B", "B+", "A-", "A" };
                ViewBag.grades = grades;
                var depts = db.Departments.ToList();
				ViewBag.depts = depts;
				return View("New", trainee);
			}
		}
		public IActionResult Edit(int id)
		{
            List<string> grades = new List<string> {"F","D-", "D", "D+", "C-", "C", "C+", "B-", "B","B+", "A-","A"};
            ViewBag.grades = grades;
            var depts = db.Departments.ToList();
            ViewBag.depts = depts;
            var trainee = db.Trainees.FirstOrDefault(i => i.Id == id);
			return View(trainee);
		}
        [HttpPost]
        public IActionResult EditSave(Trainee trainee)
		{
            List<string> grades = new List<string> { "D-", "D", "D+", "C-", "C", "C+", "B-", "B", "B+", "A-", "A" };
            ViewBag.grades = grades;
            var depts = db.Departments.ToList();
            ViewBag.depts = depts;
            //       if (trainee.Deptid != 0 && trainee.Name != null
            //&& trainee.grade != null && trainee.address != null)
            if (ModelState.IsValid)
            {
				db.Trainees.Update(trainee);
				db.SaveChanges();
				return RedirectToAction("GetAll", trainee);
			}
			return View("Edit", trainee);
		}

		public IActionResult Delete(int id)
		{
			var trainee = db.Trainees.FirstOrDefault(i => i.Id == id);
			db.Trainees.Remove(trainee);
			db.SaveChanges();
			return RedirectToAction("GetAll");
		}
	}
}
