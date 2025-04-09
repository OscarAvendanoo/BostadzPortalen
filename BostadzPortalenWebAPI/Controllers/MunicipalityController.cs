using Microsoft.AspNetCore.Mvc;
using BostadzPortalenWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using BostadzPortalenWebAPI.Data;

namespace BostadzPortalenWebAPI.Controllers
{
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
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Municipality>>> GetAll()
        {
            return await _context.Municipalities.ToListAsync();
        }

        // GET: api/municipality/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Municipality>> GetById(int id)
        {
            var municipality = await _context.Municipalities.FindAsync(id);
            if (municipality == null) return NotFound();
            return municipality;
        }

        // POST: api/municipality
        [HttpPost]
        public async Task<ActionResult<Municipality>> Create(Municipality municipality)
        {
            _context.Municipalities.Add(municipality);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = municipality.Id }, municipality);
        }

        // PUT: api/municipality/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Municipality municipality)
        {
            if (id != municipality.Id) return BadRequest();
            _context.Entry(municipality).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/municipality/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var municipality = await _context.Municipalities.FindAsync(id);
            if (municipality == null) return NotFound();

            _context.Municipalities.Remove(municipality);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
