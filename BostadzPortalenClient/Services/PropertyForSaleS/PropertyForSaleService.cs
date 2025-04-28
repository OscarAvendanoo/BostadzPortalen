using Blazored.LocalStorage;
using BostadzPortalenClient.Services.Base;
using Microsoft.AspNetCore.Components.Authorization;
//Author: Johan Nelin

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

        public async Task DeletePropertyForSale(int id)
        {
            try
            {
                await httpClient.PropertyForSaleDELETEAsync(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Gick inte att ta bort: {ex.Message}");
                throw;
            }
            
            
        }
    }
}
