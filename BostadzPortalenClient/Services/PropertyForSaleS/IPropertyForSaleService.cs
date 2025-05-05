using BostadzPortalenClient.Services.Base;



namespace BostadzPortalenClient.Services.PropertyForSaleS
{
    public interface IPropertyForSaleService
    {
        Task<IEnumerable<PropertyForSaleOverviewDTO>> GetAllPropertiesForSaleDTOAsync();
        Task<PropertyForSaleDetailsDTO> GetPropertyDetailsDTOByIdAsync(int id);
        Task DeletePropertyForSale(int id);
        Task<List<PropertyForSaleOverviewDTO>> GetMyListingsAsync();



        Task<PropertyForSale> GetPropertyAsync(int id);
        Task UpdatePropertyAsync(int propertyId, PropertyForSaleUpdateDto property);


        Task<bool> AddPropertyForSaleAsync(CreatePropertyForSaleDTO dto);

        Task<IEnumerable<PropertyForSale>> GetPropertiesByRealtor(string id);



    }
}
