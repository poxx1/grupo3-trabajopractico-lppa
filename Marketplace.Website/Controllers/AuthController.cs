using System.Web.Mvc;
using Marketplace.Entities.Models;
using System.Web;
using System.Security.Claims;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Marketplace.Business;

namespace Marketplace.Website.Controllers
{
    [AllowAnonymous]
    public class AuthController : BaseController
    {
        [HttpGet]
        public ActionResult LogIn(string returnUrl)
        {
            var model = new LogInModel
            {
                ReturnUrl = @returnUrl
            };            
            return View(model);
        }

        [HttpPost]
        public ActionResult LogIn(LogInModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

        #region NewLoginWithBD

            if (model.Email != "" && model.Password != "")
            {
                var biz = new LoginBiz();
                var models = biz.List();
                foreach (var users in models)
                {
                    if (users.Email == model.Email && model.Password == users.Password)
                    {
                    //Aca le tengo que agregar que saque esto de la bd
                    ///*
                    var claims = new[]
                    {
                    new Claim(ClaimTypes.Name, "Admin"),
                    new Claim(ClaimTypes.Email, model.Email),
                    new Claim(ClaimTypes.Country, "Argentina"),};//*/

                    var identity = new ClaimsIdentity(claims, "ApplicationCookie");

                    IOwinContext context = Request.GetOwinContext();
                    IAuthenticationManager authManager = context.Authentication;

                    authManager.SignIn(identity);
                    return Redirect(GetRedirectUrl(model.ReturnUrl));
                    }
                }
                ModelState.AddModelError("", "El email o la contraseña no son válidos.");
                return View();
                //return View(model);
            }
            ModelState.AddModelError("", "El email o la contraseña no son válidos.");
            return View();
            #endregion

            #region OldLogin
            //TO DO:
            /*
            if (model.Email == "admin@admin.com" && model.Password == "admin")
            {
                //Aca le tengo que agregar que saque esto de la bd
                ///*
                var claims = new[]
                {
                    new Claim(ClaimTypes.Name, "admin"),
                    new Claim(ClaimTypes.Email, "admin@admin.com"),
                    new Claim(ClaimTypes.Country, "Argentina"),
                };

                var identity = new ClaimsIdentity(claims, "ApplicationCookie");

                IOwinContext context = Request.GetOwinContext();
                IAuthenticationManager authManager = context.Authentication;

                authManager.SignIn(identity);
                return Redirect(GetRedirectUrl(model.ReturnUrl));
            }
            ModelState.AddModelError("", "El email o la contraseña no son válidos.");
            return View();
            */
            #endregion
        }

        public ActionResult LogOut()
        {
            var context = Request.GetOwinContext();
            var authManager = context.Authentication;

            authManager.SignOut("ApplicationCookie");
            return RedirectToAction("Index", "Home");
        }
    }
}