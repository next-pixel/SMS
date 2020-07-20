using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Company.WebApplication1.Models
{
    public class UnitStatus : BaseEntity
    {
        [Display(Name = "Unit Status", Prompt = "Enter Unit Status")]
        [Required(ErrorMessage = "Unit Status is required")]
        [MaxLength(20)]
        public string UnitStatusName { get; set; }

        [Display(Name = "Unit Status Details", Prompt = "Enter Unit Status Details")]
        public string Details { get; set; }


    }
}
