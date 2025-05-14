using BostadzPortalenClient.Models;
using BostadzPortalenClient.Services.Base;

namespace BostadzPortalenClient.Services.AgencyService
{
    //Author: Kevin
    public interface IAgencyService
    {
        public Task<IEnumerable<RealEstateAgency>> GetAllAgenciesAsync();


        public Task<bool> AddAgency(AgencyDTO agency);

        public Task<RealEstateAgencyDetailsDTO> GetAgencyByIdAsync(int id);
        public Task<IEnumerable<RealEstateAgencyDetailsDTO>> GetAllAgenciesIncludeAllAsync();

    }
}
