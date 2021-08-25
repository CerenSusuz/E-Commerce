using Business.Abstract;
using Business.Concrete;
using Business.Repositories;
using DataAccess.Entities;
using DataAccess.Repositories;
using DataAccess.Repositories.EF;
using Microsoft.EntityFrameworkCore;
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
            
            services.AddSingleton<IAccountService, AccountService>();
            services.AddSingleton<IAccountAddressService, AccountAddressService>();
            services.AddSingleton<IBrandService,BrandService>();
            services.AddSingleton<ICategoryService, CategoryService>();
            services.AddSingleton<ICityService,CityService>();
            services.AddSingleton<ICountryService, CountryService>();
            services.AddSingleton<ICurrencyService, CurrencyService>();
            services.AddSingleton<IDistrictService, DistrictService>();
            services.AddSingleton<IExchangeRateHistoryService, ExchangeRateService>();
            services.AddSingleton<IFavoriteProductService, FavoriteProductService>();
            services.AddSingleton<IGenderService, GenderService>();
            services.AddSingleton<IProductService, ProductService>();
            services.AddSingleton<IProductGroupService, ProductGroupService>();
            services.AddSingleton<IProductGroupLineService, ProductGroupLineService>();
            services.AddSingleton<IRelatedProductService, RelatedProductService>();
            services.AddSingleton<IRoleService, RoleService>();
            services.AddSingleton<IRuleService, RuleService>();
            services.AddSingleton<ISettingService, SettingService>();
            services.AddSingleton<IUserGroupService, UserGroupService>();
            services.AddSingleton<IAuthenticationService, AuthenticationService>();
            

        }
    }
}