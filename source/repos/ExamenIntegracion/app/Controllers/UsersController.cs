using Microsoft.AspNetCore.Mvc;

namespace app.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Usuarios()
        {
            return View();
        }
    }

}

