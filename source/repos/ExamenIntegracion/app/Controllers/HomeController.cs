using app.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace app.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Dashboard()

        {
            var usuario = HttpContext.Session.GetString("Usuario");

            if (usuario == null)
            {
                return RedirectToAction("Index", "Login");
            }

            ViewBag.Usuario = "Rocío"; // luego aquí irá el usuario logueado
            ViewBag.TotalEmpleados = 25;
            ViewBag.TotalNomina = 18500;
            ViewBag.Reportes = 3;
            return View();
        }
       

    }
}
