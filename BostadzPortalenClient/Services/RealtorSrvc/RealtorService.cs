using Blazored.LocalStorage;
using BostadzPortalenClient.Models;
using BostadzPortalenClient.Services.Base;

namespace BostadzPortalenClient.Services.RealtorSrvc
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
                var data = await client.MeGETAsync();
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
            // Get DTO instead of Full-Realtor
            var realtor = await client.FindRealtorByNameAsync(firstName,lastName);
            return realtor;
        }

        public async  Task<RealtorInfoDTO> GetRealtorInfoDTO(string id)
        {
            var realtorInfo = await client.GetRealtorInfoAsync(id);
            return realtorInfo;
        }
        // Jona
        public async Task<bool> UpdateRealtorPartialAsync(RealtorUpdateDTO dto)
        {
            try
            {
                await GetBearerToken();
                await client.MePATCHAsync(dto); 
                return true;
            }
            catch (ApiException ex)
            {                
                var response = ConvertApiExceptions<string>(ex);
                return false;
            }
        }
    }
}
