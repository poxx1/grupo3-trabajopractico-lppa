using System.Web.Mvc;
using Marketplace.Business;
using Marketplace.Data.Services;

namespace Marketplace.Website.Controllers
{   
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ProductBiz _db;
 

        [HttpGet]
        public ActionResult Index()
        {
            return View(); // => html
        }        
    }
}