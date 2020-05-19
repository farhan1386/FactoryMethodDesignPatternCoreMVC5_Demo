using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FactoryMethodPatternCoreMvc_Demo.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "EMP No.")]
        public string EmployeeNumber { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Position { get; set; }

        [Required]
        [StringLength(100)]
        public string Office { get; set; }

        [Required]
        [Display(Name = "Hourly Pay")]
        public decimal HourlyPay { get; set; }

        [Required]
        public decimal Bonus { get; set; }

        [Required]
        [Display(Name = "House Allowance")]
        public decimal HouseAllowance { get; set; }

        [Required]
        [Display(Name = "Medical Allowance")]
        public decimal MedicalAllowance { get; set; }

        [Required]
        [ForeignKey("DepartmentId")]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        [Required]
        [ForeignKey("EmployeeTypeId")]
        [Display(Name = "Employee Type")]
        public int EmployeeTypeId { get; set; }
        public EmployeeType EmployeeType { get; set; }
    }
}
