using Core.Plugins.Caching;
using Core.Plugins.Caching.Redis;
using Microsoft.Extensions.DependencyInjection;

namespace API.Installers.Services
{
    public class RedisInstaller:IServiceInstaller
    {
        public void InstallService(IServiceCollection services)
        {
            services.AddSingleton<IRedisServer, RedisServer>();
            services.AddSingleton<ICacheService, RedisCacheService>();
            var opt = new RedisOption
            {
                InstanceName = "EShop.Api",
                ConnectionString = "localhost:6376,ssl=False",
                AbsoluteExpiration = 60
            };
            services.AddSingleton(opt);
        }
    }
}