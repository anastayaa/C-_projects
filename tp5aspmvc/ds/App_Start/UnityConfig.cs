using ds.Services;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace ds
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            container.RegisterType<IEtudiantService, EtudiantServiceImpl>();
            container.RegisterType<IFiliereService, FiliereServiceImpl>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

    }

}