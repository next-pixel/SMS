using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Company.WebApplication1.Models
{
    public class Department : BaseEntity
    {
        [Display(Name = "Department Name", Prompt = "Enter Department Name")]
        [Required(ErrorMessage = "Department Name is required")]
        [MaxLength(30)]
        public string DepartmentName { get; set; }

        [Display(Name = "Department Details", Prompt = "Enter Department Details")]
        public string Details { get; set; }
    }
}
