using API.Extensions;
using Core.Tools;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace API
{
    public class Startup
    {
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.InstallAllService();
            ServiceTool.Create(services);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.InstallAllConfiguration(env);
        }
    }
}