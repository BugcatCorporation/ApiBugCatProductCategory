namespace BugCatProducto.Models
{
   public class Categoria
   {
      public int CategoriaId { get; set; }
      public string? nombre { get; set; }
      public List<Producto>? Producto { get; set; }
   }
}
