using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcShapes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Circle",
                url: "{controller}/{action}/{radius}"
            );
            routes.MapRoute(
                name: "Square",
                url: "{controller}/{action}/{length}"
            );
            routes.MapRoute(
                name: "Rectangle",
                url: "{controller}/{action}/{width}/{height}"
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
