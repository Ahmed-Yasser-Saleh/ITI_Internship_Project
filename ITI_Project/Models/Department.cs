using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ITI_Project.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Trainee> TraineeList { get; set; }
        public List<Instructor> InstructorList { get; set; }
        public List<Course> CourseList {  get; set; }  
        public override string ToString()
        {
            return $"Id:{Id} Name:{Name}";
        }

    }

}
