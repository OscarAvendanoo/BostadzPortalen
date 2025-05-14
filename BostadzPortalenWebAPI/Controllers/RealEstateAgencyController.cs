using AutoMapper;
using BostadzPortalenWebAPI.Data.Interface;
using BostadzPortalenWebAPI.Data.Repo;
using BostadzPortalenWebAPI.DTO;
using BostadzPortalenWebAPI.DTO.AgencyDTO;
using BostadzPortalenWebAPI.DTO.UserDTO;
using BostadzPortalenWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.EntityFrameworkCore;

namespace BostadzPortalenWebAPI.Controllers
{
    //Author: Johan Nelin
    [Route("api/[controller]")]
    [ApiController]
    public class RealEstateAgencyController : ControllerBase
    {
        private readonly IRealEstateAgencyRepository _realEstateAgencyRepository;
        private readonly IRealtorRepository realtorRepo;
        private readonly IMapper mapper;

        public RealEstateAgencyController(IRealEstateAgencyRepository realEstateAgencyRepository, IRealtorRepository realtorRepo, IMapper mapper)
        {
            this._realEstateAgencyRepository = realEstateAgencyRepository;
            this.realtorRepo = realtorRepo;
            this.mapper = mapper;
        }


        // GET: api/<PropertyForSaleController>
        [HttpGet]
        public async Task<IEnumerable<RealEstateAgency>> GetAllAgencies()
        {
            return await _realEstateAgencyRepository.GetAllAsync();
        }

        // GET api/<PropertyForSaleController>/5
        [HttpGet("{id}")]
        public async Task<RealEstateAgency> GetAgencyById(int id)
        {
            return await _realEstateAgencyRepository.GetByIdFullIncludeAsync(id);
        }

        // POST api/<PropertyForSaleController>
        [HttpPost]
        public async Task<ActionResult> CreateAgency([FromBody] RealEstateAgency agency)
        {
            try
            {
                await _realEstateAgencyRepository.AddAsync(agency);
                return Ok(agency);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occured " + ex.Message);
            }
        }

        // PUT api/<PropertyForSaleController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAgency(int id, [FromBody] RealEstateAgency realEstateAgency)
        {
            try
            {
                //updates the agency -> if fails, error
                await _realEstateAgencyRepository.UpdateAsync(realEstateAgency);

                //fetches the updated agency with the ID -> success and updated agency returned -> if fails, error
                return Ok(await _realEstateAgencyRepository.GetByIDAsync(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occured " + ex.Message);
            }
        }

        // DELETE api/<PropertyForSaleController>/5
        [HttpDelete("{id}")]
        public async Task DeleteAgency(int id)
        {
            await _realEstateAgencyRepository.DeleteAsync(await GetAgencyById(id)); //this probably shouldn't be used like this
        }

        [HttpGet("GetAgencyDetailsDTO")]
        public async Task<RealEstateAgencyDetailsDTO> GetAgencyDetailsDTO(int id)
        {

            var agency = await _realEstateAgencyRepository.GetByIdFullIncludeAsync(id);


            var dto = mapper.Map<RealEstateAgencyDetailsDTO>(agency);

            

            return dto;

        }

        [HttpGet("GetAllAgencyIncludeAll")]
        public async Task<List<RealEstateAgencyDetailsDTO>> GetAllAgencyDetailsDTO()
        {
            var agencyDetails = new List<RealEstateAgencyDetailsDTO>();
            
            var agencies = await _realEstateAgencyRepository.GetAllFullIncludeAsync();

            foreach(var agency in agencies)
            {
                var details = mapper.Map<RealEstateAgencyDetailsDTO>(agency);
                agencyDetails.Add(details);
            }
            

            return agencyDetails;
        }
    }
}
