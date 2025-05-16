using BostadzPortalenWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using BostadzPortalenWebAPI.Data.Interface;

namespace BostadzPortalenWebAPI.Data.Repo
{
    // Author: Jona
    public class PropertyImageRepository : GenericRepository<PropertyImage>, IPropertyImageRepository
    {
        private readonly ApplicationDbContext _context;
        public PropertyImageRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<PropertyImage> GetPicture(int id)
        {
            return _context.PropertyImages.Where(im => im.Id == id).FirstOrDefault() ?? new PropertyImage();
        }
    }
}
