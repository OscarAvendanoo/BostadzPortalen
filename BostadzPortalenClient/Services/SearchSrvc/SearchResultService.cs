﻿using Blazored.LocalStorage;
using BostadzPortalenClient.Models;
using BostadzPortalenClient.Services.Base;

namespace BostadzPortalenClient.Services.SearchSrvc
{
    // Author: Oscar 
    public class SearchResultService : BaseHttpService, ISearchResultService
    {
        private readonly IClient client;

        public List<PropertyForSaleOverviewDTO> Results { get; set; } = new();
        public SearchResultService(ILocalStorageService localStorage, IClient client) : base(localStorage, client)
        {
            this.client = client;
        }
        public async Task<Response<List<PropertyForSaleOverviewDTO>>> SearchProperties(PropertySearchRequest propertySearchRequest)
        {
            var response = new Response<List<PropertyForSaleOverviewDTO>>();

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
                response = ConvertApiExceptions<List<PropertyForSaleOverviewDTO>>(ex);
            }

            return response;
        }

        public async Task<List<PropertyForSaleOverviewDTO>> GetSearchResults()
        {
            return Results;
        }
    }
}
