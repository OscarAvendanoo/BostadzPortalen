using BostadzPortalenWebAPI.DTO;
using BostadzPortalenWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
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
                    //ImageUrls = property.ImageUrls.Select(img => img.ImageUrl).ToList(),
                    TypeOfProperty = property.TypeOfProperty,
                });
            }
            return allDTOs;
        }
        public async Task<PropertyForSaleDetailsDTO> GetPropertyByIdDTOAsync(int id)
        {
            var model = await GetByIDIncludesAsync(id); //doesn't give the agency, despite ThenInclude
            //added method to grab the agency of the realtor for the DTO
            var model2 = await _context.Realtors 
                .Include(r=>r.Agency)
                .Where(r=>r.Id == model.RealtorId)
                .FirstOrDefaultAsync();
            var dto = new PropertyForSaleDetailsDTO()
            {
                PropertyForSaleId = model.PropertyForSaleId,
                Address = model.Address,
                MunicipalityName = model.Municipality.Name,
                AskingPrice = model.AskingPrice,
                LivingArea = model.LivingArea,
                SupplementaryArea = model.SupplementaryArea,
                PlotArea = model.PlotArea,
                Description = model.Description,
                NumberOfRooms = model.NumberOfRooms,
                MonthlyFee = model.MonthlyFee,
                YearlyOperatingCost = model.YearlyOperatingCost,
                YearBuilt = model.YearBuilt,
                ImageUrls = model.ImageUrls,
                TypeOfProperty = model.TypeOfProperty,
                RealEstateAgency = model2.Agency,
                Realtor = model.Realtor,
            };
            return dto;
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

        public IQueryable<PropertyForSale> QueryPropertiesWithIncludes()
        {
            return _context.PropertiesForSale
                .Include(p => p.Municipality)
                .Include(p => p.Realtor)
                .Include(p => p.ImageUrls);
        }
    }
}
