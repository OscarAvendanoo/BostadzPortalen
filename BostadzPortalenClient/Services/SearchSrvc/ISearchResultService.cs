using BostadzPortalenClient.Models;
using BostadzPortalenClient.Services.Base;

namespace BostadzPortalenClient.Services.SearchSrvc
{

    // Author Oscar
    public interface ISearchResultService
    {
        Task<Response<List<PropertyForSale>>> SearchProperties(PropertySearchRequest propertySearchRequest);
        Task<List<PropertyForSale>> GetSearchResults();
    }
}
