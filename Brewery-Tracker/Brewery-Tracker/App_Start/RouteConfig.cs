using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Brewery_Tracker
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Contact", "Contact", new { controller = "Home", action = "Contact" });

            routes.MapRoute("About", "About", new { controller = "Home", action = "About" });

            routes.MapRoute("Signup", "Signup", new { controller = "Home", action = "Signup" });

            routes.MapRoute("Login", "Login", new { controller = "Home", action = "Login" });

            routes.MapRoute("Breweries", "Breweries", new { controller = "Home", action = "Breweries", id = UrlParameter.Optional });

            routes.MapRoute("Beers", "Beers", new { controller = "Home", action = "Beers", id = UrlParameter.Optional });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
