using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
namespace ITI_Project.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        [RegularExpression("[a-zA-Z.#]{1,20}",ErrorMessage ="Name must be only character included '.' | '#' with size 1-20 char")]
        public string Name { get; set; }
        [ForeignKey("Department")]
        public int? DeptId {  get; set; }
        [ValidateNever]
        public Department? Department { get; set; }
        [ValidateNever]
        public List<Instructor> Instructorlist { get; set; }
        [ValidateNever]
        public List<Trainee_Course> Trainee_Courselist { get; set; }
        public override string ToString()
        {
            return $"Id:{CourseId} Name: {Name}";
        }
    }
}
