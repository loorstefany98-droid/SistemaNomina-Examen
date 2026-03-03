using Microsoft.AspNetCore.Mvc;

namespace app.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        { 
            
            return View();
            
        }

        public IActionResult Registro()
        {
            
            return View();

        }
        // POST
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "1234")
            {
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Usuario o contraseña incorrectos";
            return View();
        }
    }
}
