using BostadzPortalenClient.Services.Base;
using BostadzPortalenWebAPI.DTO;
using BostadzPortalenClient.DTO;

namespace BostadzPortalenClient.Services.PropertyForSaleS
{
    public interface IPropertyForSaleService
    {
        public Task<ICollection<PropertyForSale>> GetAllPropertiesForSaleAsync();

        Task<bool> AddPropertyForSaleAsync(CreatePropertyForSaleDTO dto);

       


    }
}
