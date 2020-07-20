using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Company.WebApplication1.Models
{
    public class Wing : BaseEntity
    {
        [Display(Name = "Wing Name", Prompt = "Enter Wing Name")]
        [Required(ErrorMessage = "Wing Name is required")]
        [MaxLength(20)]
        public string Name { get; set; }

        [Display(Name = "Wing Short Name", Prompt = "Enter Wing Short Name")]
        [Required(ErrorMessage = "Wing Short Name is required")]
        [MaxLength(5)]
        public string WingShortName { get; set; }

        [Display(Name = "Wing Details", Prompt = "Enter Wing Details")]
        public string Details { get; set; }

    }
}
