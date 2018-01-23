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



           List<string> StateList = new List<string>();
            StateList.Add("Select One");
            StateList.Add("Connecticut");
            StateList.Add("Maine");
            StateList.Add("Massachusetts");
            StateList.Add("New Hampshire");
            StateList.Add("Rhode Island");
            StateList.Add("Vermont");

            ViewBag.States = StateList;

            return View();
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