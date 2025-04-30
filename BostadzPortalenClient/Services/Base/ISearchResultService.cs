using BostadzPortalenClient.Models;

namespace BostadzPortalenClient.Services.Base
{

    // Author Oscar
    public interface ISearchResultService
    {
        Task<Response<List<PropertyForSale>>> SearchProperties(PropertySearchRequest propertySearchRequest);
        Task<List<PropertyForSale>> GetSearchResults();
    }
}
