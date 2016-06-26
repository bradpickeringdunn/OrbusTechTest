using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc3;
using OrbusDevTest.DataAccess;
using OrbusDevTest.DataAccess.Category;
using WebService;
using OrbusDevTest.DataAccess.OAService;

namespace OrbusDevTest
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<ICategoryRepository, CategoryRepository>();
            container.RegisterType<OrbusDevTest.DataAccess.OAService.IOAService, OAServiceClient>(new InjectionConstructor());
            return container;
        }
    }
}