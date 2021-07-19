using Marketplace.Business;
using Marketplace.Entities.Models;
using System;
using System.Web.Mvc;

namespace Marketplace.Website.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/Details/5
        public ActionResult List()
        {
            var biz = new LoginBiz();
            var model = biz.List();
            return View(model);
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        public ActionResult Create(LogInModel model)
        {
            if (!ModelState.IsValid) // Para controlar si el modelo es válido 
                return View();

            // TODO: implementar para bitacora
            try
            {
                var biz = new LoginBiz();
                biz.Create(model);
                return RedirectToAction("Index");//
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return View(model);
            }
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            var biz = new LoginBiz();
            var model = biz.Get(id);
            return View(model);
        }

        // POST: Admin/Edit/5
        [HttpPost]
        public ActionResult Edit(LogInModel model)
        {
            try
            {
                var biz = new LoginBiz();
                biz.Edit(model);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return View(model);
            }
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            var biz = new LoginBiz();
            var model = biz.Get(id);
            return View(model);
        }

        // POST: Admin/Delete/5
        [HttpPost]
        public ActionResult Delete(LogInModel model)
        {
            try
            {
                var biz = new LoginBiz();
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
