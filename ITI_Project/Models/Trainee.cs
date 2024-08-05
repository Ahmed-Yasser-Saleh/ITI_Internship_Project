using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITI_Project.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string? Name { get; set; }
        [Range(18, 23)]
        public int? age {  get; set; } 
        public string? grade {  get; set; }
        [MaxLength(40)]
        public string? address { get; set; }

        [ForeignKey("Department")]
        public int? Deptid { get; set; }
        public Department? Department { get; set; }
        public List<Trainee_Course> Trainee_Courselist { get; set; }

    }


}
