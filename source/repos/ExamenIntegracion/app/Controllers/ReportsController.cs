using Microsoft.AspNetCore.Mvc;

namespace app.Controllers
{
    public class ReportsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Reportes()
        {
            return View();
        }
        
}
    }

