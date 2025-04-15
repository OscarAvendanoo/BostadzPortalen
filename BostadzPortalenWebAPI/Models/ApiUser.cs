using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BostadzPortalenWebAPI.Models
{
    public class ApiUser : IdentityUser
    {
        [Required(ErrorMessage = "First name is required")]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
    }
}
