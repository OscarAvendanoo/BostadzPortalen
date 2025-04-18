
using Blazored.LocalStorage;
using BostadzPortalenClient.Services.Base;
using BostadzPortalenTestApp.Providers;
using Microsoft.AspNetCore.Components.Authorization;



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
            var response = await httpClient.LoginAsync(realtorDto);

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
