using Brewery_Tracker.Models;
using Brewery_Tracker.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Brewery_Tracker.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UserList()
        {
            var factory = new UserFactory();

            var viewModel = new UserListViewModel(factory.Users);

            return View(viewModel);
        }
    }
}