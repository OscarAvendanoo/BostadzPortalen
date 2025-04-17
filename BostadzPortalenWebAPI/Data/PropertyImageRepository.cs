using BostadzPortalenWebAPI.Models;
using BostadzPortalenWebAPI.Data;

namespace BostadzPortalenWebAPI.Data
{
    // Author: Jona
    public class PropertyImageRepository : GenericRepository<PropertyImage>, IPropertyImageRepository
    {
        private readonly ApplicationDbContext _context;
        public PropertyImageRepository(ApplicationDbContext context) : base(context)
        {
            this._context = context;
        }
    }
}
