using Newtonsoft.Json;

namespace AspNet.Mvvm.Example.Controllers
{
    public class ExampleController : MvvmController
    {
        public string Get()
        {
            return JsonConvert.SerializeObject(new { id = 1, text = "Test" });
        }
    }
}
