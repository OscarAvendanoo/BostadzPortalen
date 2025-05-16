using Blazored.LocalStorage;
using BostadzPortalenClient.Models;

namespace BostadzPortalenClient.Services.Base
{
    // author: Oscar
    public class BaseHttpService
    {
        private readonly ILocalStorageService localStorage;
        private readonly IClient client;
        public BaseHttpService(ILocalStorageService localStorage, IClient client)
        {
            this.client = client;
            this.localStorage = localStorage;
        }
        // author: Oscar
        protected Response<Guid> ConvertApiExceptions<Guid>(ApiException apiException)
        {
            if (apiException.StatusCode == 400)
            {
                return new Response<Guid>() { Message = "Validation errors have occured.", ValidationErrors = apiException.Response, Success = false };
            }
            if (apiException.StatusCode == 404)
            {
                return new Response<Guid> { Message = "The requested item could not be found", Success = false };
            }
            return new Response<Guid>() { Message = "Something went wrong, please try again...", Success = false };
        }

      // author: Oscar
        public async Task GetBearerToken()
        {
            try
            {
                var token = await localStorage.GetItemAsync<string>("accessToken");               

                if (!string.IsNullOrWhiteSpace(token))
                {
                    client.HttpClient.DefaultRequestHeaders.Authorization =
                        new System.Net.Http.Headers.AuthenticationHeaderValue("bearer", token);
                    Console.WriteLine("Authorization header set.");
                }
                else
                {
                    Console.WriteLine("No token found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetBearerToken: {ex.Message}");
                throw;
            }

            Console.WriteLine("GetBearerToken END");
        }
    }   
}
