using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using UrlsAndroutes.Infrastructure;

namespace UrlsAndroutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes) {

             
             routes.RouteExistingFiles = true;

             routes.MapRoute("DiskFile", "Content/StaticContent.html",
                 new
                 {
                     controller = "Customer",
                     action = "List",
                 });
            
            routes.MapRoute("ChromeRoute", "{*catchall}",
                new { controller = "Home", action = "Index" },
                new
                {
                    customConstraint = new UserAgentConstraint("Chrome")
                },
                new[] {
                    "UrlsAndRoutes.AdditionalControllers" 
                });

            routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{*catchall}",
            new
            {
                controller = "Home",
                action = "Index",
                id = UrlParameter.Optional
            },
            new[] { "URLsAndRoutes.Controllers" });


            /*
            Route myRoute = new Route("{controller}/{action}", new MvcRouteHandler());
            routes.Add("MyRoute", myRoute);
            
            routes.MapRoute("ShopSchema2", "Shop/OldAction",
                new { controller = "Home", action = "Index" });

            routes.MapRoute("ShopSchema", "Shop/{action}",
                new { controller = "Home" });

            routes.MapRoute("", "X{controller}/{action}");

            routes.MapRoute("MyRoute", "{controller}/{action}",
                new { controller = "Home", action = "Index" });

            routes.MapRoute("", "Public/{controller}/{action}",
                new { controller = "Home", action = "Index" });
            */


            
        }
    }
}