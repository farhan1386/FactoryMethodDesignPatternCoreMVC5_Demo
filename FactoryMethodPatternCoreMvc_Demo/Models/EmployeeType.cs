using System.ComponentModel.DataAnnotations;

namespace FactoryMethodPatternCoreMvc_Demo.Models
{
    public class EmployeeType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Employee Type")]
        public string EmployeeTypeName { get; set; }
    }
}
