using BostadzPortalenClient.Services.Base;


namespace BostadzPortalenClient.Services.PropertyForSaleS
{
    public interface IPropertyForSaleService
    {
        Task<IEnumerable<PropertyForSale>> GetAllPropertiesForSaleAsync();
        Task<PropertyForSale> GetPropertyIncludeAllAsync(int id);
        Task DeletePropertyForSale(int id);


        Task<PropertyForSale> GetPropertyAsync(int id);
        Task UpdatePropertyAsync(int propertyId, PropertyForSale property);


        Task<bool> AddPropertyForSaleAsync(CreatePropertyForSaleDTO dto);

       



    }
}
