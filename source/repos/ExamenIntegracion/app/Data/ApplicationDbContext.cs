using Microsoft.EntityFrameworkCore;
using app.Models;

namespace app.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Aquí registramos el modelo que hizo Evelyn
        public DbSet<Employees> Employees { get; set; }
    }
}
