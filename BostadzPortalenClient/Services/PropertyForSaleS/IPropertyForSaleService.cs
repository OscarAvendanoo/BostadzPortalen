using BostadzPortalenClient.Services.Base;


namespace BostadzPortalenClient.Services.PropertyForSaleS
{
    public interface IPropertyForSaleService
    {
        public Task<IEnumerable<PropertyForSale>> GetAllPropertiesForSaleAsync();
        public Task DeletePropertyForSale(int id);


        public Task<PropertyForSale> GetPropertyAsync(int id);
        public Task UpdatePropertyAsync(int propertyId, PropertyForSale property);


        Task<bool> AddPropertyForSaleAsync(CreatePropertyForSaleDTO dto);

       



    }
}
