using System.Web.Mvc;
namespace Marketplace.Website
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute()); //se encarga de capturar los errores
            filters.Add(new AuthorizeAttribute()); //agregar filtros de autorizacion, sino me redirecciona a un error 401
            // por ultimo lo registro en global.azax.cs
        }
        //HTTP Error 404.15 - Not Found porque no tengo el decorado de autorizacion, por defecto lo pone como
        //[Authorize] en el controller y se llama recursivamente, se debe agregar en el controller [AllowAnonymous]
    }
}
