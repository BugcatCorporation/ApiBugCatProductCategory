using BugCatProducto.CategoryRepository;
using BugCatProducto.Models;
using Microsoft.AspNetCore.Mvc;

namespace BugCatProducto.Controllers
{
   [ApiController]
   [Route("api/v1/[controller]")]
   public class CategoriaController: ControllerBase
   {
      private readonly ICategoriaRepository catRepository;
      public CategoriaController(ICategoriaRepository catRepository)
      {
         this.catRepository = catRepository;
      }
      [HttpGet]
      [Route("/BuscarCategoria")]
      public async Task<IEnumerable<Categoria>> BuscarCategoria()
      {
         return await catRepository.BuscarCategoria();
      }
      [HttpGet]
      [Route("/BuscarCategoriaPorId/{id:int}")]
      public async Task<Categoria> BuscarCategoriaPorId(int id)
      {
         return await catRepository.BuscarCategoriaPorId(id);
      }
      [HttpPost]
      [Route("/CrearCategoria")]
      public async Task<Categoria> CrearCategoria(Categoria categoria)
      {
         return await catRepository.CrearCategoria(categoria);
      }
      [HttpPut]
      [Route("/ActualizarCategoria")]
      public async Task<Categoria> ActualizarCategoria(Categoria categoria)
      {
         return await catRepository.ActualizarCategoria(categoria);
      }
      [HttpDelete]
      [Route("/EliminarCategoria/{id:int}")]
      public async Task<bool> EliminarCategoria(int id)
      {
         return await catRepository.EliminarCategoria(id);
      }
   }
}
