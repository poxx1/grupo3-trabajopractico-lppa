using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;
using Marketplace.Website.App_Start;

namespace Marketplace.Website
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)// levanta la app
        {
            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();// registra las areas que tiene el proyecto, cada una va a tener una modelo - vista - controlador
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes); // busca el archivo routeconfig y genera las rutas para la app
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters); //registro las tablas
            ContainerConfig.RegisterContainer(); //
        }
    }
}