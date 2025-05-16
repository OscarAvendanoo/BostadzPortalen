using BostadzPortalenClient.Services.Base;



namespace BostadzPortalenClient.Services.R_EstateSrvc
{
    public interface IPropertyForSaleService
    {
        Task<List<PropertyForSaleOverviewDTO>> GetAllPropertiesForSaleDTOAsync();
        Task<PropertyForSaleDetailsDTO> GetPropertyDetailsDTOByIdAsync(int id);
        Task DeletePropertyForSale(int id);
        Task<List<PropertyForSaleOverviewDTO>> GetMyListingsAsync();
        Task<PropertyForSale> GetPropertyAsync(int id);
        Task UpdatePropertyAsync(int propertyId, PropertyForSaleUpdateDto property);
        Task<bool> AddPropertyForSaleAsync(CreatePropertyForSaleDTO dto);
        Task<IEnumerable<PropertyForSale>> GetPropertiesByRealtor(string id);
        Task UnlinkPicture(int id);
    }
}
