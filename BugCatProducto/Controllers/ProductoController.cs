using BugCatProducto.Models;
using BugCatProducto.ProductoRepository;
using Microsoft.AspNetCore.Mvc;

namespace BugCatProducto.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ProductoController :ControllerBase
    {
        private readonly IProductoRepository proRepository;
        public ProductoController(IProductoRepository proRepository)
        {
            this.proRepository = proRepository;
        }
        [HttpGet]
        [Route("/BuscarProducto")]
        public async Task<IEnumerable<Producto>> BuscarProducto()
        {
            return await proRepository.BuscarProducto();
        }

        [HttpGet]
        [Route("/BuscarProductoPorId/{id:int}")]
        public async Task<Producto> BuscarProductoPorId(int id)
        {
            return await proRepository.BuscarProductoPorId(id);
        }
        [HttpPost]
        [Route("/CrearProducto")]
        public async Task<Producto> CrearProducto(Producto producto)
        {
            return await proRepository.CrearProducto(producto);
        }

        [HttpPut]
        [Route("/ActualizarProducto")]
        public async Task<Producto> ActualizarProducto(Producto producto)
        {
            return await proRepository.ActualizarProducto(producto);
        }
        [HttpDelete]
        [Route("/EliminarProducto/{id:int}")]
        public async Task<bool> EliminarProducto(int id)
        {
            return await proRepository.EliminarProducto(id);
        }

    }
}
