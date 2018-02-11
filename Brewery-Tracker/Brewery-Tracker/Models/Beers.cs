using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; // Allows setting of Primary Key 

namespace Brewery_Tracker.Models
{
    public class Beers
    {
        [Key]
        public int Beer_ID { get; set; }
        // TODO ADD BREWERY ID
        public string Beer_Name { get; set; }
        public string Beer_Description { get; set; }
        public double Beer_Rating { get; set; }
    }
}