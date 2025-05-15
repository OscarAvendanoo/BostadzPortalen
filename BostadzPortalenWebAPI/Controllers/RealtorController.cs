using AutoMapper;
using BostadzPortalenWebAPI.Data.Interface;
using BostadzPortalenWebAPI.DTO;
using BostadzPortalenWebAPI.DTO.UserDTO;
using BostadzPortalenWebAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
using System.Security.Claims;

namespace BostadzPortalenWebAPI.Controllers
{
    //Author: Kevin co.author Oscar(en endpoint)

    [Route("api/[controller]")]
    [ApiController]
    public class RealtorController : ControllerBase
    {
        private readonly IRealtorRepository realtorRepository;
        private readonly IMapper mapper;

        public RealtorController(IRealtorRepository realtorRepository, IMapper mapper)
        {
            this.realtorRepository = realtorRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllRealtors()
        {
            return Ok(await realtorRepository.GetAllAsync());
        }

        //Author: Kevin
        [HttpGet("{id}")]
        public async Task<ActionResult> GetRealtor(string id)
        {
            var realtor = await realtorRepository.GetRealtorByGuidAsync(id);

            if (realtor == null)
            {
                return NotFound($"No realtor with ID: {id}");
            }

            return Ok(realtor);
        }
        //Author: Johan Nelin
        [HttpGet("RealtorProperties/{id}")]
        public async Task<ActionResult<List<PropertyForSaleOverviewDTO>>> GetPropertyOverviewDTOFromRealtorId(string id)
        {
            var realtor = await realtorRepository.GetRealtorByGuidAsync(id);

            var allDTOs = new List<PropertyForSaleOverviewDTO>();
            if (realtor == null || realtor.Properties == null)
            {
                return NotFound();
            }

            foreach (var property in realtor.Properties)
            {
                allDTOs.Add(mapper.Map<PropertyForSaleOverviewDTO>(property));
            }

            return Ok(allDTOs);
        }


        //Author: Kevin, Oscar
        [Authorize(Roles = "Administrator, Realtor")]
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateRealtor(int id, [FromBody] RegisterRealtorDTO dto)
        {

            try
            {
                if (dto == null)
                {
                    return BadRequest("Invalid input.");
                }

                var realtor = await realtorRepository.GetByIDAsync(id);
                if (realtor == null)
                {
                    return NotFound();
                }

                mapper.Map(realtor, dto);
                
                await realtorRepository.UpdateAsync(realtor);
                return Ok(realtor);
            }
            catch (Exception ex)
            {

                return StatusCode(500, "An error occured " + ex.Message);
            }
        }

        [Authorize(Roles = "Administrator, Realtor")]
        [HttpPost]
        public async Task<ActionResult> CreateRealtor([FromBody] RegisterRealtorDTO dto)
        {
            try
            {
                if (dto == null)
                {
                    return BadRequest("Invalid input.");
                }

                var realtor = mapper.Map<Realtor>(dto);
                await realtorRepository.AddAsync(realtor);
                return Ok(realtor);
            }
            catch (Exception ex)
            {

                return StatusCode(500, "An error occured " + ex.Message);
            }
        }

        [Authorize(Roles = "Administrator, Realtor")]
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteRealtor(int id)
        {
            var realtor = await realtorRepository.GetByIDAsync(id);

            if (realtor == null)
            {
                return NotFound();
            }

            await realtorRepository.DeleteAsync(realtor);
            return NoContent();
        }

        // author: Oscar
        [Authorize]
        [HttpGet("me")]
        public async Task<ActionResult<Realtor>> GetCurrentRealtor()
        {

            var userId = User.FindFirst("uid")?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized("Invalid or missing user ID in token.");
            }

            var realtor = await realtorRepository.GetRealtorByGuidAsync(userId);

            if (realtor == null)
            {
                return NotFound();
            }

            return Ok(realtor);
        }

        //Author: Kevin
        [HttpGet("FindRealtorByName/{firstName}/{lastName}")]
        public async Task<ActionResult<Realtor>> FindRealtorByName(string firstName, string lastName)
        {
            try
            {
                var realtor = await realtorRepository.GetByNameIncludesAsync(firstName, lastName);
                return Ok(realtor);
            }
            catch (Exception ex)
            {
                return BadRequest($"Kunder inte hämta realtor: {ex.Message}");

            }


        }

        //Author: Kevin
        [HttpGet("/GetRealtorInfo/{id}")]
        public async Task<ActionResult<RealtorInfoDTO>> GetRealtorInfo(string id)
        {

            try
            {
                var realtor = await realtorRepository.GetRealtorInfoDTO(id);

                if (realtor == null)
                {
                    return NotFound($"No realtor with ID: {id}");
                }

                var propsList = realtor.Properties
                    .Select(prop => mapper.Map<PropertyForSaleOverviewDTO>(prop))
                    .ToList();

                var images = realtor.Properties
                    .SelectMany(p => p.ImageUrls)
                    .Select(img => mapper.Map<PropertyImageDto>(img))
                    .ToList();

                var realtorInfo = new RealtorInfoDTO
                {
                    RealtorId = realtor.Id,
                    FullName = $"{realtor.FirstName} {realtor.LastName}",
                    AgencyName = realtor.Agency.AgencyName,
                    Email = realtor.Email,
                    Phone = realtor.PhoneNumber,
                    Properties = propsList,
                    RealtorImage = realtor.ProfileImageUrl,
                    PropertyImages = images,
                    AgencyLogoUrl = realtor.Agency.AgencyLogoUrl,
                    RealEstateAgencyId = realtor.Agency.RealEstateAgencyId
                };

                return Ok(realtorInfo);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Something went wrong: {ex.Message}");
                return StatusCode(500, "Internal error");
            }
           
        }


        // Jona
        [Authorize(Roles = "Administrator, Realtor")]
        [HttpPatch("me")]
        public async Task<IActionResult> UpdateMyProfile([FromBody] RealtorUpdateDTO dto)
        {
            try
            {
                var userId = User.FindFirst("uid")?.Value;
                if (string.IsNullOrEmpty(userId))
                    return Unauthorized("Invalid or missing user ID in token.");

                var realtor = await realtorRepository.GetRealtorByGuidAsync(userId);
                if (realtor == null)
                    return NotFound("Realtor not found.");

                if (!string.IsNullOrWhiteSpace(dto.FirstName))
                    realtor.FirstName = dto.FirstName;

                if (!string.IsNullOrWhiteSpace(dto.LastName))
                    realtor.LastName = dto.LastName;

                if (!string.IsNullOrWhiteSpace(dto.Email))
                    realtor.Email = dto.Email;

                if (!string.IsNullOrWhiteSpace(dto.PhoneNumber))
                    realtor.PhoneNumber = dto.PhoneNumber;

                if (!string.IsNullOrWhiteSpace(dto.ProfileImageUrl))
                    realtor.ProfileImageUrl = dto.ProfileImageUrl;

                await realtorRepository.UpdateAsync(realtor);
                return Ok("Profile updated successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred: " + ex.Message);
            }
        }

    }
}
