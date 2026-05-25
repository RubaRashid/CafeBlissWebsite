using CafeBliss.Models;
using Microsoft.AspNetCore.Mvc;

namespace CafeBliss.Controllers
{
    public class LoginController : Controller
    {
        //[HttpGet]
        //public IActionResult Login()
        //{
        //    return View();
        //}

        // Login Form Submit

        //[HttpPost]
        //public IActionResult Login(LoginModel user)
        //{
        //    string email = Request.Form["Email"].ToString();
        //    string pass = Request.Form["Password"].ToString();

        //    if (email == "admin@gmail.com" &&
        //       pass == "123")
        //    {
        //        return RedirectToAction("Menu", "Menu");

        //    }
        //    ViewBag.Message = "Email: " + user.Email + " | Pass: " + user.Password;
        //    return View();
        //}





        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Login")]  // ← yeh add karo
        public IActionResult LoginPost()
        {
            string email = Request.Form["Email"].ToString();
            string pass = Request.Form["Password"].ToString();

            if (email == "admin@gmail.com" && pass == "123")
            {
                return RedirectToAction("Menu", "Menu");
            }

            ViewBag.Message = "Invalid Email or Password";
            return View();
        }

    }
}
