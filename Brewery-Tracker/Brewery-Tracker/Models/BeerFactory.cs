using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Brewery_Tracker.Models
{
    public class BeerFactory: DbContext
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
                    Beer_Name = "Stella Artois",
                    Beer_Description = "#1 best-selling belgian beer in the world!",
                    Beer_Rating = 10
                });

                context.Beers.Add(new Beers()
                {
                    Beer_Name = "Sierra Nevada Pale Ale",
                    Beer_Description = "Pale Ale began as a home brewers dream, and grwe into an icon.",
                    Beer_Rating = 8.5
                });

                context.Beers.Add(new Beers()
                {
                    Beer_Name = "Yuengling Larger",
                    Beer_Description = "An Iconinc American larger famous for its rich amber color and medium-bodied flavor.",
                    Beer_Rating = 9
                });

                context.Beers.Add(new Beers()
                {
                    Beer_Name = "Harpoon IPA",
                    Beer_Description = "Harmony in hops, malt, and yeast",
                    Beer_Rating = 9.5
                });

            }
        }
    }


}