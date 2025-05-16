using BostadzPortalenClient.Services.Base;

namespace BostadzPortalenClient.Services.Authentication
{
    //Author: ALL
    public interface IAuthenticationService 
    {
        Task<bool> AuthenticateAsync(LoginRealtorDto realtorDto);
        public Task Logout();
    }
}
