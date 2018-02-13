using Brewery_Tracker.Models;
using Brewery_Tracker.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Brewery_Tracker.Controllers
{
    public class BeersController : Controller
    {
        private BeerFactory Db = new BeerFactory();
        // GET: Beers
        public ActionResult BeerList()
        {
            var factory = new BeerFactory();

            var viewModel = new BeerListViewModel(factory.Beers);

            return View(viewModel);
        }

        // GET: Beers
        public ActionResult ListOfBeers(string searchCriteria)
        {
            //var factory = new BeerFactory();

            //var beers = new BeerFactory().Beers.ToList();

            //return View(beers);

            var factory = new BeerFactory();

            IQueryable<Beers> beers = factory.Beers.OrderBy(p => p.Beer_Name);

            if (searchCriteria != null)
            {
                beers = beers.Where(p => p.Beer_Name.Contains(searchCriteria));
            }

            var beerList = beers.Take(4).ToList();

            return View(beerList);

        }

        public ActionResult Details(int id)
        {
            var factory = new BeerFactory();

            Beers found = factory.Beers.Where(p => p.Beer_ID == id).FirstOrDefault();

            return View(found);
        }

    }
}