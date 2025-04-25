using BostadzPortalenWebAPI.DTO;
using BostadzPortalenWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace BostadzPortalenWebAPI.Data
{
    //Author: Oscar och Jonathan

    public class PropertyForSaleRepository : GenericRepository<PropertyForSale>, IPropertyForSaleRepository
    {

        private readonly ApplicationDbContext _context;
        public PropertyForSaleRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<List<PropertyForSaleDTO>> GetAllPropertyDTO()
        {
            var allModels = await _context.PropertiesForSale.
                ToListAsync();
            var allDTOs = new List<PropertyForSaleDTO>();
            foreach (var property in allModels)
            {
                allDTOs.Add(new PropertyForSaleDTO()
                {
                    PropertyForSaleId = property.PropertyForSaleId,
                    Address = property.Address,
                    MunicipalityName = property.Municipality.Name,
                    AskingPrice = property.AskingPrice,
                    LivingArea = property.LivingArea,
                    SupplementaryArea = property.SupplementaryArea,
                    PlotArea = property.PlotArea,
                    Description = property.Description,
                    NumberOfRooms = property.NumberOfRooms,
                    MonthlyFee = property.MonthlyFee,
                    YearlyOperatingCost = property.YearlyOperatingCost,
                    YearBuilt = property.YearBuilt,
                    ImageUrls = property.ImageUrls,
                    RealtorId = property.RealtorId,
                    RealtorName = $"{property.Realtor.FirstName} + {property.Realtor.LastName}",
                    TypeOfProperty = property.TypeOfProperty,
                });
            }
            return allDTOs;
        }
        // Hämtar alla försäljningsobjekt med full include till en lista
        public async Task<List<PropertyForSale>> GetAllWithIncludesAsync()
        {
            return await _context.PropertiesForSale
                .Include(p => p.Realtor)
                    .ThenInclude(r => r.Agency)
                .Include(p => p.Municipality)
                //.Include(p => p.Images)
                .ToListAsync();
        }
        // Hämtar ett försäljningsobjekt med hjälp av ID med full include
        public async Task<PropertyForSale?> GetByIDIncludesAsync(int id)
        {

            return await _context.PropertiesForSale
                .Include(p => p.Realtor)
                    .ThenInclude(r => r.Agency)
                .Include(p => p.Municipality)
                //.Include(p => p.Images)
                .FirstOrDefaultAsync(p => p.PropertyForSaleId == id);


        }
        // Hämtar försäljningsobjekt baserat på MäklarId
        public async Task<List<PropertyForSale>> GetByRealtorAsync(string realtorId)
        {
            return await _context.PropertiesForSale
                .Where(p => p.RealtorId == realtorId)
                .Include(p => p.Municipality)
                //.Include(p => p.Images)
                .ToListAsync();
        }

        // Hämtar alla försäljnings objekt i en viss kommun

        public async Task<List<PropertyForSale>> GetByMunicipalityAsync(int municipalityId)
        {
            return await _context.PropertiesForSale
                .Where(p => p.MunicipalityId == municipalityId)
                //.Include(p => p.Images)
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
                //.Include(p => p.Images)
                .ToListAsync();
        }
    }
}
