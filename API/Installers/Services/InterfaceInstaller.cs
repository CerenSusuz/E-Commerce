using Business.Abstract;
using Business.Concrete;
using Business.Repositories;
using DataAccess.Entities;
using DataAccess.Repositories;
using DataAccess.Repositories.EF;
using Microsoft.Extensions.DependencyInjection;
using AuthenticationService = Microsoft.AspNetCore.Authentication.AuthenticationService;
using IAuthenticationService = Microsoft.AspNetCore.Authentication.IAuthenticationService;

namespace API.Installers.Services
{
    public class InterfaceInstaller:IServiceInstaller
    {
        public void InstallService(IServiceCollection services)
        {
            services.AddSingleton(typeof(IRepository<>), typeof(EfRepository<>));
            services.AddSingleton(typeof(IServiceRepository<>), typeof(ServiceRepository<,>));
            services.AddSingleton<IGenderService, GenderService>();
            services.AddSingleton<IUserGroupService, UserGroupService>();
            services.AddSingleton<IAccountService, AccountService>();
            services.AddSingleton<IAuthenticationService, AuthenticationService>();
            services.AddSingleton<IBrandService,BrandService>();
            

        }
    }
}