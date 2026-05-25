using Microsoft.AspNetCore.Mvc;

namespace CafeBliss.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}
