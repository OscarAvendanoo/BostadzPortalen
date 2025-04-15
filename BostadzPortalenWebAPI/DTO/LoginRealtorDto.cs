using System.ComponentModel.DataAnnotations;

namespace BostadzPortalenWebAPI.DTO
{
    public class LoginRealtorDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }  

    }
}
