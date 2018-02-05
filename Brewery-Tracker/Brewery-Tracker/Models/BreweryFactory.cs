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
                    Brewery_City = "Cranston",
                    Brewery_State = "Rhode Island",
                    Brewery_Zip = "02920",
                    Brewery_Rating = 9.5
                });

                context.Breweries.Add(new Brewery()
                {
                    Brewery_Name = "Proclamation Ale Company",
                    Brewery_Description = "We opened the doors of our first location in West Kingston, RI in February of 2013. Three and a half years later we took the 20 minute trek north to Warwick, RI. Our new brewery is a 15,000 square foot beast with over 5x our West Kingston production capacity. This new facility features a 2,000 square foot barrel aging and wood cellar for sour and wild ales, as well as a 3,000 square foot tasting room and retail area complete with custom art installations, bar, furniture, and a small retro video arcade. In the spring, we plan on adding an outdoor patio to the lineup.",
                    Brewery_Address = "298 Kilvert Street",
                    Brewery_City = "Warwick",
                    Brewery_State = "Rhode Island",
                    Brewery_Zip = "02886",
                    Brewery_Rating = 8.2
                });

                context.Breweries.Add(new Brewery()
                {
                    Brewery_Name = "Tilted Barn Brewery",
                    Brewery_Description = "In 2007 we founded Ocean State Hops, Rhode Island's first commercial hop farm, fueled by a passion to cram as many hops into each batch of beer as humanly possible and supply other brewers looking to quench their thirst for hops.  Over the years we have enjoyed supplying hops to local homebrewers and breweries alike.  Now we have expanded on this success and opened Tilted Barn Brewery, Rhode Island's first farm brewery."
                    + "Tilted Barn Brewery is run by Matt and Kara Richardson and is located in the historic barn on our farm in Exeter, Rhode Island, which has been in Kara's family for over 50 years.  Our mission is to expand upon the success of Ocean State Hops and provide local, hand-crafted beer that is brewed with ingredients grown right here on the farm."
                    + "The motivation behind Tilted Barn Brewery is to keep Kara's family tradition of farming alive while adding our own modern twist for craft beer and the art of brewing.  A trip to our farm brewery is beyond that of the normal brewery experience.  Visitors to the brewery can get a firsthand look at what goes into each batch of our hand-crafted beer.  You'll get to learn a little history of not only farming in our area but hop farming throughout all of New England(Matt could go on for hours about that...).Walk through the fields and see, touch, and smell the ingredients that will go into their beer, then relax in a century-old barn while enjoying the fruits of our labor.We're hopeful that Tilted Barn Brewery will help to revive the hop farming and farm brewery tradition of New England that was lost long ago.",
                    Brewery_Address = "1 One Hemsley Pl",
                    Brewery_City = "Exeter",
                    Brewery_State = "Rhode Island",
                    Brewery_Zip = "02822",
                    Brewery_Rating = 9.0
                });


                context.Breweries.Add(new Brewery()
                {
                    Brewery_Name = "Foolproof Brewing",
                    Brewery_Description = "At Foolproof, we think about beer a bit differently. To us, beer is not just an alcoholic beverage but an experience that should be thoroughly savored and enjoyed. That’s why when we brew each beer, we think about specific life experiences and what style of beer would be absolutely perfect for that particular occasion. That’s how we came up with the concept of “experience-based brewing.” Each of our beers serves as a tribute to a sacred beer drinking experience—whether you’re watching a baseball game, relaxing at home on a rainy day, or just catching up with friends at the local pub, Foolproof’s goal is to create a unique and fulfilling beer experience for you. Cheers! And remember, it’s Your Life. Your Beer",
                    Brewery_Address = "241 Grotto Ave #1",
                    Brewery_City = "Pawtucket",
                    Brewery_State = "Rhode Island",
                    Brewery_Zip = "02860",
                    Brewery_Rating = 8.5
                });


                context.Breweries.Add(new Brewery()
                {
                    Brewery_Name = "Whalers Brewing Company",
                    Brewery_Description = "Founded in 2011, Whalers Brewing Company is a project by Josh Dunlap and Wes Staschke. We brew beer we like to drink, and we only drink good beer.",
                    Brewery_Address = "1174 Kingstown Rd",
                    Brewery_City = "South Kingstown",
                    Brewery_State = "Rhode Island",
                    Brewery_Zip = "02879",
                    Brewery_Rating = 8.4
                });

            }
        }
    }
}