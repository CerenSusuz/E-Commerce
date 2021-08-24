using System.Reflection;
using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.Aspects.Interceptors;
using Module = Autofac.Module;

namespace Business.Installers
{
    public class AutofacBusinessModule  :Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces().EnableInterfaceInterceptors(
                new ProxyGenerationOptions
                {
                    Selector = new AspectInterceptorSelector()
                    
                }).SingleInstance();
        }
    }
}