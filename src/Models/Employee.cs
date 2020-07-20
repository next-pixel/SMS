using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Company.WebApplication1.Models
{
    public class Employee : BaseEntity
    {
        [Display(Name = "Employee Name", Prompt = "Enter Employee Name")]
        [Required(ErrorMessage = "Employee Name is required")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Display(Name = "Employee Name", Prompt = "Enter Employee Name")]
        [Required(ErrorMessage = "Employee Name is required")]
        [MaxLength(50)]
        public string CurrentAddress { get; set; }

        [Display(Name = "Employee Name", Prompt = "Enter Employee Name")]
        [Required(ErrorMessage = "Employee Name is required")]
        [MaxLength(50)]
        public string PermanentAddress { get; set; }

        [Display(Name = "Employee Name", Prompt = "Enter Employee Name")]
        [Required(ErrorMessage = "Employee Name is required")]
        [MaxLength(50)]
        public string MobileNo { get; set; }

        [Display(Name = "Employee Name", Prompt = "Enter Employee Name")]
        [Required(ErrorMessage = "Employee Name is required")]
        [MaxLength(50)]
        public string AlternativeNumber { get; set; }

        [Display(Name = "Employee Name", Prompt = "Enter Employee Name")]
        [Required(ErrorMessage = "Employee Name is required")]
        [MaxLength(50)]
        public string Email { get; set; }

        [Display(Name = "Employee Name", Prompt = "Enter Employee Name")]
        [Required(ErrorMessage = "Employee Name is required")]
        [MaxLength(50)]
        public string DOB { get; set; }

        [Display(Name = "Employee Name", Prompt = "Enter Employee Name")]
        [Required(ErrorMessage = "Employee Name is required")]
        [MaxLength(50)]
        public string DepartmentID { get; set; }

        [Display(Name = "Employee Name", Prompt = "Enter Employee Name")]
        [Required(ErrorMessage = "Employee Name is required")]
        [MaxLength(50)]
        public string DesignationID { get; set; }
    }
}
