using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ITI_Project.Models
{
    public class Department
    {
        public int Id { get; set; }
        [RegularExpression("[a-zA-Z]{2,20}", ErrorMessage = "Name must be only character with size 2-20 char")]
        public string Name { get; set; }
        [ValidateNever]
        public List<Trainee> TraineeList { get; set; }
        [ValidateNever]
        public List<Instructor> InstructorList { get; set; }
        [ValidateNever]
        public List<Course> CourseList {  get; set; }  
        public override string ToString()
        {
            return $"Id:{Id} Name:{Name}";
        }

    }

}
