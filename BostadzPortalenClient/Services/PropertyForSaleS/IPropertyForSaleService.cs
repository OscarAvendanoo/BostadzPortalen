using BostadzPortalenClient.Services.Base;
//Author: Johan Nelin

namespace BostadzPortalenClient.Services.PropertyForSaleS
{
    public interface IPropertyForSaleService
    {
        public Task<ICollection<PropertyForSale>> GetAllPropertiesForSaleAsync();
        public Task DeletePropertyForSale(int id);

    }
}
