using System.Collections.Generic;
using System.Web.Mvc;
using Marketplace.Business;
using Marketplace.Data.Services;
using Marketplace.Entities.Models;

namespace Marketplace.Website.Controllers
{   
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ProductBiz _db;
        public static List<Product> cartProducts = new List<Product>();

        [HttpGet]
        // List all of the products
        public ActionResult Carrito(Product product)
        {
            if (product.CategoryId != 0)
                cartProducts.Add(product);

            return View(cartProducts);
        }

        //[HttpGet]
        //// Clear the cart
        //public ActionResult CarritoQuitItem(Product product)
        //{
        //    cartProducts.Remove(product);
        //    return Carrito();
        //}

        //[HttpGet]
        //// Clear the cart
        //public ActionResult CarritoClear()
        //{
        //    cartProducts.Clear();
        //    return View(cartProducts);
        //}

        [HttpGet]
        public ActionResult View(int id)
        {
            var biz = new ProductBiz();
            var listProducts = biz.List();
            List<Product> listProductsCategory = new List<Product>();

            foreach (var prod in listProducts)// Por cada Item en la lista 
            {
                if (id == prod.CategoryId)
                {
                    listProductsCategory.Add(prod);
                }
            }
            return View(listProductsCategory);
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(); // => html
        }        
    }
}