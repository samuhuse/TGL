using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TglTest.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<ProductService>();

await builder.Build().RunAsync();
