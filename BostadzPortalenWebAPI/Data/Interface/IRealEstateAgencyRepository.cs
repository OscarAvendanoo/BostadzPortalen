using BostadzPortalenWebAPI.Models;

namespace BostadzPortalenWebAPI.Data.Interface
{
    //Author: Johan Nelin
    public interface IRealEstateAgencyRepository : IRepository<RealEstateAgency>
    {
        Task<List<PropertyForSale>> GetListOfPropertiesFromAgencyAsync(int id);
        Task<RealEstateAgency> GetByIdFullIncludeAsync(int id);
    }
}
