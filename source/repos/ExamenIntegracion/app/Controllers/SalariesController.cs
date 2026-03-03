using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace app.Controllers
{
    public class SalariesController : Controller
    {
        // GET: SalariosController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: SalariosController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SalariosController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SalariosController1/Create
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

        // GET: SalariosController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SalariosController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: SalariosController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SalariosController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            { }
                return View();
            }
            

        public IActionResult Salarios()
        {
            return View();
        }
        public IActionResult AuditoriadeSalarios()
        {
            return View();
        }
    } }

