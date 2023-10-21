using BugCatProducto.Models;

namespace BugCatProducto.ProductoRepository
{
    public interface IProductoRepository 
    {
        public Task<IEnumerable<Producto>> BuscarProducto();
        public Task<Producto> BuscarProductoPorId(int id);
        public Task<Producto> CrearProducto(Producto producto);
        public Task<Producto> ActualizarProducto(Producto producto);
        public Task<bool> EliminarProducto(int id);
    }
}
