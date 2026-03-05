using Microsoft.AspNetCore.Mvc;
using app.Data;
using app.Models;
using app.ViewModels;
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

        
        public IActionResult DepartamentosLista()
        {
            var lista = _context.Departments.OrderBy(d => d.dept_no).ToList();
            return View(lista); 
        }

        
        [HttpGet]
        public IActionResult Create()
        {
            return View(); 
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Departments model)
        {
            if (string.IsNullOrWhiteSpace(model.dept_name))
            {
                ModelState.AddModelError("dept_name", "El nombre es obligatorio.");
                return View(model);
            }

            if (_context.Departments.Any(d => d.dept_name == model.dept_name))
            {
                ModelState.AddModelError("dept_name", "Ese departamento ya existe.");
                return View(model);
            }

            _context.Departments.Add(model); 
            _context.SaveChanges();

            return RedirectToAction(nameof(DepartamentosLista));
        }

        
        public IActionResult GerentedeDepartamento()
        {
            var lista = (from dm in _context.DeptManagers
                         join d in _context.Departments on dm.dept_no equals d.dept_no
                         join e in _context.Employees on dm.emp_no equals e.emp_no
                         orderby d.dept_no
                         select new GerenteRowVM
                         {
                             dept_no = d.dept_no,
                             dept_name = d.dept_name,
                             emp_no = e.emp_no,
                             gerente = e.first_name + " " + e.last_name,
                             from_date = dm.from_date,
                             to_date = dm.to_date
                         }).ToList();

            return View(lista); 
        }

        
        public IActionResult AsignacionDepartamento()
        {
            var lista = (from de in _context.DeptEmps
                         join d in _context.Departments on de.dept_no equals d.dept_no
                         join e in _context.Employees on de.emp_no equals e.emp_no
                         orderby d.dept_no
                         select new AsignacionRowVM
                         {
                             dept_no = d.dept_no,
                             dept_name = d.dept_name,
                             emp_no = e.emp_no,
                             empleado = e.first_name + " " + e.last_name,
                             from_date = de.from_date,
                             to_date = de.to_date
                         }).ToList();

            return View(lista); 
        }

        
        public IActionResult DepartamentosFormulario()
        {
            return View(); 
        }
    }
}