using Blazored.LocalStorage;
using BostadzPortalenClient.Services.Authentication;
using BostadzPortalenClient.Services.Base;
using BostadzPortalenClient.Services.R_EstateSrvc;
using BostadzPortalenClient.Providers;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BostadzPortalenClient.Services.MunicipalitySrvc;
using BostadzPortalenClient.Services.AgencyService;
using BostadzPortalenClient.Services.RealtorSrvc;
using BostadzPortalenClient.Services.SearchSrvc;

namespace BostadzPortalenClient
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7291/") });

            builder.Services.AddAutoMapper(typeof(Program));
            builder.Services.AddBlazorBootstrap(); //JN: to make the slideshow work
            builder.Services.AddBlazoredLocalStorage();

            builder.Services.AddScoped<ApiAuthenticationStateProvider>();
            builder.Services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();

            builder.Services.AddAuthorizationCore();
            builder.Services.AddScoped<IClient, Client>();
            builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
            builder.Services.AddScoped<IMuniService, MuniService>();
            builder.Services.AddScoped<IRealtorService, RealtorService>();
            builder.Services.AddScoped<ISearchResultService, SearchResultService>();
            builder.Services.AddScoped<IPropertyForSaleService, PropertyForSaleService>();
            builder.Services.AddScoped<IAgencyService, AgencyService>();

            await builder.Build().RunAsync();
        }
    }
}
