using Microsoft.AspNetCore.Mvc;
using app.Data;
using app.Models;
using System.Linq;

namespace app.Controllers
{
    public class DepartamentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DepartamentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return RedirectToAction(nameof(DepartamentosLista));
        }

        // LISTA (SELECT)
        public IActionResult DepartamentosLista()
        {
            var lista = _context.Departments
                                .OrderBy(d => d.dept_no)
                                .ToList();

            return View(lista);
        }

        // GET CREATE
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST CREATE (INSERT)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Departments model)
        {
            if (string.IsNullOrWhiteSpace(model.dept_name))
            {
                ModelState.AddModelError("dept_name", "El nombre es obligatorio.");
                return View(model);
            }

            bool existe = _context.Departments.Any(d => d.dept_name == model.dept_name);
            if (existe)
            {
                ModelState.AddModelError("dept_name", "Ese departamento ya existe.");
                return View(model);
            }

            // dept_no NO se asigna porque es IDENTITY
            _context.Departments.Add(model);
            _context.SaveChanges();

            return RedirectToAction(nameof(DepartamentosLista));
        }

        public IActionResult DepartamentosFormulario() => View();
        public IActionResult AsignacionDepartamento() => View();
        public IActionResult GerentedeDepartamento() => View();
    }
}


