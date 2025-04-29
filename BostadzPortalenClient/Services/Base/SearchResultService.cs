
using Blazored.LocalStorage;
using BostadzPortalenClient.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BostadzPortalenClient.Services.Base
{
    public class SearchResultService : BaseHttpService, ISearchResultService
    {
        private readonly IClient client;
       
        public List<PropertyForSale> Results { get; set; } = new();
        public SearchResultService(ILocalStorageService localStorage, IClient client, IApiService apiService) : base(localStorage, client)
        {
            this.client = client;
        }
        public async Task SearchProperties(PropertySearchRequest propertySearchRequest)
        {
            var data = await client.SearchAsync(propertySearchRequest);

            var response = new Response<List<PropertyForSale>>
            {
                Data = (List<PropertyForSale>)data,
                Success = true
            };
            if (response.Success)
            {
                // Handle successful search result
            }
          
        }
    }
}
