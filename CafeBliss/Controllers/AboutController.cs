using Microsoft.AspNetCore.Mvc;

namespace CafeBliss.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}
