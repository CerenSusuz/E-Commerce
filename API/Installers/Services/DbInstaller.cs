using DataAccess.Contexts.EF;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace API.Installers.Services
{
    public class DbInstaller : IServiceInstaller, IConfigureInstaller
    {
        public void InstallService(IServiceCollection services)
        {
            services.AddDbContext<ECommerceContext>(
                o =>
                {
                    o.UseSqlServer("Server=localhost,1433;Database=E-Commerce;User=sa;Password=Yaren#1998;");
                }, ServiceLifetime.Singleton
        );
    }

        public void InstallConfigure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var context = app.ApplicationServices.GetService<ECommerceContext>();
            context?.Database?.Migrate();
        }
    }
}