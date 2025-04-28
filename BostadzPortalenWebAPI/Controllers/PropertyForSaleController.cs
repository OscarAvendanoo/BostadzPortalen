using AutoMapper;
using BostadzPortalenWebAPI.Data;
using BostadzPortalenWebAPI.DTO;
using BostadzPortalenWebAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BostadzPortalenWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyForSaleController : ControllerBase
    {
        private readonly IPropertyForSaleRepository _propertyForSaleRepository;
        private readonly IMapper mapper;
        private readonly ApplicationDbContext _context;

      



        public PropertyForSaleController(IPropertyForSaleRepository propertyForSaleRepository, IMapper mapper, ApplicationDbContext context)
        {
            _propertyForSaleRepository = propertyForSaleRepository;
            this.mapper = mapper;
            _context = context;

        }

        // Author: Oscar
     
        [HttpGet("{id}")]
        public async Task<ActionResult<PropertyForSale>> GetProperty(int id)
        {
            var property = await _propertyForSaleRepository.GetByIDAsync(id);
            if (property == null)
            {
                return NotFound(); 
            }
            return Ok(property); 
        }

        // Author: Oscar

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PropertyForSale>>> GetAllProperties()
        {
            var properties = await _propertyForSaleRepository.GetAllAsync(); 
            if (properties == null || !properties.Any())
            {
                return NotFound(); 
            }
            return Ok(properties); 
        }

        //Author: Kevin
        [HttpGet("GetAllPropertiesIncludeAllAsync")]
        public async Task<ActionResult<IEnumerable<PropertyForSale>>> GetAllPropertiesIncludeAllAsync()
        {
            var properties = await _propertyForSaleRepository.GetAllWithIncludesAsync();
            if (properties == null || !properties.Any())
            {
                return NotFound();
            }
            return Ok(properties);
        }
        //Author: Johan Nelin
        [HttpGet("GetAllPropertyDTO")]
        public async Task<ActionResult<List<PropertyForSaleDTO>>> GetAllPropertyDTO()
        {
            var properties = await _propertyForSaleRepository.GetAllPropertyDTO();
            if (properties == null || !properties.Any())
            {
                return NotFound();
            }
            return Ok(properties);
        }

        // Author: JOna
        // POST api/<PropertyForSaleController>
        [HttpPost]
        [Authorize(Roles = "Realtor")]
        public async Task<ActionResult> CreatePropertyForSale([FromBody] CreatePropertyForSaleDTO dto)
        {
            if (dto == null || !ModelState.IsValid)
                return BadRequest("Invalid input.");

            // Hämta användarens id från token
            var userId = User.FindFirst("uid")?.Value; 

            if (string.IsNullOrEmpty(userId))
                return Unauthorized("User ID not found in token.");

            // Hämta kommunen från DbContext
            var municipality = await _context.Municipalities.FindAsync(dto.MunicipalityId);
            if (municipality == null)
            {
                return BadRequest("Municipality not found.");
            }

            // Hämta Realtor från DbContext
            var realtor = await _context.Realtors
            .Include(r => r.Agency) // inkludera agency också då vafan
            .FirstOrDefaultAsync(r => r.Id == userId);
            if (realtor == null)
            {
                return BadRequest("Realtor not found.");
            }

            // PropertyForSale och sätt RealtorId från JWT-token
            var property = mapper.Map<PropertyForSale>(dto);
            property.RealtorId = userId; //  RealtorId från den inloggade användaren 
            property.Realtor = realtor;  //  Realtor (hela objektet) på fastigheten

            
            await _propertyForSaleRepository.AddAsync(property);

            
            return CreatedAtAction(nameof(GetProperty), new { id = property.PropertyForSaleId }, property);
        }



        // Author: Jona
        // PUT api/<PropertyForSaleController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<PropertyForSale>> UpdateProperty(int id, [FromBody] PropertyForSale updatedPropertyForSale)
        {
            if (updatedPropertyForSale == null)
            {
                return BadRequest("Property cannot be null");
            }
            var existingProperty = await _propertyForSaleRepository.GetByIDAsync(id);
            if (existingProperty == null)
            {
                return NotFound();
            }
            updatedPropertyForSale.PropertyForSaleId = id; // Ensure the ID is set correctly
            await _propertyForSaleRepository.UpdateAsync(updatedPropertyForSale);
            return NoContent(); //204 whop 
        }
        // Author: Jonaaa
        // DELETE api/<PropertyForSaleController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProperty(int id)
        {
            var propertyToDelete = await _propertyForSaleRepository.GetByIDAsync(id);
            if (propertyToDelete == null)
            {
                return NotFound();
            }
            await _propertyForSaleRepository.DeleteAsync(propertyToDelete);
            return NoContent(); 
        }
    }
}
