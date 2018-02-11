using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; // Allows setting of Primary Key 

namespace Brewery_Tracker.Models
{
    public class Users
    {
        [Key]
        public int User_ID { get; set; }
        public string User_Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string User_FName { get; set; }
        public string User_LName { get; set; }
        public string User_Address { get; set; }
        public string User_City { get; set; }
        public string User_State { get; set; }
        public string User_Zip { get; set; }

    }
}