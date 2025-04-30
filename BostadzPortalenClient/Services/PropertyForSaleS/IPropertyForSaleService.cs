using BostadzPortalenClient.Services.Base;



namespace BostadzPortalenClient.Services.PropertyForSaleS
{
    public interface IPropertyForSaleService
    {
        Task<IEnumerable<PropertyForSaleOverviewDTO>> GetAllPropertiesForSaleDTOAsync();
        Task<PropertyForSaleDetailsDTO> GetPropertyDetailsDTOByIdAsync(int id);
        Task DeletePropertyForSale(int id);


        Task<PropertyForSale> GetPropertyAsync(int id);
        Task UpdatePropertyAsync(int propertyId, PropertyForSale property);


        Task<bool> AddPropertyForSaleAsync(CreatePropertyForSaleDTO dto);

       



    }
}
