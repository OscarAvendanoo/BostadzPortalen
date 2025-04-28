using BostadzPortalenClient.Services.Base;

namespace BostadzPortalenClient.Services.PropertyForSaleS
{
    public interface IPropertyForSaleService
    {
        public Task<ICollection<PropertyForSale>> GetAllPropertiesForSaleAsync();
        public Task DeletePropertyForSale(int id);

    }
}
