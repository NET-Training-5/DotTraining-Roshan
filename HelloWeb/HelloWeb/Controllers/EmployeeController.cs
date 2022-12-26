using Microsoft.AspNetCore.Mvc;

namespace HelloWeb.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Details()
        {
            return View();
        }
    }
}
