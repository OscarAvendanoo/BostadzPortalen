using AutoMapper;
using BostadzPortalenWebAPI.Data;
using BostadzPortalenWebAPI.DTO;
using BostadzPortalenWebAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BostadzPortalenWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyForSaleController : ControllerBase
    {
        private readonly IPropertyForSaleRepository _propertyForSaleRepository;
        private readonly IMapper mapper;
        public PropertyForSaleController(IPropertyForSaleRepository propertyForSaleRepository, IMapper mapper)
        {
            _propertyForSaleRepository = propertyForSaleRepository;
            this.mapper = mapper;

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

        // Author: JOna
        // POST api/<PropertyForSaleController>
        [HttpPost]
        public async Task<ActionResult> CreatePropertyForSale(CreatePropertyForSaleDTO dto)
        {
            if (dto == null)
                return BadRequest("Invalid input.");

            var property = mapper.Map<PropertyForSale>(dto);
            await _propertyForSaleRepository.AddAsync(property);
            return Ok(property);
        }
        // Author: Jona
        // PUT api/<PropertyForSaleController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] PropertyForSaleDTO dto)
        {
            if (dto == null)
                return BadRequest("Invalid input.");

            var existingProperty = await _propertyForSaleRepository.GetByIDAsync(id);
            if (existingProperty == null)
                return NotFound();

            mapper.Map(dto, existingProperty);
            await _propertyForSaleRepository.UpdateAsync(existingProperty);

            return NoContent();
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
