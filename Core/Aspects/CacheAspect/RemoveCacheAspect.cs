using Castle.DynamicProxy;
using Core.Aspects.Interceptors;
using Core.Plugins.Caching;
using Core.Tools;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Aspects.CacheAspect
{
    public class RemoveCacheAspect : MethodInterception
    {
        private readonly ICacheService _cacheService;
        private readonly int _db;

        private readonly string _pattern;

        public RemoveCacheAspect(string pattern = "", int db = 0)
        {
            _db = db;
            _pattern = pattern;
            Priority = 10;
            _cacheService = ServiceTool.ServiceProvider.GetService<ICacheService>();
        }

        public override void OnSuccess(IInvocation invocation)
        {
            var key = _pattern == "" ? $"{invocation.InvocationTarget.GetType().Name.Replace("Service", "")}" : _pattern;
            if (invocation.Method.ReflectedType == null) return;
            _cacheService.RemoveByPatternAsync(key, _db);
        }
    }
}