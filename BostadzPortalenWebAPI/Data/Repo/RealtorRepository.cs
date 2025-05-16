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

        //Author: Kevin
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

        //Author: Kevin
        public async Task<Realtor> GetRealtorInfoDTO(string id)
        {           
            var realtor = await context.Realtors
            .Include(r => r.Agency)
            .Include(r => r.Properties)
            .ThenInclude(p => p.Municipality)
            .Include(r => r.Properties)
            .ThenInclude(p => p.ImageUrls)
            .Where(r => r.Id == id)
            .FirstOrDefaultAsync();

            return realtor;
        }
    }
}
