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
        [Required(ErrorMessage = "Brewery Name is required")]
        [RegularExpression("..+", ErrorMessage = "Must be at least 2 characters long")]
        public string Brewery_Name { get; set; }
        [Required(ErrorMessage = "Brewery Description is required")]
        public string Brewery_Description { get; set; }
        [Required(ErrorMessage = "Brewery Address is required")]
        public string Brewery_Address { get; set; }
        [Required(ErrorMessage = "Brewery City is required")]
        public string Brewery_City { get; set; }
        [Required(ErrorMessage = "Brewery State is required")]
        public string Brewery_State { get; set; }
        [Required(ErrorMessage = "Brewery Zip is required")]
        [RegularExpression(".....+", ErrorMessage = "Must be at least 5 characters long")]
        public string Brewery_Zip { get; set; }
        [Required(ErrorMessage = "Brewery Rating is required")]
        public double Brewery_Rating { get; set; }
   
    }
}