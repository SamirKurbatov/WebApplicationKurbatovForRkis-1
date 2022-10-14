using Microsoft.AspNetCore.Mvc;

namespace WebApplicationKurbatov.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "This is my defaul action...";
        }

        public string Welcome()
        {
            return "This is the welcome action method...";
        }
    }
}
