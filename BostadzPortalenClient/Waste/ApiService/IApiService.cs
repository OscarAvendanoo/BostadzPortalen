namespace BostadzPortalenClient.Waste.ApiService
{
    public interface IApiService
    {
        Task<T> Get<T>(string endpoint);
        Task<T> Put<T>(string endpoint, object payload);
        Task<T> Post<T>(string endpoint, object payload);
        Task<bool> Delete(string endpoint);
    }
}