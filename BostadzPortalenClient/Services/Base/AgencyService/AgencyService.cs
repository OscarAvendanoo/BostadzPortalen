
namespace BostadzPortalenClient.Services.Base.AgencyService
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
