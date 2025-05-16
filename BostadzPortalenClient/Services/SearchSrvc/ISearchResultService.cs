using BostadzPortalenClient.Models;
using BostadzPortalenClient.Services.Base;

namespace BostadzPortalenClient.Services.SearchSrvc
{
    // Author Oscar
    public interface ISearchResultService
    {
        Task<Response<List<PropertyForSaleOverviewDTO>>> SearchProperties(PropertySearchRequest propertySearchRequest);
        Task<List<PropertyForSaleOverviewDTO>> GetSearchResults();
    }
}
