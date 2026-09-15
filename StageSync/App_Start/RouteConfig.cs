using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace StageSync
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Modules", action = "HomePage", id = UrlParameter.Optional }
            );
        }
    }
}
