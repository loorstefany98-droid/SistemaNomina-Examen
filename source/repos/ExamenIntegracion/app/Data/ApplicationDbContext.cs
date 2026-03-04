using Microsoft.EntityFrameworkCore;
using app.Models;

namespace app.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<employees> Employees { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<dept_emp> DeptEmps { get; set; }
        public DbSet<dept_manager> DeptManagers { get; set; }
        public DbSet<salaries> Salaries { get; set; }
        public DbSet<titles> Titles { get; set; }
        public DbSet<users> Users { get; set; }
        public DbSet<log_AuditoriaSalarios> LogAuditoriaSalarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<employees>().ToTable("employees");
            modelBuilder.Entity<Departments>().ToTable("departments");
            modelBuilder.Entity<dept_emp>().ToTable("dept_emp");
            modelBuilder.Entity<dept_manager>().ToTable("dept_manager");
            modelBuilder.Entity<salaries>().ToTable("salaries");
            modelBuilder.Entity<titles>().ToTable("titles");
            modelBuilder.Entity<users>().ToTable("users");
            modelBuilder.Entity<log_AuditoriaSalarios>().ToTable("log_AuditoriaSalarios");

            modelBuilder.Entity<employees>().HasKey(e => e.emp_no);
            modelBuilder.Entity<Departments>().HasKey(d => d.dept_no);
            modelBuilder.Entity<users>().HasKey(u => u.emp_no);
            modelBuilder.Entity<log_AuditoriaSalarios>().HasKey(l => l.id);

            modelBuilder.Entity<dept_emp>().HasKey(x => new { x.emp_no, x.dept_no });
            modelBuilder.Entity<dept_manager>().HasKey(x => new { x.emp_no, x.dept_no });
            modelBuilder.Entity<salaries>().HasKey(x => new { x.emp_no, x.from_date });
            modelBuilder.Entity<titles>().HasKey(x => new { x.emp_no, x.title, x.from_date });
        }
    }
}
