using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Company.WebApplication1.Models
{
    public class Designation : BaseEntity
    {
        [Display(Name = "Designation Name", Prompt = "Enter Designation Name")]
        [Required(ErrorMessage = "Designation Name is required")]
        [MaxLength(30)]
        public string DepartmentName { get; set; }

        [Display(Name = "Designation Details", Prompt = "Enter Designation Details")]
        public string Details { get; set; }
    }
}
