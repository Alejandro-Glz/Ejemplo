using Acadamy.Core.RepositoryInterfaces;
using Acadamy.Core.Services;
using Acadamy.Core.ServicesInterfaces;
using Academy.Infrastructure.Repositories;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace Academy.API
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<ITodosService, TodosService>();

            container.RegisterType<ITodosRepository, LocalTodosRepository>();


            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}