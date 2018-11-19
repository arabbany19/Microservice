using Bootcamp20.Micro.BussinessLogic.Repository;
using Bootcamp20.Micro.BussinessLogic.Service;
using Bootcamp20.Micro.Common.Interfaces;
using Bootcamp20.Micro.Common.Interfaces.Application;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Bootcamp20.Micro
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<ISupplierService, SupplierService>();
            container.RegisterType<ISupplierRepository, SupplierRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}