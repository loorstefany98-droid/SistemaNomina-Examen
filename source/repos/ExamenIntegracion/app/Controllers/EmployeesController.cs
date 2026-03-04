using app.Data;
using app.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace app.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }

        
        public async Task<IActionResult> Index()
        {
            var empleados = await _context.Employees.ToListAsync();
            return View(empleados);
        }

       
        public async Task<IActionResult> Details(int id)
        {
            var emp = await _context.Employees.FirstOrDefaultAsync(e => e.emp_no == id);
            if (emp == null) return NotFound();

            return View(emp);
        }

        
        public IActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(employees emp)
        {
            if (!ModelState.IsValid) return View(emp);

            _context.Employees.Add(emp);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

       
        public async Task<IActionResult> Edit(int id)
        {
            var emp = await _context.Employees.FirstOrDefaultAsync(e => e.emp_no == id);
            if (emp == null) return NotFound();

            return View(emp);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, employees emp)
        {
            if (id != emp.emp_no) return NotFound();
            if (!ModelState.IsValid) return View(emp);

            _context.Update(emp);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        
        public async Task<IActionResult> Delete(int id)
        {
            var emp = await _context.Employees.FirstOrDefaultAsync(e => e.emp_no == id);
            if (emp == null) return NotFound();

            return View(emp);
        }

       
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var emp = await _context.Employees.FirstOrDefaultAsync(e => e.emp_no == id);

            if (emp != null)
            {
                _context.Employees.Remove(emp);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult EmpleadosLista()
        {
            return View();
        }

        public IActionResult EmpleadosFormulario()
        {
            return View();
        }
    }
}