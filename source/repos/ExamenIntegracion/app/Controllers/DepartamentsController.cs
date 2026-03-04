using Microsoft.AspNetCore.Mvc;

namespace app.Controllers
{
    public class DepartamentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult DepartamentosLista()
        {
            return View();
        }
        public IActionResult DepartamentosFormulario()
        {
            return View();
        }
        public IActionResult AsignacionaDepartamento()
        {
            return View();
        }
        public IActionResult GerentedeDepartamento()
        {
            return View();
        }
        // GET: DepartamentsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartamentsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }

        }
    }
}



