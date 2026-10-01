using Microsoft.EntityFrameworkCore;
using Tienda.Dominio.Entidades;

namespace Tienda.Infraestructura.Persistencia
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected ApplicationDbContext()
        {

        }

        public DbSet<Producto> Productos { get; set; }

    }
}
