using Microsoft.AspNetCore.Mvc;

namespace ViewsASPNET.Pages
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("w1841");
        }
    }
}
