using ApexCharts;
using Fintech_Blazor;
using FintechBlazor.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient 
{ 
    BaseAddress = new Uri("https://localhost:7280/") 
});

builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddHttpClient<IAwesomeApiService, AwesomeApiService>( client => 
{
    client.BaseAddress = new Uri("https://economia.awesomeapi.com.br/");
});

//MudBlazor
builder.Services.AddMudServices();

//Blazo-ApexCharts
builder.Services.AddApexCharts();

await builder.Build().RunAsync();
