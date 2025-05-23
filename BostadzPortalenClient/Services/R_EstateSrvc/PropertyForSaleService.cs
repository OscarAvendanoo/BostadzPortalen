﻿using AutoMapper;
using Blazored.LocalStorage;
using BostadzPortalenClient.Services.Base;
//Author: Johan Nelin

namespace BostadzPortalenClient.Services.R_EstateSrvc
{
    public class PropertyForSaleService: BaseHttpService, IPropertyForSaleService
    {
        private readonly IClient httpClient;
        private readonly IMapper mapper;
               
        public PropertyForSaleService(IClient httpClient, IMapper mapper, ILocalStorageService localStorage) : base(localStorage, httpClient)
        {
            this.httpClient = httpClient;
            this.mapper = mapper;
        }

        public async Task<List<PropertyForSaleOverviewDTO>> GetAllPropertiesForSaleDTOAsync()
        {
            var tests = await httpClient.GetAllPropertyOverviewDTOAsync();
            return tests.ToList();
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
            await httpClient.PropertyForSalePUTAsync(propertyId, property);
        }

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
            };

            await this.httpClient.PropertyForSalePOSTAsync(dto);

            return true;
        }

        //Author: Kevin
        public async Task<IEnumerable<PropertyForSale>> GetPropertiesByRealtor(string id)
        {            
            var properties = await httpClient.GetAllPropertiesIncludeAllAsync();
            var myProps = properties.Where(p => p.RealtorId == id).ToList();
            
            return myProps;
        }
        public async Task<List<PropertyForSaleOverviewDTO>> GetMyListingsAsync()
        {
            await GetBearerToken();
            var result = await httpClient.GetMyListingsAsync();
            return result.ToList(); 
        }

        //Author: Kevin
        public async Task UnlinkPicture(int id)
        {
            await httpClient.UnlinkPictureAsync(id);
        }
    }
}
