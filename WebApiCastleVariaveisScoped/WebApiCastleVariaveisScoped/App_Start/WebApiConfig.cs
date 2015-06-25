using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;
using System.Web.Http.Dependencies;
using Castle.MicroKernel;
using Castle.MicroKernel.Lifestyle;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using WebApiCastleVariaveisScoped.Models;
using IDependencyResolver = System.Web.Http.Dependencies.IDependencyResolver;

namespace WebApiCastleVariaveisScoped
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }


    internal class WindsorDependencyResolver : IDependencyResolver
    {
        private readonly IKernel container;

        public WindsorDependencyResolver(IKernel container)
        {
            this.container = container;
        }

        public IDependencyScope BeginScope()
        {
            return new WindsorDependencyScope(this.container);
        }

        public object GetService(Type serviceType)
        {
            return this.container.HasComponent(serviceType) ? this.container.Resolve(serviceType) : null;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return this.container.ResolveAll(serviceType).Cast<object>();
        }

        public void Dispose() { }
    }

    public class WindsorDependencyScope : IDependencyScope
    {
        private readonly IKernel container;
        private readonly IDisposable scope;

        public WindsorDependencyScope(IKernel container)
        {
            this.container = container;
            this.scope = container.BeginScope();
        }

        public object GetService(Type serviceType)
        {
            return this.container.HasComponent(serviceType) ? this.container.Resolve(serviceType) : null;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return this.container.ResolveAll(serviceType).Cast<object>();
        }

        public void Dispose()
        {
            this.scope.Dispose();
        }
    }

    public class WindsorWebApiInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(AllTypes.FromThisAssembly().BasedOn<ApiController>().LifestyleScoped());
            container.Register(
                Component.For<IObjetosSemEscopo>().ImplementedBy<ObjetosSemEscopo>().LifestylePerThread(),
                Component.For<IObjetosComEscopo>().ImplementedBy<ObjetosComEscopo>().LifestyleScoped());
        }
    }

}
