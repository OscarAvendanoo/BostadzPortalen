using BostadzPortalenWebAPI.Models;
using FLashHackForum.Data;

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
