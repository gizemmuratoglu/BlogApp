using System.Web.Mvc;
using System.Web.Routing;

namespace BlogApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}/{title}",
                defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional, title = UrlParameter.Optional }
            );
        }
    }
}
