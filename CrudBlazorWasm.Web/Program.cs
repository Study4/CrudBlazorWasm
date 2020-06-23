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
            builder.RootComponents.Add<App>("app");

            //builder.Logging (builder.Configuration.GetServiceUri("crudaspnetcore-api"));

            builder.Services.AddTransient(sp => 
                //new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
                // 因為 Web Assambly 所以不支援 Tye 的 GetServiceUri
                // new HttpClient { BaseAddress = builder.Configuration.GetServiceUri(name: "crudaspnetcore-api", binding: "https") });
                new HttpClient { BaseAddress = new Uri("http://localhost:5000") } );

            await builder.Build().RunAsync();
        }
    }
}
