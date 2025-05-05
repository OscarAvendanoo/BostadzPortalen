using AutoMapper;
using BostadzPortalenWebAPI.DTO;
using BostadzPortalenWebAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BostadzPortalenWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Auth : ControllerBase
    {
        private readonly UserManager<ApiUser> userManager;
        private readonly IConfiguration configuration;
        private readonly IMapper mapper;

        public Auth(UserManager<ApiUser> userManager, IConfiguration configuration, IMapper mapper)
        {
            this.userManager = userManager;
            this.configuration = configuration;
            this.mapper = mapper;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterRealtorDTO userDto)
        {
            try
            {
                var user = new ApiUser
                {
                    UserName = userDto.Email,
                    Email = userDto.Email,
                    EmailConfirmed = true
                    // Lägg till FirstName, LastName, AgencyId här om du har det i ApiUser
                };

                var result = await userManager.CreateAsync(user, userDto.Password);

                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                    }
                    return BadRequest(ModelState);
                }

                await userManager.AddToRoleAsync(user, "Realtor");

                return Accepted();
            }
            catch
            {
                return Problem($"Something went wrong in the {nameof(Register)}", statusCode: 500);
            }
        }

        [HttpPost("login")]
        public async Task<ActionResult<AuthResponseDTO>> Login(LoginRealtorDto userDto)
        {
            try
            {
                var user = await userManager.FindByEmailAsync(userDto.Email);

                if (user == null)
                {
                    return Unauthorized("Fel e-post");
                }

                var passwordIsValid = await userManager.CheckPasswordAsync(user, userDto.Password);
                if (!passwordIsValid)
                {
                    return Unauthorized("Fel lösenord");
                }

                string tokenString = await GenerateToken(user);

                var response = new AuthResponseDTO
                {
                    Email = user.Email,
                    Token = tokenString,
                    UserId = user.Id
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                return Problem($"Something went wrong in the {nameof(Login)}: {ex.Message}", statusCode: 500);
            }
        }


        private async Task<string> GenerateToken(ApiUser user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtSettings:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var roles = await userManager.GetRolesAsync(user);
            var roleClaims = roles.Select(role => new Claim(ClaimTypes.Role, role)).ToList();
            var userClaims = await userManager.GetClaimsAsync(user);

            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim("uid", user.Id)
            }
            .Union(roleClaims)
            .Union(userClaims);

            var token = new JwtSecurityToken(
                issuer: configuration["JwtSettings:Issuer"],
                audience: configuration["JwtSettings:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(Convert.ToInt32(configuration["JwtSettings:DurationInMinutes"])),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
