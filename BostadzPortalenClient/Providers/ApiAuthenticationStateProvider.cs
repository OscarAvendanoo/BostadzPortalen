using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace BostadzPortalenClient.Providers
{

    //Author: ALL
    public class ApiAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly ILocalStorageService localStorage;
        private readonly JwtSecurityTokenHandler jwtTokenHandler;

        public ApiAuthenticationStateProvider(ILocalStorageService localStorage)
        {
            this.localStorage = localStorage;
            jwtTokenHandler = new JwtSecurityTokenHandler();
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var user = new ClaimsPrincipal(new ClaimsIdentity());

            var savedToken = await localStorage.GetItemAsync<string>("accessToken");

            if(savedToken == null)
            {
                return new AuthenticationState(user);
            }

            var tokenContent = jwtTokenHandler.ReadJwtToken(savedToken);

            if(tokenContent.ValidTo < DateTime.UtcNow)
            {
                return new AuthenticationState(user);
            }

            var claims = await GetClaims();
            user = new ClaimsPrincipal(new ClaimsIdentity(claims, "jwt"));

            return new AuthenticationState(user);
        }

        public async Task LoggedIn()
        {
            var claims = await GetClaims();
            var user = new ClaimsPrincipal(new ClaimsIdentity(claims, "jwt"));
            var authState = Task.FromResult(new AuthenticationState(user));
            NotifyAuthenticationStateChanged(authState);

            Console.WriteLine("Användaren har loggats in");
        }

        public async Task LoggedOut()
        {
            await localStorage.RemoveItemAsync("accessToken");
            var nobody = new ClaimsPrincipal(new ClaimsIdentity());
            var authState = Task.FromResult(new AuthenticationState(nobody));
            NotifyAuthenticationStateChanged(authState);
        }

        public async Task<List<Claim>> GetClaims()
        {
            var savedToken = await localStorage.GetItemAsync<string>("accessToken");
            var tokenContent = jwtTokenHandler.ReadJwtToken(savedToken);
            var claims = tokenContent.Claims.ToList();
            claims.Add(new Claim(ClaimTypes.Name, tokenContent.Subject));
            return claims;
        }
    }
}
