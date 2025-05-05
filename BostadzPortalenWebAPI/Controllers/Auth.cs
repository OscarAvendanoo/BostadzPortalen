using AutoMapper;
using BostadzPortalenWebAPI.DTO;
using BostadzPortalenWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BostadzPortalenWebAPI.Controllers
{
    //Author: ALL
    [Route("api/[controller]")]
    [ApiController]
    public class Auth : ControllerBase
    {
        private readonly UserManager<ApiUser> userManager;
        private readonly IMapper mapper;
        private readonly IConfiguration configuration;

        public Auth(UserManager<ApiUser> userManager, IMapper mapper, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.mapper = mapper;
            this.configuration = configuration;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(RegisterRealtorDTO userDto)
        {
            try
            {
                //var realtor = mapper.Map<Realtor>(realtorDto);
                Realtor user = new Realtor()
                {
                    UserName = userDto.Email,
                    Email = userDto.Email,
                    FirstName = userDto.FirstName,
                    LastName = userDto.LastName,
                    AgencyId = userDto.AgencyId,
                    EmailConfirmed = true


                };

                var result = await userManager.CreateAsync(user, userDto.Password);

                if (result.Succeeded == false)
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
            catch (Exception ex)
            {

                return Problem($"Something went wrong in the {nameof(Register)}", statusCode: 500);
            }
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<AuthResponseDTO>> Login(LoginRealtorDto userDto)
        {
            try
            {
                var user = await userManager.FindByEmailAsync(userDto.Email);
                var passwordIsValid = await userManager.CheckPasswordAsync(user, userDto.Password);

                if (user == null || passwordIsValid == false)
                {
                    return Unauthorized(userDto);
                }


                //skapa en DTOklass AuthResponse med props: UserId, Token, Email

                string tokenString = await GenerateToken(user);

                var response = new AuthResponseDTO
                {
                    Email = userDto.Email,
                    Token = tokenString,
                    UserId = user.Id
                };

                return Ok(response);
            }
            catch
            {
                return Problem($"Something went wrong in the {nameof(Login)}", statusCode: 500);
            }
        }

        private async Task<string> GenerateToken(ApiUser user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtSettings:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var roles = await userManager.GetRolesAsync(user);
            var roleClaims = roles.Select(q => new Claim(ClaimTypes.Role, q)).ToList();

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
