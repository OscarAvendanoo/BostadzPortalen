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

        //Author: Johan Nelin
        //Get All for DTO-overview (index)
        public async Task<List<PropertyForSaleOverviewDTO>> GetAllPropertyOverviewDTOAsync()
        {
            var allModels = await GetAllWithIncludesAsync();
            var allDTOs = new List<PropertyForSaleOverviewDTO>();
            foreach (var property in allModels)
            {
                allDTOs.Add(new PropertyForSaleOverviewDTO()
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
