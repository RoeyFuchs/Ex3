﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Ex3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("display", "display/{ip}/{port}/{interval}",
                defaults: new { controller = "Info", action = "display", interval="0"});


            routes.MapRoute("save", "save/{ip}/{port}/{interval}/{samplingTime}/{fileName}",
               defaults: new { controller = "Info", action = "save" });
              
            routes.MapRoute("index", "", 
                defaults: new {controller= "info", action = "index"});

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Info", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
