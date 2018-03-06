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
        [Required]
        [RegularExpression("..+", ErrorMessage = "Must be at least 2 characters long")]
        public string Beer_Name { get; set; }
        [RegularExpression("..+", ErrorMessage = "Must be at least 2 characters long")]
        public string Beer_Description { get; set; }
        [Range(0, 10)]
        public double Beer_Rating { get; set; }

        public string ImageName { get; set; }

        public int Brewery_ID { get; set; }
        
        public virtual Brewery Brewery { get; set; } // this will link to the associated Brewery Table
    }
}