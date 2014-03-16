using System.Web.Mvc;
using System.Web.Routing;

namespace AspNet.Mvvm
{
    /// <summary>
    /// Setup initial configuration for ASP.NET MVVM application
    /// </summary>
    public class MvvmAppConfiguration
    {
        #region Fields
        private RouteCollection routes;
        #endregion

        #region Properties
        public RouteCollection Routes
        {
            get
            {
                return routes;
            }
            set
            {
                routes = value;

                MapDefaultRoutes();
            }
        }
        #endregion

        #region Constructors
        internal MvvmAppConfiguration(RouteCollection routes)
        {
            this.routes = routes;
        }
        #endregion

        #region Private Methods
        private void MapDefaultRoutes()
        {
            routes.MapRoute(
                name: "MvvmDefault",
                url: "",
                defaults: new { controller = "Mvvm", action = "View", viewName = "index" },
                constraints: new { httpMethod = new HttpMethodConstraint("GET") }
            );

            routes.MapRoute(
                name: "MvvmView",
                url: "view/{viewName}",
                defaults: new { controller = "Mvvm", action = "View", viewName = UrlParameter.Optional },
                constraints: new { httpMethod = new HttpMethodConstraint("GET") }
            );

            routes.MapRoute(
                name: "MvvmControllerGet",
                url: "{controller}/{action}",
                defaults: new { controller = "Mvvm", action = "Get" },
                constraints: new { httpMethod = new HttpMethodConstraint("GET") }
            );

            routes.MapRoute(
                name: "MvvmControllerPost",
                url: "{controller}/{action}",
                defaults: new { controller = "Mvvm", action = "Post" },
                constraints: new { httpMethod = new HttpMethodConstraint("POST") }
            );
        }
        #endregion
    }
}
