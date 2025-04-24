using Blazored.LocalStorage;
using BostadzPortalenClient.Services.Base;
using BostadzPortalenClient.Models;


namespace BostadzPortalenClient.Services.Base
{
    public class RealtorService : BaseHttpService, IRealtorService
    {
        private readonly IClient client;
        public RealtorService(ILocalStorageService localStorage, IClient client) : base(localStorage, client)
        {
            this.client = client;
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
    }
}
