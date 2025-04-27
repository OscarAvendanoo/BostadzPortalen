using BostadzPortalenWebAPI.Data;
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
        public PropertyForSaleController(IPropertyForSaleRepository propertyForSaleRepository)
        {
            _propertyForSaleRepository = propertyForSaleRepository;
            
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
            var properties = await _propertyForSaleRepository.GetAllWithIncludesAsync();
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

        // Author: JOna
        // POST api/<PropertyForSaleController>
        [HttpPost]
        public async Task<ActionResult<PropertyForSale>> PostProperty([FromBody] PropertyForSale propertyForSale)
        {
            if (propertyForSale == null)
            {
                return BadRequest("Property cannot be null");
            }
            await _propertyForSaleRepository.AddAsync(propertyForSale);
            return CreatedAtAction(nameof(GetProperty), new { id = propertyForSale.PropertyForSaleId }, propertyForSale);
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
