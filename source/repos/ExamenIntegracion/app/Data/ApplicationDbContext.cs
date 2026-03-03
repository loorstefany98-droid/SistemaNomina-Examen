using Microsoft.EntityFrameworkCore;

using app.Models;

namespace app.Data

{

    public class ApplicationDbContext : DbContext

    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)

            : base(options) { }

        // Bryan debe tener estas 8 líneas para que el sistema vea todas las tablas:

        public DbSet<employees> Employees { get; set; }

        public DbSet<Departments> Departments { get; set; }

        public DbSet<dept_emp> DeptEmps { get; set; }

        public DbSet<dept_manager> DeptManagers { get; set; }

        public DbSet<salaries> Salaries { get; set; }

        public DbSet<titles> Titles { get; set; }

        public DbSet<users> Users { get; set; }

        public DbSet<log_AuditoriaSalarios> LogAuditoriaSalarios { get; set; }

    }

}
