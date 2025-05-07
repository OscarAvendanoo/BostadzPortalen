using BostadzPortalenWebAPI.Data.Interface;
using BostadzPortalenWebAPI.DTO;
using BostadzPortalenWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BostadzPortalenWebAPI.Data.Repo
{
    //Author: Kevin
    public class RealtorRepository : GenericRepository<Realtor>, IRealtorRepository
    {
        private readonly ApplicationDbContext context;

        public RealtorRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<List<Realtor>> GetAllWithIncludesAsync()
        {
            return await context.Realtors
                .Include(r => r.Agency)
                .Include(r => r.Properties)
                .ToListAsync();
        }

        //public async Task<Realtor> GetByIdIncludesAsync(int id)
        //{
        //    return await context.Realtors
        //        .Include(r => r.Agency)
        //        .Include(r => r.Properties)
        //        .Where(r => r.RealtorId == id).FirstOrDefaultAsync();

        //}

        public async Task<Realtor> GetByNameIncludesAsync(string firstName, string lastName)
        {
            return await context.Realtors
                .Include(r => r.Agency)
                .Include(r => r.Properties)
                    .ThenInclude(r => r.Municipality)
                        .ThenInclude(r => r.PropertiesForSale)
                .Where(r => r.FirstName == firstName || r.LastName == lastName).FirstOrDefaultAsync();
        }

        public async Task<Realtor> GetRealtorByGuidAsync(string guidID)
        {
            return await context.Realtors
                .Include(r => r.Agency)
                .Include(r => r.Properties)
                    .ThenInclude(p => p.Municipality)
                .FirstOrDefaultAsync(r => r.Id == guidID);
        }

        public async Task<List<PropertyForSaleOverviewDTO>> GetOverviewDTOByRealtorIdAsync(string guidID)
        {
            var realtor = await GetRealtorByGuidAsync(guidID);
            var overviewDTOs = new List<PropertyForSaleOverviewDTO>();
            foreach (var property in realtor.Properties)
            {
                overviewDTOs.Add(new PropertyForSaleOverviewDTO()
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
            return overviewDTOs;
        }


        //public async Task<IEnumerable<PropertyForSale>> GetListedPropertiesAsync(int id) //osäker på string på id eller hur vi ska gå tillväga??
        //{
        //    return await context.Realtors
        //        .Include(r => r.Agency)
        //        .Include(r => r.Properties)
        //        .Where(r => r.FirstName == firstName || r.LastName == lastName).FirstOrDefaultAsync();
        //}

        //public async Task AddPropertyForSale(PropertyForSale propertyForSale)
        //{
        //    await context.PropertiesForSale.AddAsync(propertyForSale);
        //    await context.SaveChangesAsync();
        //}

        //public async Task<PropertyForSale> EditPropertyForSale(PropertyForSale propertyForSale)
        //{
        //    context.PropertiesForSale.Update(propertyForSale);
        //    context.SaveChanges();
        //    return propertyForSale;
        //}
        //public async Task<IEnumerable<PropertyForSale>> GetListedPropertiesAsync(string id) //osäker på string på id eller hur vi ska gå tillväga??
        //{
        //    var properties = await context.PropertiesForSale.Where(pfs => pfs.RealtorId == id)
        //        .Include(r=>r.Realtor)
        //        .ToListAsync();
        //    return properties;
        //}


    }
}
