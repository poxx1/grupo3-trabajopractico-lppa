using Autofac;
using Autofac.Integration.Mvc;
using System.Web.Mvc;
using Marketplace.Data.Services;
using Marketplace.Entities.Models;

namespace Marketplace.Website.App_Start
{
    public class ContainerConfig
    {
        /// <summary>
        /// Inyección de dependencias para lograr desacoplamiento para que no utilice las capas concretas (InMemoryProductData), 
        /// sino que utilice las abstracciones (Products)
        /// </summary>
        internal static void RegisterContainer()
        {
            var builder = new ContainerBuilder();// creo el container builder

            builder.RegisterControllers(typeof(Global).Assembly);// registro el controlador
            //builder.RegisterControllers(typeof(MVCApplication).Assembly);// registro el controlador

            // ## RegisterType: se utiliza para registrar cada uno de los tipos que voy a usar
            //builder.RegisterType<InMemoryProductData>().As<IProductData>().SingleInstance();
            //builder.RegisterType<Product>().As<IProductData>().SingleInstance();            
            //builder.RegisterType<Clase_Concreta>().As<Interfase>().SingleInstance();

            // ## RegisterType

            var container = builder.Build();// se construye

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));// resolver la dependencia
        }
    }
}