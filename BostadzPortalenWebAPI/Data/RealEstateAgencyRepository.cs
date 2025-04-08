using BostadzPortalenWebAPI.Models;

namespace BostadzPortalenWebAPI.Data
{
    //Author: Johan Nelin
    public class RealEstateAgencyRepository : GenericRepository<RealEstateAgency>, IRealEstateAgencyRepository
    {
        private readonly ApplicationDbContext _context;
        public RealEstateAgencyRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
