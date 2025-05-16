using Microsoft.AspNetCore.Mvc;
using BostadzPortalenWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using BostadzPortalenWebAPI.Data;
using Microsoft.AspNetCore.Authorization;

namespace BostadzPortalenWebAPI.Controllers
{
    //Author Ledion
    [ApiController]
    [Route("api/[controller]")]
    public class MunicipalityController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MunicipalityController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/municipality
        [HttpGet("GetAllMuni")]
        public async Task<ActionResult<IEnumerable<Municipality>>> GetAllMunicipalitys()
        {
            return await _context.Municipalities.ToListAsync();
        }

        // GET: api/municipality/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Municipality>> GetMunicipalityById(int id)
        {
            var municipality = await _context.Municipalities.FindAsync(id);
            if (municipality == null) return NotFound();
            return municipality;
        }

        // POST: api/municipality
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<ActionResult<Municipality>> CreateMunicipality(Municipality municipality)
        {
            _context.Municipalities.Add(municipality);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetMunicipalityById), new { id = municipality.Id }, municipality);
        }

        // PUT: api/municipality/5
        [Authorize(Roles = "Administrator")]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMunicipality(int id, Municipality municipality)
        {
            if (id != municipality.Id) return BadRequest();
            _context.Entry(municipality).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/municipality/5
        [Authorize(Roles = "Administrator")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMunicipality(int id)
        {
            var municipality = await _context.Municipalities.FindAsync(id);
            if (municipality == null) return NotFound();

            _context.Municipalities.Remove(municipality);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
