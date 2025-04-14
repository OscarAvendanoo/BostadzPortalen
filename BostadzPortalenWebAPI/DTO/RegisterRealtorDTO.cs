using BostadzPortalenWebAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace BostadzPortalenWebAPI.DTO
{
    //Author: Kevin
    public class RegisterRealtorDTO
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string? ProfileImageUrl { get; set; } // Can be null, use placeholder if so
        
        
        public int AgencyId { get; set; }

        
    }
}
