using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

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
                HttpContext.Session.SetString("Usuario", username);

                return RedirectToAction( "Dashboard","Home");
            }
            if (username == "Ale005" && password == "0000")
            {
                HttpContext.Session.SetString("Usuario", username);

                return RedirectToAction("Dashboard", "Home");
            }

            ViewBag.Error = "Usuario o contraseña incorrectos";
            return View("Index");
        }
    }
}
