using FirstBlazorApp;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(
    sp => new HttpClient { 
    BaseAddress = new Uri("https://goweather.herokuapp.com/weather/") });

//weatherapi.com API Key: 3425dafa45e84d61a90192048230703 password: Sun4fun!

await builder.Build().RunAsync();
