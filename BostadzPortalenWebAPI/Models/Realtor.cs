using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BostadzPortalenWebAPI.Models
{
    
    //Author: Kevin
    public class Realtor
    {

        [Required(ErrorMessage ="First name is required")]
        [StringLength(50)]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage ="Invalid email format")]
        [Display(Name ="Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage ="Invalid phone number")]
        [Display(Name ="Phone Number")]
        public int PhoneNumber { get; set; }

        
        [Display(Name ="Profile Image")]
        public string? ProfileImageUrl { get; set; } // Can be null, use placeholder if so

        [Required]
        public int AgencyId { get; set; }

        public RealEstateAgency Agency { get; set; }


        public List<PropertyForSale> Properties { get; set; }

    }
}
