using BostadzPortalenClient.Services.Base;

namespace BostadzPortalenClient.Services.AgencyService
{
    //Author: Kevin
    public class AgencyService : IAgencyService
    {
        private readonly IClient client;

        public AgencyService(IClient client)
        {
            this.client = client;
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
    }
}
