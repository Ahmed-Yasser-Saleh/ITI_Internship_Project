using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace ITI_Project.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string? Name { get; set; }
        [ForeignKey("Department")]
        public int? DeptId {  get; set; }
        public Department? Department { get; set; }
        public List<Instructor> Instructorlist { get; set; }
        public List<Trainee_Course> Trainee_Courselist { get; set; }
        public override string ToString()
        {
            return $"Id:{CourseId} Name: {Name}";
        }
    }
}
