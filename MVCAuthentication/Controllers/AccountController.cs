using MVCAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCAuthentication.Controllers
{

    [AllowAnonymous]
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Login()
        {


            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModal modal)
        {

            // Oturum açma işlemi
            FormsAuthentication.SetAuthCookie(modal.Email, false);
            return View();
        }

        public ActionResult Logout()
        {
            // Oturum kapama işlemi




            //if (User.Identity.IsAuthenticated)
            //{

                FormsAuthentication.SignOut();
            //}

            return View();
        }
    }
}