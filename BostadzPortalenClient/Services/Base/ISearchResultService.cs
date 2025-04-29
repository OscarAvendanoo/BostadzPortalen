using BostadzPortalenClient.Models;

namespace BostadzPortalenClient.Services.Base
{
    public interface ISearchResultService
    {
        Task<Response<List<PropertyForSale>>> SearchProperties(PropertySearchRequest propertySearchRequest);
        Task<List<PropertyForSale>> GetSearchResults();
    }
}
