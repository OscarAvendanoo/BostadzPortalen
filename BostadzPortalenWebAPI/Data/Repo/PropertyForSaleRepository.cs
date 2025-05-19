using AutoMapper;
using BostadzPortalenWebAPI.Data.Interface;
using BostadzPortalenWebAPI.DTO;
using BostadzPortalenWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Net;

namespace BostadzPortalenWebAPI.Data.Repo
{
    //Author: Oscar och Jonathan

    public class PropertyForSaleRepository : GenericRepository<PropertyForSale>, IPropertyForSaleRepository
    {

        private readonly ApplicationDbContext _context;
        public PropertyForSaleRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }


        // Hämtar alla försäljningsobjekt med full include till en lista
        public async Task<List<PropertyForSale>> GetAllWithIncludesAsync()
        {
            return await _context.PropertiesForSale
                .Include(p => p.Realtor)
                    .ThenInclude(r => r.Agency)
                .Include(p => p.Municipality)
                .Include(p => p.ImageUrls)
                .ToListAsync();
        }
        // Hämtar ett försäljningsobjekt med hjälp av ID med full include
        public async Task<PropertyForSale?> GetByIDIncludesAsync(int id)
        {

            return await _context.PropertiesForSale
                .Include(p => p.Realtor)
                    .ThenInclude(r => r.Agency)
                .Include(p => p.Municipality)
                .Include(p => p.ImageUrls)
                .FirstOrDefaultAsync(p => p.PropertyForSaleId == id);


        }
        // Hämtar försäljningsobjekt baserat på MäklarId
        public async Task<List<PropertyForSale>> GetByRealtorAsync(string realtorId)
        {
            return await _context.PropertiesForSale
                .Where(p => p.RealtorId == realtorId)
                .Include(p => p.Realtor)
                    .ThenInclude(r => r.Agency)
                .Include(p => p.Municipality)
                .Include(p => p.ImageUrls)
                .ToListAsync();
        }

        // Hämtar alla försäljnings objekt i en viss kommun

        public async Task<List<PropertyForSale>> GetByMunicipalityAsync(int municipalityId)
        {
            return await _context.PropertiesForSale
                .Where(p => p.MunicipalityId == municipalityId)
                .Include(p => p.Realtor)
                .ToListAsync();
        }

        // Hämtar alla försäljningsobjekt efter en viss kategori
        public async Task<List<PropertyForSale>> GetByCategoryAsync(TypeOfPropertyEnum category)
        {
            return await _context.PropertiesForSale
                .Where(p => p.TypeOfProperty == category)
                .Include(p => p.Realtor)
                    .ThenInclude(r => r.Agency)
                .Include(p => p.Municipality)
                .ToListAsync();
        }

        public IQueryable<PropertyForSale> QueryPropertiesWithIncludes()
        {
            return _context.PropertiesForSale
                .Include(p => p.Municipality)
                .Include(p => p.Realtor)
                .ThenInclude(r => r.Agency)
                .Include(p => p.ImageUrls);
        }
    }
}
