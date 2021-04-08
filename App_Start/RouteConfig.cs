﻿using System.Web.Mvc;
using System.Web.Routing;

namespace BTL_Mvc
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "Auth",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Auth", action = "Login", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "Admin",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Admin", action = "Index", id = UrlParameter.Optional }
           );
        }
    }
}
