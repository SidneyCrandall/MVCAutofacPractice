using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OdeToFood.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // ignore any path that matches * (anything)
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // A placeholder for any of the following parameters
            // /home/contact/1 = example. (map our url to a controller in our code)
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                // the ID is optional. So it doesnt have to be there to map the route
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
