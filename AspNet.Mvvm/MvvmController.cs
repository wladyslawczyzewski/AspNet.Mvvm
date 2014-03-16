using System.Web.Mvc;

namespace AspNet.Mvvm
{
    public class MvvmController : Controller
    {
        [HttpGet]
        public virtual JsonResult Get(params object[] data)
        {
            return new JsonResult();
        }

        [HttpPost]
        public virtual JsonResult Post(params object[] data)
        {
            return new JsonResult();
        }
    }
}
