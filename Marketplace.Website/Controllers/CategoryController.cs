using Marketplace.Business;
using Marketplace.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marketplace.Website.Controllers
{
    public class CategoryController : Controller
    {
        /// <summary>
        /// Listar categorias para generar el modelo que luego 
        /// se lo paso a la vista para que la muestre
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var biz = new CategoryBiz();
            var model = biz.List();
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

     

        [HttpPost]
        public ActionResult Create(Category model)
        {
            if (!ModelState.IsValid) // Para controlar si el modelo es válido 
                return View();

            // TODO: implementar para bitacora
            try
            {
                var biz = new CategoryBiz();
                biz.Create(model);
                return RedirectToAction("Index");// Para redireccionar al index de Categorias
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
            var biz = new CategoryBiz();
            var model = biz.Get(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Category model)
        {
            try
            {
                var biz = new CategoryBiz();
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
            var biz = new CategoryBiz();
            var model = biz.Get(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(Category model)
        {
            try
            {
                var biz = new CategoryBiz();
                biz.Delete(model);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return View(model);
            }
        }
    }
}