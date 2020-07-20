using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.WebApplication1.Models
{
    [Table("Society")]
    public class Society : BaseEntity
    {
        [Display(Name = "Society Full Name", Prompt = "Enter Society Full Name")]
        [Required(ErrorMessage = "Society Full Name is required")]
        [MaxLength(100)]
        public string FullName { get; set; }

        [Display(Name = "Establishment Year", Prompt = "Enter Establishment Year")]
        [Required(ErrorMessage = "Establishment Year is required")]
        [MaxLength(4)]
        [MinLength(4)]
        public int YearEST { get; set; }

        [Display(Name = "Registration Number", Prompt = "Enter Registration Number")]
        [Required(ErrorMessage = "Registration Number is required")]
        [MaxLength(50)]
        public string RegNo { get; set; }

        [Display(Name = "Address Line 1", Prompt = "Enter Address Line 1")]
        [Required(ErrorMessage = "Address Line 1 is required")]
        [MaxLength(50)]
        public string Street1Address { get; set; }

        [Display(Name = "Address Line 2", Prompt = "Enter Address Line 2")]
        [MaxLength(50)]
        public string Street2Address { get; set; }

        [Display(Name = "City", Prompt = "Enter City Name")]
        [Required(ErrorMessage = "City Name is required")]
        [MaxLength(50)]
        public string City { get; set; }

        [Display(Name = "Pincode", Prompt = "Enter Pincode")]
        [Required(ErrorMessage = "Pincode is required")]
        [MaxLength(6)]
        [MinLength(6)]
        public int Pincode { get; set; }

        [Display(Name = "State", Prompt = "Enter State Name")]
        [Required(ErrorMessage = "State Name is required")]
        [MaxLength(50)]
        public string State { get; set; }

        [Display(Name = "Society Details", Prompt = "Enter Society Details")]
        public string Details { get; set; }

    }
}
