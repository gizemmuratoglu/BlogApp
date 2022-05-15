using BlogApp.Identity;
using BlogApp.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApp.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> UserManager;
        private RoleManager<ApplicationRole> RoleManager;
        // GET: Acoount

        public  AccountController()
        {
            var userStore = new UserStore<ApplicationUser>(new IdentityDataContext());
            UserManager = new UserManager<ApplicationUser>(userStore);

            var roleStore = new RoleStore<ApplicationRole>(new IdentityDataContext());
            RoleManager = new RoleManager<ApplicationRole>(roleStore);
        }
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Register model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser();
                user.Name = model.Name;
                user.UserName = model.UserName;

                IdentityResult result= UserManager.Create(user, model.Password);

                if (result.Succeeded)
                {
                    UserManager.AddToRole(user.Id, "user");
                    return RedirectToAction("Login", "Account");

                }
                else
                {
                    ModelState.AddModelError("registerERROR","Register Error.");

                }
              
            }


            return View(model);
        }



        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login model)
        {
            if (ModelState.IsValid)
            {
               // Console.WriteLine(model.Password + model.UserName);
            var user = UserManager.Find(model.UserName, model.Password);

            if(user != null)
            {
                var authManager = HttpContext.GetOwinContext().Authentication;
                var identityclaims = UserManager.CreateIdentity(user, "ApplicationCookie");
                var authProperties = new AuthenticationProperties();
                new AuthenticationProperties().IsPersistent = model.RememberMe;
                authManager.SignIn(authProperties,identityclaims);

                return RedirectToAction("Index","Home");
            }
            else
            {
                return RedirectToAction("Index", "Category");
            }
            }
            return View(model);
        }

        public ActionResult Logout()
        {
            var authManager = HttpContext.GetOwinContext().Authentication;
            authManager.SignOut();

            return RedirectToAction("Index","Post");
        }


    }
}