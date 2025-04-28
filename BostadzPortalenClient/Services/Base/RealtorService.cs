using Blazored.LocalStorage;
using BostadzPortalenClient.Services.Base;
using BostadzPortalenClient.Models;


namespace BostadzPortalenClient.Services.Base
{
    public class RealtorService : BaseHttpService, IRealtorService
    {
        private readonly IClient client;
        private readonly IApiService apiService;

        public RealtorService(ILocalStorageService localStorage, IClient client, IApiService apiService) : base(localStorage, client)
        {
            this.client = client;
            this.apiService = apiService;
        }
        // author: Oscar
        public async Task<Response<Realtor>> GetCurrentRealtor()
        {
            Response<Realtor> response;

            try
            {
                await GetBearerToken();
                var data = await client.MeAsync();
                response = new Response<Realtor>
                {
                    Data = data,
                    Success = true
                };
            }
            catch (ApiException ex)
            {
                response = ConvertApiExceptions<Realtor>(ex);
            }
            return response;
        }

        public async Task<Realtor> FindRealtor(string firstName, string lastName)
        {
            var realtor = await apiService.Get<Realtor>($"realtor/FindRealtorByName/{firstName}{lastName}");
            return realtor;
            
        }
    }
}
