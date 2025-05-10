using Microsoft.EntityFrameworkCore;
using RedVial_Arboles.Models;

namespace RedVial_Arboles.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Interseccion> Intersecciones { get; set; }
        public DbSet<Via> Vias { get; set; }
        public DbSet<Ruta> Rutas { get; set; }
    }
}
