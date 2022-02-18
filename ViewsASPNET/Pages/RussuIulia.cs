using Microsoft.AspNetCore.Mvc;

namespace ViewsASPNET.Pages
{
    public class RussuIulia : Controller
    {
        public IActionResult Index()
        {
            return View("RussuIulia");
        }
    }
}
