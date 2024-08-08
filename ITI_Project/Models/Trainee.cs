using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITI_Project.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        [RegularExpression("[a-zA-Z ]{4,25}", ErrorMessage = "Name must be only character with size 4-25 char")] //name minlength 4, max lenght 25
        public string Name { get; set; }
        [Range(18, 23, ErrorMessage = "Age Range must be between 18 - 23")]
        public int age {  get; set; } 
        public string? grade {  get; set; }
		[MinLength(4, ErrorMessage = "address Range must be between 4 - 40")]
		[MaxLength(40, ErrorMessage = "address Range must be between 4 - 40")]
        public string address { get; set; }

        [ForeignKey("Department")]
        public int? Deptid { get; set; }
        [ValidateNever]
        public Department? Department { get; set; }
        [ValidateNever]
        public List<Trainee_Course> Trainee_Courselist { get; set; }

    }


}
