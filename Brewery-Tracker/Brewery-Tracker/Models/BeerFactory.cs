using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Brewery_Tracker.Models
{
    public class BeerFactory : DbContext
    {
        public DbSet<Beers> Beers { get; set; }

        public BeerFactory() : base("name=DefaultConnection")
        {
            Database.SetInitializer(new BeerInitializer());
        }
    }

    public class BeerInitializer : DropCreateDatabaseIfModelChanges<BeerFactory>
    {
        protected override void Seed(BeerFactory context)
        {
            {
                context.Beers.Add(new Beers()
                {
                    Beer_Name = "Rocky Point Red Ale",
                    Beer_Description = "Our Rocky Point Red Ale draws its name from the legendary Rhode Island amusement park, now reborn as a seaside nature preserve. Light caramel tones and honey malt mix with Citra and El Dorado hops to create a smooth and balanced flavor that will transport you to a summer day by the shore no matter what time of year.",
                    Beer_Rating = 10
                });

                context.Beers.Add(new Beers()
                {
                    Beer_Name = "Adelia",
                    Beer_Description = "Pale Ale began as a home brewers dream, and grew into an icon.",
                    Beer_Rating = 8.5
                });

                context.Beers.Add(new Beers()
                {
                    Beer_Name = "The Chosen One DIPAr",
                    Beer_Description = "You asked for it and we delivered. An American DIPA overflowing with hops and weighing in at a surprisingly subtle 8.5% ABV. This beer needs no introduction, just sit back, relax and enjoy. You have chosen wisely.",
                    Beer_Rating = 9
                });

                context.Beers.Add(new Beers()
                {
                    Beer_Name = "BACKYAHD",
                    Beer_Description = "The ultimate suburban brew, Backyahd is an aggressively hopped American IPA with a tantalizing hop aroma. The beer’s bitterness pairs perfectly with spicy foods coming straight off the grill. Enjoy it with friends, family, or whomever you choose. After all, it’s your Backyahd.",
                    Beer_Rating = 9.5
                });

            }
        }
    }


}
