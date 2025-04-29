using Blazored.LocalStorage;
using BostadzPortalenClient.Services.Base;
using BostadzPortalenClient.DTO;
using BostadzPortalenClient.DTO;
using Microsoft.AspNetCore.Components.Authorization;
//Author: Johan Nelin

namespace BostadzPortalenClient.Services.PropertyForSaleS
{
    public class PropertyForSaleService: IPropertyForSaleService
    {
        private readonly IClient httpClient;
        private readonly ApiService apiService;

        public PropertyForSaleService(IClient httpClient, ApiService apiService)
        {
            this.httpClient = httpClient;
            this.apiService = apiService; // Jona
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


        public async Task<PropertyForSale> GetPropertyAsync(int id)
        {
            var property = await httpClient.PropertyForSaleGETAsync(id);
            return property;
        }

        public async Task UpdatePropertyAsync(int propertyId, PropertyForSale property)
        {
            await httpClient.PropertyForSalePUTAsync(propertyId, property);
        }

        //public async Task<bool> AddPropertyForSaleAsync(CreatePropertyForSaleDTO dto)
        //{
        //    await httpClient.PropertyForSalePOSTAsync(dto);
        //    return true;
        //}
        public async Task<bool> AddPropertyForSaleAsync(CreatePropertyForSaleDTO dto)
        {
            
            var propertyForSale = new PropertyForSale
            {
                Address = dto.Address,
                MunicipalityId = dto.MunicipalityId,
                AskingPrice = (double)dto.AskingPrice,
                LivingArea = dto.LivingArea,
                SupplementaryArea = dto.SupplementaryArea,
                PlotArea = dto.PlotArea,
                Description = dto.Description,
                NumberOfRooms = dto.NumberOfRooms,
                MonthlyFee = (double?)dto.MonthlyFee,
                YearlyOperatingCost = (double)dto.YearlyOperatingCost,
                YearBuilt = dto.YearBuilt,
                TypeOfProperty = dto.TypeOfProperty,
                Images = dto.ImageUrls?.Select(url => new PropertyImage { ImageUrl = url }).ToList()
            };

            // Testar med apiService ist Jona
            //await this.apiService.Post<PropertyForSale>("api/propertyForSale", propertyForSale);
            await this.apiService.Post<CreatePropertyForSaleDTO>("api/propertyForSale", dto);
            return true;
        }



    }
}
