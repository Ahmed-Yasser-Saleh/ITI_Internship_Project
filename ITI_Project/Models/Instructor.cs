using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITI_Project.Models
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        [RegularExpression("[a-zA-Z ]{4,25}", ErrorMessage = "Name must be only character with size 4-25 char")] //name minlength 4, max lenght 25
        public string Name { get; set; }
        [Range(25, 40, ErrorMessage = "Age Range must be between 25 - 40")]
        public int age { get; set; }
        [Range(5000, 10000, ErrorMessage = "Salary Range must be between 5000 - 10000")]
        public int salary {  get; set; }

        [ForeignKey("Course")]
        public int? CourseId { get; set; }
        [ValidateNever]
        public Course Course { get; set; }

        [ForeignKey("Department")]
        public int? Deptid { get; set; }
        [ValidateNever]
        public Department Department { get; set; }
        public override string ToString()
        {
            return $"Id: {InstructorId}, Name: {Name}, age: {age}, salary: {salary}, Course: {Course.Name}, Department: {Department.Name}";
        }

    }
}
