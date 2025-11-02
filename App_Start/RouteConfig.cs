using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RastislavRuzbackyMojeCVmvc
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("vzdelanie", "vzdelanie", new { controller = "Home", action = "Vzdelanie" });
            routes.MapRoute("osobne-udaje", "osobne-udaje", new { controller = "Home", action = "OsobneUdaje" });
            routes.MapRoute("kontakt", "kontakt", new { controller = "Home", action = "Kontakt" });
            routes.MapRoute("odoslanie-spravy", "odoslanie-spravy", new { controller = "Home", action = "OdoslanieSpravy" });
            

            routes.MapRoute(
                name: "pacienti",
                url: "pacienti",
                defaults: new { controller = "Pacient", action = "Index" }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Uvod", id = UrlParameter.Optional }
            );
        }
    }
}
