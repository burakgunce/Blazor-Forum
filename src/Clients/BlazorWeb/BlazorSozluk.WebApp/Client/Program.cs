using BlazorSozluk.WebApp;
using BlazorSozluk.WebApp.Infrastructure.Services.Interfaces;
using BlazorSozluk.WebApp.Infrastructure.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.Components.Authorization;
using BlazorSozluk.WebApp.Auth;
using Blazored.LocalStorage;

namespace BlazorSozluk.WebApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddHttpClient("WebApiClient", client =>
            {
                client.BaseAddress = new Uri("http://localhost:PORT");
            })
                .AddHttpMessageHandler<AuthTokenHandler>();

            builder.Services.AddScoped(sp =>
            {
                var clientFactory = sp.GetRequiredService<IHttpClientFactory>();
                return clientFactory.CreateClient("WebApiClient");
            });

            builder.Services.AddScoped<AuthTokenHandler>();

            builder.Services.AddTransient<IEntryService, EntryService>();
            builder.Services.AddTransient<IVoteService, VoteService>();
            builder.Services.AddTransient<IFavService, FavService>();
            builder.Services.AddTransient<IUserService, UserService>();
            builder.Services.AddTransient<IIdentityService, IdentityService>();

            builder.Services.AddScoped<AuthenticationStateProvider, AuthStateProvider>();

            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddBlazoredLocalStorage();
            
            builder.Services.AddAuthorizationCore();

            await builder.Build().RunAsync();
        }
    }
}