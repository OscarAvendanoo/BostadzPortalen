using BostadzPortalenWebAPI.DTO;
using BostadzPortalenWebAPI.Models;

namespace BostadzPortalenWebAPI.Data
{
    public interface IPropertyForSaleRepository: IRepository<PropertyForSale>
    {
        Task<List<PropertyForSale>> GetAllWithIncludesAsync();
        Task<List<PropertyForSaleDTO>> GetAllPropertyDTO();
        Task<PropertyForSale?> GetByIDIncludesAsync(int id);
        Task<List<PropertyForSale>> GetByRealtorAsync(string realtorId);
        Task<List<PropertyForSale>> GetByMunicipalityAsync(int municipalityId);
        Task<List<PropertyForSale>> GetByCategoryAsync(TypeOfPropertyEnum category);
    }
}
