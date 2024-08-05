using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITI_Project.Models
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        [MaxLength(20)]
        public string? Name { get; set; }
        [Range(25, 40)]
        public int? age { get; set; }
        public int? salary {  get; set; }

        [ForeignKey("Course")]
        public int? CourseId { get; set; }
        public Course Course { get; set; }

        [ForeignKey("Department")]
        public int? Deptid { get; set; }
        public Department Department { get; set; }
        public override string ToString()
        {
            return $"Id: {InstructorId}, Name: {Name}, age: {age}, salary: {salary}, Course: {Course.Name}, Department: {Department.Name}";
        }

    }
}
