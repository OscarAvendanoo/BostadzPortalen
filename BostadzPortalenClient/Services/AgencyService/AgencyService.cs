using BostadzPortalenClient.Services.Base;

namespace BostadzPortalenClient.Services.AgencyService
{
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
    }
}
