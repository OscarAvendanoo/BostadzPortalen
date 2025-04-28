using Newtonsoft.Json;
using System.Text;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;

namespace BostadzPortalenClient.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorage; // JA
        private readonly AuthenticationStateProvider _authenticationStateProvider; // JA

        public ApiService(HttpClient httpClient, ILocalStorageService localStorageService, AuthenticationStateProvider authenticationStateProvider)
        {
            _httpClient = httpClient;
            _localStorage = localStorageService; // JA
            _authenticationStateProvider = authenticationStateProvider; // JA
            //_httpClient.BaseAddress = new Uri("https://localhost:7291/api/");

        }
        // Jona
        private async Task AddBearerTokenAsync()
        {
            var token = await _localStorage.GetItemAsync<string>("accessToken");
            if (!string.IsNullOrWhiteSpace(token))
            {
                _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            }
        }
        public async Task<T> Get<T>(string endpoint)
        {

            var response = await _httpClient.GetAsync(endpoint);
            //Console.WriteLine($"Response status: {response.StatusCode}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(json);
        }

        public async Task<T> Put<T>(string endpoint, object payload)
        {
            var content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync(endpoint, content);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(json);
        }

        public async Task<T> Post<T>(string endpoint, object payload)
        {
            await AddBearerTokenAsync(); // JOna
            var content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(endpoint, content);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(json);
        }

        public async Task<bool> Delete(string endpoint)
        {

            var response = await _httpClient.DeleteAsync(endpoint);
            return response.IsSuccessStatusCode;
        }



    }
}
