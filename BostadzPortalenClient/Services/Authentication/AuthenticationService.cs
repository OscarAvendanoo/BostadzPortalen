
using Blazored.LocalStorage;
using BostadzPortalenClient.Models;
using BostadzPortalenClient.Providers;
using BostadzPortalenClient.Services.Base;

using Microsoft.AspNetCore.Components.Authorization;
using Newtonsoft.Json;



namespace BostadzPortalenClient.Services.Authentication
{
    //Author: ALL
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IClient httpClient;
        private readonly ILocalStorageService localStorage;
        private readonly AuthenticationStateProvider authenticationStateProvider;

        public AuthenticationService(IClient httpClient, ILocalStorageService localStorage, AuthenticationStateProvider authenticationStateProvider)
        {
            this.httpClient = httpClient;
            this.localStorage = localStorage;
            this.authenticationStateProvider = authenticationStateProvider;
        }
        public async Task<bool> AuthenticateAsync(LoginRealtorDto realtorDto)
        {
            //try
            //{
            //    localStorage.SetItemAsync("testKey", "testValue");
            //    await localStorage.RemoveItemAsync("testKey");
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine($"Error med local Storage: {ex.Message}");
            //}
            var response = await httpClient.LoginAsync(realtorDto);

            //await localStorage.SetItemAsync("testKey", "testValue");
            //var retrievedValue = await localStorage.GetItemAsync<string>("testKey");
            //Console.WriteLine($"Läst värde: {retrievedValue}");

            //await localStorage.ClearAsync();

            await localStorage.SetItemAsync("accessToken", response.Token);

            await ((ApiAuthenticationStateProvider)authenticationStateProvider).LoggedIn();

            return true;
        }

        public Task Logout()
        {
            return ((ApiAuthenticationStateProvider)authenticationStateProvider).LoggedOut();
        }
    }
}
