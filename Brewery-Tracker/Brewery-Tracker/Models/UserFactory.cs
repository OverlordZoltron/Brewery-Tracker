using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Brewery_Tracker.Models
{
    public class UserFactory : DbContext
    {

        public DbSet<Users> Users { get; set; } // Create a set of DB Entities that can work with Brewery instances in a table

        public UserFactory() : base("name=DefaultConnection")
        {
            Database.SetInitializer(new UserInitializer());
        }
    }

    public class UserInitializer : DropCreateDatabaseIfModelChanges<UserFactory>
    {
        protected override void Seed(UserFactory context)
        {
            {
                context.Users.Add(new Users()
                {
                    Username = "ian",
                    User_Email = "ian@gmail.com",
                    Password = "password",
                    User_FName = "Ian",
                    User_LName = "Arsenault",
                    User_Address = "1234 New Street",
                    User_City = "Providence",
                    User_State = "Rhode Island",
                    User_Zip = "02906",
                });

                context.Users.Add(new Users()
                {
                    Username = "jameson",
                    User_Email = "jameson@gmail.com",
                    Password = "password",
                    User_FName = "Jameson",
                    User_LName = "Arsenault",
                    User_Address = "1234 New Street",
                    User_City = "Providence",
                    User_State = "Rhode Island",
                    User_Zip = "02906",
                });


            }
        }
    }
}