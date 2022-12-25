using Microsoft.AspNetCore.Mvc;

namespace HelloWeb.Controllers
{
    public class NumberController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Greet()
        {
            return View();
        }
    }
}
