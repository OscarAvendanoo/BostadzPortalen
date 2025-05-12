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
        private readonly IPropertyForSaleRepository propertyForSaleRepository;
        private readonly IMapper mapper;

        public RealtorController(IRealtorRepository realtorRepository, IPropertyForSaleRepository propertyForSaleRepository, IMapper mapper)
        {
            this.realtorRepository = realtorRepository;
            this.propertyForSaleRepository = propertyForSaleRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllRealtors()
        {
            return Ok(await realtorRepository.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetRealtor(string id) //string id??
        {
            var realtor = await realtorRepository.GetRealtorByGuidAsync(id);

            if (realtor == null)
            {
                return NotFound();
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
                //mapper.Map<Realtor>(dto);
                //realtor.RealtorId = id;

                await realtorRepository.UpdateAsync(realtor);
                return Ok(realtor);
            }
            catch (Exception ex)
            {

                return StatusCode(500, "An error occured " + ex.Message);
            }
        }

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

        [HttpGet("/GetRealtorInfo/{id}")]
        public async Task<ActionResult<RealtorInfoDTO>> GetRealtorInfo(string id)
        {
            var images = new List<PropertyImageDto>();
            List<PropertyForSaleOverviewDTO> propsList = new List<PropertyForSaleOverviewDTO>();
            var realtor = await realtorRepository.GetRealtorInfoDTO(id);
          
            
            
            foreach(var prop in realtor.Properties)
            {
                var property = mapper.Map<PropertyForSaleOverviewDTO>(prop);
                propsList.Add(property);

                foreach (var picture in prop.ImageUrls)
                {
                    var image = mapper.Map<PropertyImageDto>(picture);
                    images.Add(image);
                }
            }
            
            try
            {


                var realtorInfo = new RealtorInfoDTO
                {
                    RealtorId = realtor.Id,
                    FullName = $"{realtor.FirstName} {realtor.LastName}",
                    AgencyName = realtor.Agency.AgencyName,
                    Email = realtor.Email,
                    Phone = realtor.PhoneNumber,
                    Properties = propsList,
                    RealtorImage = realtor.ProfileImageUrl,
                    PropertyImages = images
                    

                };
                //mapper.Map<RealtorInfoDTO>(propp);

                return Ok(realtorInfo);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Något fick fel: {ex.Message}");
            }
            return BadRequest();
        }


        // Jona
        [Authorize(Roles = "Realtor")]
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



        //[HttpGet("{id}")]
        //public async Task<ActionResult> GetListedProperties(string id)
        //{
        //    if (id == null)
        //    {
        //        return BadRequest("You have no listed properties");
        //    }
        //    return Ok(await realtorRepository.GetListedPropertiesAsync(id));
        //}

        //[HttpPost]
        //public async Task<ActionResult> AddPropertyForSale([FromForm] PropertyForSaleDTO dto) //ska denna vara här eller porpertuForSaleController?
        //{
        //    if (dto == null)
        //    {
        //        return BadRequest("Invalid input");
        //    }
        //    var pfs = mapper.Map<PropertyForSale>(dto);
        //    await realtorRepository.AddPropertyForSale(pfs);
        //    return Ok();
        //}

        //[HttpPut("{id}")]
        //public async Task<ActionResult> EditPropertyForSale([FromForm] PropertyForSaleDTO dto)
        //{
        //    if (dto == null)
        //    {
        //        return BadRequest("Invalid input.");
        //    }
        //    var pfs = mapper.Map<PropertyForSale>(dto);
        //    return Ok(await realtorRepository.EditPropertyForSale(pfs));
        //}

    }
}
