using Blazored.LocalStorage;
using BostadzPortalenClient.Services.Base;
using Microsoft.AspNetCore.Components.Authorization;

namespace BostadzPortalenClient.Services.PropertyForSaleS
{
    public class PropertyForSaleService: IPropertyForSaleService
    {
        private readonly IClient httpClient;

        public PropertyForSaleService(IClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<ICollection<PropertyForSale>> GetAllPropertiesForSaleAsync()
        {
            var tests = await httpClient.PropertyForSaleAllAsync();
            return tests;
        }
    }
}
