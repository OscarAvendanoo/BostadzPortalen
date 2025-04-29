using Blazored.LocalStorage;
using BostadzPortalenClient.Models;

namespace BostadzPortalenClient.Services.Base
{
    public class MuniService : BaseHttpService, IMuniService
    {
        private readonly IClient client;
        public MuniService(ILocalStorageService localStorage, IClient client) : base(localStorage, client)
        {
            this.client = client;
        }
        // author: Oscar
        public async Task<Response<List<Municipality>>> GetAllMunicipalityToListAsync()
        {
            Response<List<Municipality>> response;

            try
            {
                //await GetBearerToken();
                var data = await client.GetAllMuniAsync();

                response = new Response<List<Municipality>>
                {
                    Data = (List<Municipality>)data,
                    Success = true
                };
            }
            catch (ApiException ex)
            {
                response = ConvertApiExceptions<List<Municipality>>(ex);
            }
            return response;
        }
    }
}
