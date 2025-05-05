
using Blazored.LocalStorage;

using BostadzPortalenClient.Models;
using Newtonsoft.Json;

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BostadzPortalenClient.Services.Base
{
    // Author: Oscar 
    public class SearchResultService : BaseHttpService, ISearchResultService
    {
        private readonly IClient client;
       
        public List<PropertyForSale> Results { get; set; } = new();
        public SearchResultService(ILocalStorageService localStorage, IClient client, IApiService apiService) : base(localStorage, client)
        {
            this.client = client;
        }
        public async Task<Response<List<PropertyForSale>>> SearchProperties(PropertySearchRequest propertySearchRequest)
        {
            var response = new Response<List<PropertyForSale>>();

            try
            {
                var data = await client.SearchAsync(propertySearchRequest);

                if (data != null && data.Any())
                {
                    
                    response.Data = data.ToList();
                    response.Success = true;
                    Results = response.Data;
                }
                else
                {
                    response.Success = false;
                    response.Message = "No properties found.";
                }
            }
            catch (ApiException ex)
            {
                Console.WriteLine(ex.Message);
                response = ConvertApiExceptions<List<PropertyForSale>>(ex);
            }

            
            return response;
        }

            public async Task<List<PropertyForSale>> GetSearchResults()
            {
                return Results;
            }
    }
}
