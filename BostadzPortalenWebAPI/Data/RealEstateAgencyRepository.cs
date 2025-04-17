using BostadzPortalenWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BostadzPortalenWebAPI.Data
{
    //Author: Johan Nelin
    public class RealEstateAgencyRepository : GenericRepository<RealEstateAgency>, IRealEstateAgencyRepository
    {
        private readonly ApplicationDbContext _context;
        public RealEstateAgencyRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<RealEstateAgency> GetByIdFullIncludeAsync(int id)
        {
            var agency = await _context.RealEstateAgencies.
               Include(a => a.AgencyRealtors).
               ThenInclude(r => r.Properties).
               Where(a => a.RealEstateAgencyId == id).
               FirstOrDefaultAsync();
            return agency;
        }

        public async Task<List<PropertyForSale>> GetListOfPropertiesFromAgencyAsync(int id)
        {
            var agency = await GetByIdFullIncludeAsync(id);

            List<PropertyForSale> propertyList = new List<PropertyForSale>();
            foreach (var p in agency.AgencyRealtors)
            {
                foreach (var property in p.Properties)
                {
                    propertyList.Add(property);
                }
            }
            return propertyList;
        }
    }
}
