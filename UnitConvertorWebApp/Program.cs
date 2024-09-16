using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using UnitConvertorWebApp;
using MudBlazor.Services;
using UnitConvertorWebApp.Services;
using UnitConvertorWebApp.Services.Implementations;
using MudBlazor.Extensions;
using MudExtensions.Services;
using Blazored.LocalStorage;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddMudServices();
builder.Services.AddMudExtensions();
builder.Services.AddBlazoredLocalStorage();

#region Register services

builder.Services.AddScoped<IConversionService, ConversionService>();
builder.Services.AddScoped<IFavoritesService, FavoritesService>();

#endregion

await builder.Build().RunAsync();
