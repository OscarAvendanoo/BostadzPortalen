using AutoMapper;
using BostadzPortalenWebAPI.DTO;
using BostadzPortalenWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BostadzPortalenWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Auth : ControllerBase
    {
        private readonly UserManager<ApiUser> userManager;
        private readonly IMapper mapper;

        public Auth(UserManager<ApiUser> userManager, IMapper mapper)
        {
            this.userManager = userManager;
            this.mapper = mapper;
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

                return Ok();
            }
            catch (Exception ex)
            {

                return Problem($"Something went wrong in the {nameof(Register)}", statusCode: 500);
            }
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(LoginRealtorDto userDto)
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

                //string tokenString = await GenerateToken(user);

                //var response = new AuthResponse
                //{
                //    Email = userDto.Email,
                //    tokenString = tokenString,
                //    UserId = user.Id
                //};

                return Ok();
            }
            catch
            {
                return Problem($"Something went wrong in the {nameof(Login)}", statusCode: 500);
            }
        }
    }
}
