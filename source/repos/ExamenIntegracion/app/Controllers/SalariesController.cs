using app.Data;
using app.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace app.Controllers
{
    public class SalariesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SalariesController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(); // Views/Salaries/Index.cshtml
        }

        [HttpGet]
        public IActionResult Calcular()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Calcular(int emp_no, long salary, string DetalleCambio)
        {
            
            bool existe = await _context.Employees.AnyAsync(e => e.emp_no == emp_no);
            if (!existe)
            {
                ModelState.AddModelError("", "El empleado no existe.");
                return View();
            }

            if (salary <= 0)
            {
                ModelState.AddModelError("", "El salario debe ser mayor a 0.");
                return View();
            }

           
            string fromDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            
            var nuevoSalario = new salaries
            {
                emp_no = emp_no,
                salary = salary,
                from_date = fromDate,
                to_date = null
            };
            _context.Salaries.Add(nuevoSalario);

            
            string usuario = HttpContext.Session.GetString("usuario") ?? "admin";

            
            var log = new log_AuditoriaSalarios
            {
                usuario = usuario,
                
                fechaActualiz = DateTime.Today,
                DetalleCambio = string.IsNullOrWhiteSpace(DetalleCambio) ? "Actualización de salario" : DetalleCambio,
                salario = salary,
                emp_no = emp_no
            };
            _context.LogAuditoriaSalarios.Add(log);

           
            await _context.SaveChangesAsync();

            
            return RedirectToAction(nameof(AuditoriadeSalarios));
        }

        
        [HttpGet]
        public async Task<IActionResult> AuditoriadeSalarios()
        {
            var lista = await _context.LogAuditoriaSalarios
                .OrderByDescending(x => x.fechaActualiz)
                .ThenByDescending(x => x.id)
                .ToListAsync();

            return View(lista);
        }


        [HttpGet]
        public IActionResult Salarios()
        {
            return View();
        }
    }
}

