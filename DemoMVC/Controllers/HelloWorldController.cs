using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        //GET: /HelloW/
        public IActionResult Index()
        {
         return View();
        }
        //GET: /HelloW/Welcome/
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}