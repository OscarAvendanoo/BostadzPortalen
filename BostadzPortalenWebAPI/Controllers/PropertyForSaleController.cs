using BostadzPortalenWebAPI.Data;
using BostadzPortalenWebAPI.Models;
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
        public async Task<ActionResult<PropertyForSale>> Get(int id)
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
        public async Task<ActionResult<IEnumerable<PropertyForSale>>> GetAll()
        {
            var properties = await _propertyForSaleRepository.GetAllAsync(); 
            if (properties == null || !properties.Any())
            {
                return NotFound(); 
            }
            return Ok(properties); 
        }

        // POST api/<PropertyForSaleController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PropertyForSaleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PropertyForSaleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
