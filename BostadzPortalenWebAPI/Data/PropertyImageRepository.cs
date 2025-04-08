using BostadzPortalenWebAPI.Models;
using BostadzPortalenWebAPI.Data;

namespace BostadzPortalenWebAPI.Data
{
    // Author: Jona
    public class PropertyImageRepository : GenericRepository<PropertyImage>, IPropertyImageRepository
    {
        public PropertyImageRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
