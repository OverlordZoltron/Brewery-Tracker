using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; // Added in order to use DB Context

namespace Brewery_Tracker.Models
{
    public class BreweryFactory : DbContext
    {

        public DbSet<Brewery> Breweries { get; set; } // Create a set of DB Entities that can work with Brewery instances in a table

        public BreweryFactory() : base("name=DefaultConnection")
        {
            Database.SetInitializer(new BreweryInitializer());
        }
    }

    public class BreweryInitializer: DropCreateDatabaseIfModelChanges<BreweryFactory>
    {
        protected override void Seed(BreweryFactory context)
        {
            {
                context.Breweries.Add(new Brewery() {
                    Brewery_Name = "Revival Brewery",
                    Brewery_Description = "Revival Brewing Company is a renewal of brewmaster Sean Larkin’s passion for unique and innovative beers, cultivated over twenty years of creating signature brews for the preeminent breweries in Rhode Island. Though he’d been thinking about striking out on his own for a few years, it was an introduction to Owen Johnson, an avid home brewer, in late 2009 that set in motion that which would become Revival. Over that first December breakfast meeting at Nick’s on Broadway, the two discovered how closely their ambitions and passions aligned.",
                    Brewery_Address = "505 Atwood Ave",
                    Brewery_City = "Cranston ",
                    Brewery_State = "Rhode Island",
                    Brewery_Zip = "02920",
                    Brewery_Rating = 9.5
                });

                context.Breweries.Add(new Brewery()
                {
                    Brewery_Name = "Proclamation Ale Company",
                    Brewery_Description = "We opened the doors of our first location in West Kingston, RI in February of 2013. Three and a half years later we took the 20 minute trek north to Warwick, RI. Our new brewery is a 15,000 square foot beast with over 5x our West Kingston production capacity. This new facility features a 2,000 square foot barrel aging and wood cellar for sour and wild ales, as well as a 3,000 square foot tasting room and retail area complete with custom art installations, bar, furniture, and a small retro video arcade. In the spring, we plan on adding an outdoor patio to the lineup.",
                    Brewery_Address = "298 Kilvert Street",
                    Brewery_City = "Warwick ",
                    Brewery_State = "Rhode Island",
                    Brewery_Zip = "02886",
                    Brewery_Rating = 8.2
                });
            }
        }
    }
}