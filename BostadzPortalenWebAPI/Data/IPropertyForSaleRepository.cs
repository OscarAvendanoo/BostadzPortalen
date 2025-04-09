using BostadzPortalenWebAPI.Models;

namespace BostadzPortalenWebAPI.Data
{
    public interface IPropertyForSaleRepository: IRepository<PropertyForSale>
    {
        Task<List<PropertyForSale>> GetAllWithIncludesAsync();
        Task<PropertyForSale?> GetByIDIncludesAsync(int id);
        Task<List<PropertyForSale>> GetByRealtorAsync(int realtorId);
        Task<List<PropertyForSale>> GetByMunicipalityAsync(int municipalityId);
        Task<List<PropertyForSale>> GetByCategoryAsync(TypeOfPropertyEnum category);
    }
}
