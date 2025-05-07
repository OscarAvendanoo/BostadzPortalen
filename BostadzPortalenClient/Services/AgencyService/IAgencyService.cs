using BostadzPortalenClient.Services.Base;

namespace BostadzPortalenClient.Services.AgencyService
{
    public interface IAgencyService
    {
        public Task<IEnumerable<RealEstateAgency>> GetAllAgenciesAsync();
    }
}
