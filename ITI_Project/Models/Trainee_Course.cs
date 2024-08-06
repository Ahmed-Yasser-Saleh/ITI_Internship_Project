using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITI_Project.Models
{
    public class Trainee_Course
    {
            [ForeignKey("Trainee")]
            public int TraineeId { get; set; }
            public Trainee? Trainee { get; set; }
            [ForeignKey("Course")]
            public int CourseId { get; set; }
            public Course? course { get; set; }
            [Range(0, 100)]
            public int? degree { get; set; }
        
    }
}
