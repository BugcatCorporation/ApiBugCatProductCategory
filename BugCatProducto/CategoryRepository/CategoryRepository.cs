using BugCatProducto.DbContexts;
using BugCatProducto.Models;
using Microsoft.EntityFrameworkCore;

namespace BugCatProducto.CategoryRepository
{
   public class CategoryRepository : ICategoriaRepository
   {
      private readonly AppDbContext _context;
      public CategoryRepository(AppDbContext context)
      {
         _context = context;
      }
      public async Task<IEnumerable<Categoria>> BuscarCategoria()
      {
         return await _context.Categorias.ToListAsync();
      }
      public async Task<Categoria> BuscarCategoriaPorId(int id)
      {
         return await _context.Categorias.FirstOrDefaultAsync(c => c.CategoriaId == id);
      }
      public async Task<Categoria> CrearCategoria(Categoria categoria)
      {
         _context.Categorias.Add(categoria);
         await _context.SaveChangesAsync();
         return categoria;
      }
      public async Task<Categoria> ActualizarCategoria(Categoria categoria)
      {
         _context.Categorias.Update(categoria);
         await _context.SaveChangesAsync();
         return categoria;
      }
      public async Task<bool> EliminarCategoria(int id)
      {
         var categoria = await _context.Categorias.FindAsync(id);
         if (categoria == null)
         {
            return false;
         }
         _context.Categorias.Remove(categoria);
         await _context.SaveChangesAsync();
         return true;
      }
   }
}
