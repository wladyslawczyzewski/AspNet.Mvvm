using System.IO;
using System.Web.Mvc;

namespace AspNet.Mvvm
{
    public class MvvmController : Controller
    {
        new public FileResult View(string viewName)
        {
            if (!viewName.EndsWith(".html"))
            {
                viewName += ".html";
            }

            return File(Path.Combine(Server.MapPath("~/Views/"), viewName), "text/html");
        }
    }
}
