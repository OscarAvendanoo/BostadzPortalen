
using BostadzPortalenWebAPI.Data;

using AutoMapper;

using BostadzPortalenWebAPI.DTO;
using BostadzPortalenWebAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BostadzPortalenWebAPI.Data.Interface;

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
        private readonly IPropertyImageRepository imageRepo;

        public PropertyForSaleController(IPropertyForSaleRepository propertyForSaleRepository, IMapper mapper, ApplicationDbContext context, IPropertyImageRepository imageRepo)
        {
            _propertyForSaleRepository = propertyForSaleRepository;
            this.mapper = mapper;
            _context = context;
            this.imageRepo = imageRepo;
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
        //Author: Johan Nelin
        [HttpGet("GetAllPropertyOverviewDTOAsync")]
        public async Task<ActionResult<List<PropertyForSaleOverviewDTO>>> GetAllPropertyOverviewDTOAsync()
        {
            var properties = await _propertyForSaleRepository.GetAllWithIncludesAsync();
            if (properties == null || !properties.Any())
            {
                return NotFound();
            }
            var allDTOs = new List<PropertyForSaleOverviewDTO>();
            foreach (var property in properties)
            {
                allDTOs.Add(mapper.Map<PropertyForSaleOverviewDTO>(property));
            }

            return Ok(allDTOs);
        }
        [HttpGet("GetPropertyByIdDetailsDTOAsync/{id}")]
        public async Task<ActionResult<PropertyForSaleDetailsDTO>> GetPropertyByIdDetailsDTOAsync(int id)
        {
            var property = await _propertyForSaleRepository.GetByIDIncludesAsync(id);
            if (property == null)
            {
                return NotFound();
            }
            var dto = mapper.Map<PropertyForSaleDetailsDTO>(property);
            return Ok(dto);
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
        public async Task<ActionResult> UpdateProperty(int id, [FromBody] PropertyForSaleUpdateDto updatedPropertyForSale)
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
         
            mapper.Map(updatedPropertyForSale, existingProperty);
             
            await _propertyForSaleRepository.UpdateAsync(existingProperty);
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
        // author: Oscar
        [HttpPost("search")]
        public async Task<ActionResult<List<PropertyForSale>>> SearchProperties([FromBody] PropertySearchRequest searchRequest)
        {
            var query = _propertyForSaleRepository.QueryPropertiesWithIncludes();


            if (searchRequest.TypeOfProperty.HasValue && searchRequest.TypeOfProperty != 4)
            {
                    var propertyTypeEnum = (TypeOfPropertyEnum)searchRequest.TypeOfProperty.Value;
                    query = query.Where(p => p.TypeOfProperty == propertyTypeEnum);
              
            }

            if (searchRequest.MinPrice.HasValue)
            {
                query = query.Where(p => p.AskingPrice >= searchRequest.MinPrice.Value);
            }

            if (!string.IsNullOrWhiteSpace(searchRequest.MunicipalityName) && searchRequest.MunicipalityName != "Alla")
            {
                query = query.Where(p => p.Municipality.Name.Contains(searchRequest.MunicipalityName));
            }


            try
            {
                var properties = await query.ToListAsync();
                return Ok(properties);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                throw;
            }


        }


        // Author: Ledion 
        [HttpGet("GetMyListings")]
        [Authorize(Roles = "Realtor")]
        public async Task<ActionResult<List<PropertyForSaleOverviewDTO>>> GetMyListings()
        {
            var userId = User.FindFirst("uid")?.Value;
            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized("Ingen användar-ID hittades i token.");
            }

            var myProperties = await _propertyForSaleRepository.GetByRealtorAsync(userId);
            var myPropertiesDto = new List<PropertyForSaleOverviewDTO>();
            foreach(var property in myProperties)
            {
                var dto = mapper.Map<PropertyForSaleOverviewDTO>(property);
                myPropertiesDto.Add(dto); 
            }


            //var myProperties = await _propertyForSaleRepository
            //    .QueryPropertiesWithIncludes()
            //    .Where(p => p.RealtorId == userId)
            //    .Select(p => new PropertyForSaleOverviewDTO
            //    {
            //        PropertyForSaleId = p.PropertyForSaleId,
                    
            //        Address = p.Address,
            //        MunicipalityName = p.Municipality.Name,
            //        AskingPrice = p.AskingPrice,
            //        LivingArea = p.LivingArea,
            //        SupplementaryArea = p.SupplementaryArea,
            //        PlotArea = p.PlotArea,
            //        Description = p.Description,
            //        NumberOfRooms = p.NumberOfRooms,
            //        MonthlyFee = p.MonthlyFee,
            //        YearlyOperatingCost = p.YearlyOperatingCost,
            //        YearBuilt = p.YearBuilt,
            //        ImageUrls = p.ImageUrls, // Lägg in riktiga bilder om du har det
            //        TypeOfProperty = p.TypeOfProperty
            //    }).ToListAsync();

            

            return Ok(myPropertiesDto);
        }

        [HttpDelete("DeletePicture")]
        [Authorize(Roles ="Realtor, Admin")]
        public async Task DeletePictureAsync(int id)
        {
            
            await imageRepo.DeleteAsync(await imageRepo.GetPicture(id));
        }

        [HttpPut("UnlinkPicture/{id}")]
        public async Task<IActionResult> UnlinkImageFromProperty(int id)
        {
            var image = await _context.PropertyImages.FindAsync(id);
            if (image == null)
            {
                return NotFound();
            }


            image.PropertyForSaleId = null;
            await _context.SaveChangesAsync();

            return NoContent();
        }




    }
}
