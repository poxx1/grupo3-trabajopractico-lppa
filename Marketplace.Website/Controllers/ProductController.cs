using Marketplace.Business;
using Marketplace.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marketplace.Website.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            var biz = new ProductBiz();
            var model = biz.List();
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            try
            {

                var categoryBiz = new CategoryBiz();

                List<Category> categoryList = (from c in categoryBiz.List()
                                               select new Category
                                               {
                                                   Id = c.Id,
                                                   Name = c.Name
                                               }).ToList();

                List<SelectListItem> categories = categoryList.ConvertAll(c =>
                {
                    return new SelectListItem()
                    {
                        Text = c.Name.ToString(),
                        Value = c.Id.ToString(),
                        Selected = false
                    };
                });

                ViewBag.items = categories;

                return View();//Lo corte aca
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return View();
            }
        }

        [HttpPost]
        public ActionResult Create(Product model)
        {
            if (!ModelState.IsValid) // Para controlar si el modelo es válido 
              return View();

            // TODO: implementar para bitacora
            try
            {

            var categoryBiz = new CategoryBiz();

            List<Category> categoryList = (from c in categoryBiz.List()
                                            select new Category
                                            { 
                                                Id = c.Id,
                                                Name = c.Name
                                            }).ToList();

            List<SelectListItem> categories = categoryList.ConvertAll(c =>
            {
                return new SelectListItem()
                {
                    Text = c.Name.ToString(),
                    Value = c.Id.ToString(),
                    Selected = false
                };
            });

            ViewBag.items = categories;

                //return View();//Lo corte aca

            var productBiz = new ProductBiz();
            model.LastUpdated = DateTime.Now;
            productBiz.Create(model);
                
            return RedirectToAction("Index");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return View(model);
        }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var biz = new ProductBiz();
            var model = biz.Get(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Product model)
        {
            try
            {
                var biz = new ProductBiz();
                model.LastUpdated = DateTime.Now;
                biz.Edit(model);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return View(model);
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var biz = new ProductBiz();
            var model = biz.Get(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(Product model)
        {
            try
            {
                var biz = new ProductBiz();
                biz.Delete(model);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return View(model);
            }
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var biz = new ProductBiz();
            var model = biz.Get(id);
            return View(model);
        }       
    }
}