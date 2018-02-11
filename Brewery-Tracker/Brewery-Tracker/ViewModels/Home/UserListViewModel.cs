using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Brewery_Tracker.Models; // to directly reference Userse Class
using System.Web.Mvc; // use SelectListItem

namespace Brewery_Tracker.ViewModels.Home
{
    public class UserListViewModel
    {
        // List of User
        public IEnumerable<SelectListItem> UserList { get; private set; }

        public List<Users> AllUsers { get; set; }


        public UserListViewModel(IEnumerable<Users> users)
        {
            // Generating a list of Beer Names
            UserList = users.Select(c => new SelectListItem() { Text = c.Username });

            AllUsers = users.OrderBy(c => c.User_ID).ToList();

        }
    }
}