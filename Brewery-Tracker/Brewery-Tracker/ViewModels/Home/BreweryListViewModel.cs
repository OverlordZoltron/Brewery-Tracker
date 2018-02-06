using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Brewery_Tracker.Models; // to directly reference Brewery Class
using System.Web.Mvc; // use SelectListItem

namespace Brewery_Tracker.ViewModels.Home
{
    public class BreweryListViewModel
    { 
        // List of Breweries
        public IEnumerable<SelectListItem> BreweryList { get; private set; }

        // Brewery instance of Top Rated Brewery
        public Brewery TopRatedBrewery { get; set; }

        public List<Brewery> AllBreweries { get; set; }


        public BreweryListViewModel(IEnumerable<Brewery> breweries)
        {
            // Generating a list of Brewery Names
            BreweryList = breweries.Select(c => new SelectListItem() { Text = c.Brewery_Name });

            // Pointer to the top rated brewery
            TopRatedBrewery = breweries.OrderByDescending(c => c.Brewery_Rating).FirstOrDefault();

            AllBreweries = breweries.OrderBy(c => c.Brewery_ID).ToList();

        }

    }
}