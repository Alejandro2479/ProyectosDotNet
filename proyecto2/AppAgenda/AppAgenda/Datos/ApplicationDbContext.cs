using AppAgenda.Models;
using Microsoft.EntityFrameworkCore;

namespace AppAgenda.Datos
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<Contacto> Contactos { get; set; }
    }
}
