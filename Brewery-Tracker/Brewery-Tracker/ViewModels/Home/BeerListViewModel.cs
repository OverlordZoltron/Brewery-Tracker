using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Brewery_Tracker.Models; // to directly reference Beer Class
using System.Web.Mvc; // use SelectListItem

namespace Brewery_Tracker.ViewModels.Home
{
    public class BeerListViewModel
    {
        // List of Beers
        public IEnumerable<SelectListItem> BeerList { get; private set; }

        // Beer instance of Top Rated beers
        public Beers TopRatedBeer { get; set; }

        public List<Beers> AllBeers { get; set; }


        public BeerListViewModel(IEnumerable<Beers> beers)
        {
            // Generating a list of Beer Names
            BeerList = beers.Select(c => new SelectListItem() { Text = c.Beer_Name });

            // Pointer to the top rated beer
            TopRatedBeer = beers.OrderByDescending(c => c.Beer_Rating).FirstOrDefault();

            AllBeers = beers.OrderBy(c => c.Beer_ID).ToList();

        }

    }
}