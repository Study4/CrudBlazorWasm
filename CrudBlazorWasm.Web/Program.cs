using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;


namespace CrudBlazorWasm.Web
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => 
            // new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            new HttpClient { BaseAddress = new Uri( builder.Configuration.GetValue<string>("ApiBaseUrl")) } );
    
            builder.Logging.AddConfiguration(builder.Configuration.GetSection("Logging"));

            await builder.Build().RunAsync();
        }
    }
}
