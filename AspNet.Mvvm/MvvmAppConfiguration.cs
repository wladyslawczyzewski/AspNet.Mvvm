using System.Web.Routing;
using System.Web.Mvc;
using System;

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
            }
        }
        #endregion

        #region Constructors
        internal MvvmAppConfiguration(RouteCollection routes)
        {
            this.routes = routes;
        }
        #endregion

        #region Public Methods
        public void MapRoute(string templateUrl, string controllerName)
        {
            if (routes == null)
            {
                throw new NullReferenceException();
            }

            routes.MapRoute(
                name: controllerName,
                url: templateUrl.TrimStart(new[] { '/' }),
                defaults: new { controller = controllerName, action = "Get" },
                constraints: new { httpMethod = new HttpMethodConstraint("GET") }
            );

            routes.MapRoute(
                name: controllerName,
                url: templateUrl.TrimStart(new[] { '/' }),
                defaults: new { controller = controllerName, action = "Post" },
                constraints: new { httpMethod = new HttpMethodConstraint("POST") }
            );
        }
        #endregion
    }
}
