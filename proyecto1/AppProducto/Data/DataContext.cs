using Microsoft.EntityFrameworkCore;
using AppProducto.Models;

namespace AppProducto.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<Producto> Productos { get; set; }
    }
}