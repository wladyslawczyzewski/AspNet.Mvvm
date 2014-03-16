using System.Web.Mvc;
using System.Web.Routing;

namespace AspNet.Mvvm.Example
{
    public class MvcApplication : AspNet.Mvvm.MvvmApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            Configuraiton.Routes = RouteTable.Routes;
        }
    }
}
