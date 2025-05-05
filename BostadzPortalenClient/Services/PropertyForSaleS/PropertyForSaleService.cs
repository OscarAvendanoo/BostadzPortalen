using AutoMapper;
using Blazored.LocalStorage;
using BostadzPortalenClient.Services.Base;
using Microsoft.AspNetCore.Components.Authorization;
//Author: Johan Nelin

namespace BostadzPortalenClient.Services.PropertyForSaleS
{
    public class PropertyForSaleService: BaseHttpService, IPropertyForSaleService
    {
        private readonly IClient httpClient;
        private readonly IMapper mapper;

        

        public PropertyForSaleService(IClient httpClient, ApiService apiService, IMapper mapper, ILocalStorageService localStorage) : base(localStorage, httpClient)
        {
            this.httpClient = httpClient;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<PropertyForSaleOverviewDTO>> GetAllPropertiesForSaleDTOAsync()
        {
            var tests = await httpClient.GetAllPropertyOverviewDTOAsync();
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

        public async Task<PropertyForSaleDetailsDTO> GetPropertyDetailsDTOByIdAsync(int id)
        {

            var property = await httpClient.GetPropertyByIdDetailsDTOAsync(id);
            return property;
        }


        public async Task<PropertyForSale> GetPropertyAsync(int id)
        {
            var properties = await httpClient.GetAllPropertiesIncludeAllAsync();
            var property = properties.Where(p => p.PropertyForSaleId == id).FirstOrDefault();
            return property;
        }

        public async Task UpdatePropertyAsync(int propertyId, PropertyForSaleUpdateDto property)
        {
            //var proptosend = mapper.Map<PropertyForSale>(property);
            await httpClient.PropertyForSalePUTAsync(propertyId, property);
        }

        //public async Task<bool> AddPropertyForSaleAsync(CreatePropertyForSaleDTO dto)
        //{
        //    await httpClient.PropertyForSalePOSTAsync(dto);
        //    return true;
        //}
        public async Task<bool> AddPropertyForSaleAsync(CreatePropertyForSaleDTO dto)
        {
            await GetBearerToken();

            var propertyForSale = new PropertyForSale
            {
                Address = dto.Address,
                MunicipalityId = dto.MunicipalityId,
                AskingPrice = (double)dto.AskingPrice,
                LivingArea = dto.LivingArea,

                SupplementaryArea = dto.SupplementaryArea ?? 0,
                PlotArea = dto.PlotArea,
                Description = dto.Description,
                NumberOfRooms = dto.NumberOfRooms,
                MonthlyFee = (double)dto.MonthlyFee,
                YearlyOperatingCost = (double)dto.YearlyOperatingCost,
                YearBuilt = dto.YearBuilt,
                TypeOfProperty = dto.TypeOfProperty,
                //ImageUrls = dto.ImageUrls behöver ändras

            };

            // JN: Removed ApiService usage -> Don't know if it works (but this way we can comment-out ApiService entirely)
            await this.httpClient.PropertyForSalePOSTAsync(dto);
            return true;
        }

        //TEST KEVIN

        public async Task<IEnumerable<PropertyForSale>> GetPropertiesByRealtor(string id)
        {
            
            
            var properties = await httpClient.GetAllPropertiesIncludeAllAsync();
            var myProps = properties.Where(p => p.RealtorId == id).ToList();
            
            return myProps;
        }
        public async Task<IEnumerable<PropertyForSaleOverviewDTO>> GetMyListingsAsync()
        {
            return await httpClient.GetMyListingsAsync();
        }

    }
}
