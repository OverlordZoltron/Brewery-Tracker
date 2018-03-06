using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Brewery_Tracker.Models
{
    public class Brewery_TrackContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Brewery_TrackContext() : base("name=Brewery_TrackContext")
        {
        }

        public System.Data.Entity.DbSet<Brewery_Tracker.Models.Brewery> Breweries { get; set; }

        public System.Data.Entity.DbSet<Brewery_Tracker.Models.Beers> Beers { get; set; }
    }
}
