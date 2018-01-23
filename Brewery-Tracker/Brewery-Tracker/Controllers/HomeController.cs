using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Brewery_Tracker.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Signup()
        {
            ViewBag.Message = "Sign up page";

            var viewModel = new ViewModels.Home.ShowStates();

            return View(viewModel);
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Login Page -- Sign in to your account here!";

            return View();
        }

        public ActionResult Breweries()
        {
            ViewBag.Message = "Breweries Page -- Checkout some local breweries here!";

            return View();
        }

        public ActionResult Beers()
        {
            ViewBag.Message = "Beers Page -- Checkout some local brewery beers here!";

            return View();
        }
    }
}