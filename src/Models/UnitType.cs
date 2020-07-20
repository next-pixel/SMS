using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Company.WebApplication1.Models
{
    public class UnitType : BaseEntity
    {
        [Display(Name = "Unit Type Name", Prompt = "Enter Unit Type Name")]
        [Required(ErrorMessage = "Unit Type Name is required")]
        [MaxLength(20)]
        public string Name { get; set; }

        [Display(Name = "No of Rooms", Prompt = "Enter No of Rooms")]
        [Required(ErrorMessage = "No of Rooms is required")]
        [MaxLength(1)]
        public int NoofRooms { get; set; }

        [Display(Name = "Area in SQFt", Prompt = "Enter Area in SQFt")]
        [Required(ErrorMessage = "Area in SQFt is required")]
        [MaxLength(10)]
        public int AreaInSQFt { get; set; }

        [Display(Name = "Unit Type Details", Prompt = "Enter Unit Type Details")]
        public string Details { get; set; }

    }
}
