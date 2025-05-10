using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using RedVial_Arboles.Services;

namespace RedVial_Arboles
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            //builder.Services.AddScoped<Simulacion>();

            builder.Services.AddHttpClient<Simulacion>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:7226");
            });

            await builder.Build().RunAsync();
        }
    }
}
