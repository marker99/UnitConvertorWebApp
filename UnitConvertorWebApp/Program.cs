using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using UnitConvertorWebApp;
using MudBlazor.Services;
using UnitConvertorWebApp.Services;
using UnitConvertorWebApp.Services.Implementations;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddMudServices();

#region Register services

builder.Services.AddScoped<IConversionService, ConversionService>();
builder.Services.AddScoped<ITemperatureConversionService, TemperatureConversionService>();
builder.Services.AddScoped<IWeightConversionService, WeightConversionService>();
builder.Services.AddScoped<ITimeConversionService, TimeConversionService>();

#endregion

await builder.Build().RunAsync();
