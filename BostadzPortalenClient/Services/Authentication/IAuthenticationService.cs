using BostadzPortalenClient.Services.Base;
using BostadzPortalenTestApp.Providers;


namespace BostadzPortalenClient.Services.Authentication
{
    public interface IAuthenticationService 
    {
        Task<bool> AuthenticateAsync(LoginRealtorDto realtorDto);
        public Task Logout();
    }
}
