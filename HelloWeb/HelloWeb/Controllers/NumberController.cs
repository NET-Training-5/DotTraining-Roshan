using Microsoft.AspNetCore.Mvc;

namespace HelloWeb.Controllers
{
    public class NumberController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Table()
        {
            return View();
        }

        public IActionResult MultiplicationTable(int n)
        {
            return View(n);
        }

     



    }
}
