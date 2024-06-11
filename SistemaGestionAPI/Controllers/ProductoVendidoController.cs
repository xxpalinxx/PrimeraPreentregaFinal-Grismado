using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {
        [HttpGet(Name = "GetProductoVendido")]
        public IEnumerable<ProductoVendido> GetProductoVendido()
        {
            return ProductoVendidoBussiness.GetProductoVendido().ToArray();
        }

        [HttpGet("{id}")]
        public IActionResult GetProductoVendidoById(int id)
        {
            ProductoVendido productoVendido = ProductoVendidoBussiness.GetProductoVendidoByID(id);
            return Ok(productoVendido);
        }

        [HttpDelete(Name = "DeleteProductoVendido")]
        public void Delete([FromBody] int id)
        {
            ProductoVendidoBussiness.DeleteProductoVendido(id);
        }

        [HttpPut(Name = "ModificarProductoVendido")]
        public void Put([FromBody] ProductoVendido productoVendido)
        {
            ProductoVendidoBussiness.UpdateProductoVendido(productoVendido);
        }

        [HttpPost(Name = "AltaProductoVendido")]
        public void Post([FromBody] ProductoVendido productoVendido)
        {
            ProductoVendidoBussiness.CreateProductoVendido(productoVendido);
        }
    }
}
