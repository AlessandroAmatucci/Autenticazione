using Autenticazione.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Autenticazione.Controllers
{
    public class ReservedController : Controller
    {
        // GET: Reserved
        public ActionResult Index()
        {
            var model = new IndexModel();
            model.Title = "Autenticazione";
            model.Description = "Creato da angy e ama";
            model.SigninButton = "SignIn";
            model.SignupButton = "Signup";
            model.LogoutButton = "Logout";
            return View(model);
        }
    }
}