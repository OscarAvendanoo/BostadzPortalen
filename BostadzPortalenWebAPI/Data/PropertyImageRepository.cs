using BostadzPortalenWebAPI.Models;
using BostadzPortalenWebAPI.Data;
using Microsoft.AspNetCore.Mvc;

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

        public async Task<PropertyImage> GetPicture(int id)
        {
            return _context.PropertyImages.Where(im => im.Id == id).FirstOrDefault() ?? new PropertyImage();
        }

        

    }
}
