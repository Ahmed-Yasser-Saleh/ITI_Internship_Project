using ITI_Project.Contex;
using ITI_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ITI_Project.Controllers
{
	public class TraineeCoursesController : Controller
	{
			MyContex db = new MyContex();
		public IActionResult GetALL()
		{
			var trainee_course = db.Trainee_Courses
				.Include(i => i.Trainee)
				.Include(i => i.course)
				.ToList();
			return View(trainee_course);
		}
			public IActionResult New()
			{
				List<int> degree = new List<int> { 0,5,10,15,20,25,30,35,40,45,50,55,60,65,70,75,80,85,90,95,100 };
				ViewBag.degrees = degree;
				var Crs = db.Courses.ToList();
				ViewBag.Crs = Crs;
			    var Trs = db.Trainees.ToList();
		     	ViewBag.Trs = Trs;
				return View();
			}
			[HttpPost]
			public IActionResult Save(Trainee_Course trainee_course)
			{
            //if (trainee_course.TraineeId != null && trainee_course.CourseId != null && trainee_course.degree != null)
            if (ModelState.IsValid)
            {
					db.Trainee_Courses.Add(trainee_course);
					db.SaveChanges();
					return RedirectToAction("GetAll");
				}
				else
				{
                List<int> degree = new List<int> { 0, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 };
                ViewBag.degrees = degree;
                var Crs = db.Courses.ToList();
                ViewBag.Crs = Crs;
                return View("New", trainee_course);
				}

			}
			public IActionResult Edit(int id)
			{
			List<int> degree = new List<int> { 0, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 };
			ViewBag.degrees = degree;
			////var Crs = db.Courses.ToList();
			////ViewBag.Crs = Crs;
			//var trainee_course = db.Trainee_Courses.Include(tc => tc.Trainee).FirstOrDefault(i => i.TraineeId == id);
   //         var deptId = trainee_course?.Trainee?.Deptid;
   //         var Crs = db.Courses.Where(c => c.DeptId == deptId).ToList();
   //         ViewBag.Crs = Crs;
              var trainee_course = db.Trainee_Courses.Include(tc => tc.course).FirstOrDefault(i => i.TraineeId == id);
				return View(trainee_course);
			}
			public IActionResult EditSave(Trainee_Course trainee_course)
			{
			List<int> degree = new List<int> { 0, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 };
			ViewBag.grades = degree;
			var Crs = db.Courses.ToList();
			ViewBag.Crs = Crs;
			//if (trainee_course.TraineeId != null && trainee_course.CourseId != null && trainee_course.degree != null)
			if (ModelState.IsValid)
			{
					db.Trainee_Courses.Update(trainee_course);
					db.SaveChanges();
					return RedirectToAction("GetAll", trainee_course);
		    }
				return View("Edit", trainee_course);
			}

			public IActionResult Delete(int id)
			{
			var trainee_course = db.Trainee_Courses.FirstOrDefault(i => i.TraineeId == id);

                db.Trainee_Courses.Remove(trainee_course);
				db.SaveChanges();
				return RedirectToAction("GetAll");
			}
	}
}
