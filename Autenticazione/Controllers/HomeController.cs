using Autenticazione.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Autenticazione.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
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

        public ActionResult Signin()
        {
            var model = new SigninModel();
            model.Title = "Autenticazione";
            model.Description = "Creato da angy e ama";
            model.SigninButton = "SignIn";
            model.SignupButton = "Signup";
            model.LogoutButton = "Logout";
            model.LabelButtonUsername = "Username";
            model.LabelButtonPassword = "Password";
            model.LabelButtonSubmit = "Submit";
            return View(model);
        }

        public ActionResult Signup()
        {
            var model = new SignupModel();
            model.Title = "Autenticazione";
            model.Description = "Creato da angy e ama";
            model.SigninButton = "SignIn";
            model.SignupButton = "Signup";
            model.LogoutButton = "Logout";
            model.LabelButtonUsername = "Username";
            model.LabelButtonPassword = "Password";
            model.LabelButtonConfirmPassword = "ConfirmPassword";
            model.LabelButtonSubmit = "Submit";
            return View(model);
        }
    }
}