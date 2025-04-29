using BostadzPortalenClient.Services.Base;
using BostadzPortalenWebAPI.DTO;
using BostadzPortalenClient.DTO;

namespace BostadzPortalenClient.Services.PropertyForSaleS
{
    public interface IPropertyForSaleService
    {
        public Task<ICollection<PropertyForSale>> GetAllPropertiesForSaleAsync();
        public Task DeletePropertyForSale(int id);


        public Task<PropertyForSale> GetPropertyAsync(int id);
        public Task UpdatePropertyAsync(int propertyId, PropertyForSale property);


        Task<bool> AddPropertyForSaleAsync(CreatePropertyForSaleDTO dto);

       



    }
}
