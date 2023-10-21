using BugCatProducto.Models;

namespace BugCatProducto.CategoryRepository
{
   public interface ICategoriaRepository
   {
      public Task<IEnumerable<Categoria>> BuscarCategoria();
      public Task<Categoria> BuscarCategoriaPorId(int id);
      public Task<Categoria> CrearCategoria(Categoria categoria);
      public Task<Categoria> ActualizarCategoria(Categoria categoria);
      public Task<bool> EliminarCategoria(int id);
   }
}
