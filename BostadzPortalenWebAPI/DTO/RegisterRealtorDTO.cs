using BostadzPortalenWebAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace BostadzPortalenWebAPI.DTO
{
    public class RegisterRealtorDTO
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string? ProfileImageUrl { get; set; } // Can be null, use placeholder if so
        
        
        public int AgencyId { get; set; }
        public RealEstateAgency Agency { get; set; }


        public List<PropertyForSale> Properties { get; set; }
    }
}
