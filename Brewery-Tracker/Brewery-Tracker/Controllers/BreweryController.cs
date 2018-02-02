using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Brewery_Tracker.Models;
using Brewery_Tracker.ViewModels.Home;

namespace Brewery_Tracker.Controllers
{
    public class BreweryController : Controller
    {
        // GET: Brewery
        public ActionResult BreweryList()
        {
            // factory -> a new instance of the BreweryFactory model
            var factory = new BreweryFactory();
            
            //viewModel -> the viewModel filled with the breweries list
            var viewModel = new BreweryListViewModel(factory.Breweries);

            return View(viewModel);
        }
    }
}