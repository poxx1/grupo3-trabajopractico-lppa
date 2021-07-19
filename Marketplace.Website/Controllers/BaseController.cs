using System.Web.Mvc;

namespace Marketplace.Website.Controllers
{
    public abstract class BaseController : Controller
    {
        protected string GetRedirectUrl(string returnUrl)
        {
            if(string.IsNullOrEmpty(returnUrl) || !Url.IsLocalUrl(returnUrl))
            {
                return Url.Action("Index", "Home");
            }
            return returnUrl;
        }
    }
}