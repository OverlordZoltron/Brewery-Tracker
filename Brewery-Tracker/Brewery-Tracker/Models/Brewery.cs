using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; // Allows setting of Primary Key 

namespace Brewery_Tracker.Models
{
    public class Brewery
    {
        [Key]
        public int Brewery_ID { get; set; }
        public string Brewery_Name { get; set; }
        public string Brewery_Description { get; set; }
        public string Brewery_Address { get; set; }
        public string Brewery_City { get; set; }
        public string Brewery_State { get; set; }
        public string Brewery_Zip { get; set; }
        public double Brewery_Rating { get; set; }
   
    }
}