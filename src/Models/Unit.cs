using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Company.WebApplication1.Models
{
    public class Unit : BaseEntity
    {
        [Display(Name = "Wing", Prompt = "Select Wing")]
        [Required(ErrorMessage = "Wing is required")]
        public int WingId { get; set; }

        [Display(Name = "Unit Number", Prompt = "Enter Unit Number")]
        [Required(ErrorMessage = "Unit Number is required")]
        [MaxLength(20)]
        public string UnitNumber { get; set; }

        [Display(Name = "Unit Type", Prompt = "Select Unit Type")]
        [Required(ErrorMessage = "Unit Type is required")]
        public int UnitTypeId { get; set; }

        [Display(Name = "Unit Status", Prompt = "Select Unit Status")]
        [Required(ErrorMessage = "Unit Status is required")]
        public int UnitStatusId { get; set; }

        [Display(Name = "Unit Details", Prompt = "Enter Unit Details")]
        public string Details { get; set; }
    }
}
