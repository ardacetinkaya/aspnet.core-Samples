using Microsoft.AspNet.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Net.Http.Headers;
using Newtonsoft.Json;

namespace Webby.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
         
         var serviceDescription = new ServiceDescriptor(typeof(IPluginService),typeof(WelcomePlugin),ServiceLifetime.Transient);

            services
                .AddMvcCore()
                .AddAuthorization()
                .AddFormatterMappings(m => m.SetMediaTypeMappingForFormat("js", new MediaTypeHeaderValue("application/json")))
                .AddJsonFormatters(j => j.Formatting = Formatting.Indented)
                .Services.Add(serviceDescription);
            
            
        }

        
        public void Configure(IApplicationBuilder app)
        {
            
            app.UseMvcWithDefaultRoute();
        }
    }
}