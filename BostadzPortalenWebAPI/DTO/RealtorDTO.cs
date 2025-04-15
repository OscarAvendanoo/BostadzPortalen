using BostadzPortalenWebAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace BostadzPortalenWebAPI.DTO
{
    //Author: Oscar
    public class RealtorDTO
    {
        public int RealtorId { get; set; }  
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string? ProfileImageUrl { get; set; } // Can be null, use placeholder if so
        
        
        public int AgencyId { get; set; }
        


        public List<int> PropertyIds { get; set; }
    }
}
