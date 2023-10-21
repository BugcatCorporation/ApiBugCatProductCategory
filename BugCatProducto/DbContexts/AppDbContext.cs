using BugCatProducto.Models;
using Microsoft.EntityFrameworkCore;

namespace BugCatProducto.DbContexts
{
   public class AppDbContext : DbContext
   {
      public AppDbContext()
      {

      }
      public AppDbContext(DbContextOptions options) : base(options)
      {

      }
      public DbSet<Producto> Productos { get; set; }
      public DbSet<Categoria> Categorias { get; set; }
   }
}
