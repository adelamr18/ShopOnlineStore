using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ShopOnline.WebApplication;
using ShopOnline.WebApplication.Services;
using ShopOnline.WebApplication.Services.Contracts;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7065") });
builder.Services.AddScoped<IProductService, ProductService>();

await builder.Build().RunAsync();

