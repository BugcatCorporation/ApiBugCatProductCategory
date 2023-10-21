using BugCatProducto.DbContexts;
using BugCatProducto.Models;
using Microsoft.EntityFrameworkCore;

namespace BugCatProducto.ProductoRepository
{
    public class ProductoRepository : IProductoRepository

    {
        private readonly AppDbContext bgcontext;

        public ProductoRepository(AppDbContext bgcontext)
        {
            this.bgcontext = bgcontext;
        }

        public async Task<Producto> ActualizarProducto(Producto producto)
        {
            bgcontext.Productos.Update(producto);
            await bgcontext.SaveChangesAsync();
            return producto;
        }

        public async Task<IEnumerable<Producto>> BuscarProducto()
        {
            return await bgcontext.Productos.ToListAsync();
        }

        public async Task<Producto> BuscarProductoPorId(int id)
        {
            var producto = await bgcontext.Productos.Where(c => c.ProductoId == id).FirstOrDefaultAsync();
            return producto;
        }

        public async Task<Producto> CrearProducto(Producto producto)
        {
            bgcontext.Productos.Add(producto);
            await bgcontext.SaveChangesAsync();
            return producto;
        }

        public async Task<bool> EliminarProducto(int id)
        {
            var producto= await bgcontext.Productos.FirstOrDefaultAsync(c => c.ProductoId == id);
            if (producto == null)
            {
                return false;
            }
            bgcontext.Productos.Remove(producto);
            await bgcontext.SaveChangesAsync();
            return true;
        }
    }
}
