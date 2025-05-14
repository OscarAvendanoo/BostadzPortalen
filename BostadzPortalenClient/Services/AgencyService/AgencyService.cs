using Blazored.LocalStorage;
using BostadzPortalenClient.Models;
using BostadzPortalenClient.Services.Base;

namespace BostadzPortalenClient.Services.AgencyService
{
    //Author: Kevin
    public class AgencyService : BaseHttpService, IAgencyService
    {
        private readonly IClient client;
        

        public AgencyService(ILocalStorageService localStorage, IClient client) : base(localStorage, client)
        {
            this.client = client;
        }
        // author: Oscar
        public async Task<bool> AddAgency(AgencyDTO agency)
        {
            try
            {
                await GetBearerToken();
                await client.CreateAgencyAsync(agency);
                return true;
            }
            catch (ApiException ex)
            {

                var response = ConvertApiExceptions<string>(ex);
                return false;
            }
        }

        public async Task<IEnumerable<RealEstateAgency>> GetAllAgenciesAsync()
        {
            var agencies = await client.RealEstateAgencyAllAsync();
            return agencies;
        }

        public async Task<RealEstateAgencyDetailsDTO> GetAgencyByIdAsync(int id)
        {
            var agency = await client.GetAgencyDetailsDTOAsync(id);
            return agency;
        }

        public async Task<IEnumerable<RealEstateAgencyDetailsDTO>> GetAllAgenciesIncludeAllAsync()
        {
            var agencies = await client.GetAllAgencyIncludeAllAsync();
            return agencies;
        }
    }
}
