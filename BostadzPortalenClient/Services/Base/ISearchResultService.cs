namespace BostadzPortalenClient.Services.Base
{
    public interface ISearchResultService
    {
       Task SearchProperties(PropertySearchRequest propertySearchRequest);
    }
}
