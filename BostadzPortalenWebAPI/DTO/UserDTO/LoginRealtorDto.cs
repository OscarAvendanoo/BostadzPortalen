using System.ComponentModel.DataAnnotations;

namespace BostadzPortalenWebAPI.DTO.UserDTO
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
