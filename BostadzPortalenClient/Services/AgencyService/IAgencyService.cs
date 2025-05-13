using BostadzPortalenClient.Services.Base;

namespace BostadzPortalenClient.Services.AgencyService
{
    //Author: Kevin
    public interface IAgencyService
    {
        public Task<IEnumerable<RealEstateAgency>> GetAllAgenciesAsync();
    }
}
