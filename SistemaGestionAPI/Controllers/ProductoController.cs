using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpGet(Name = "GetProducto")]
        public IEnumerable<Producto> GetProducto()
        {
            return ProductoBussiness.GetProducto().ToArray();
        }

        [HttpGet("{id}")]
        public IActionResult GetProductoById(int id)
        {
            Producto producto = ProductoBussiness.GetProductoByID(id);
            return Ok(producto);
        }

        [HttpDelete(Name = "DeleteProducto")]
        public void Delete([FromBody]int id)
        {
            ProductoBussiness.DeleteProducto(id);
        }

        [HttpPut(Name = "ModificarProducto")]
        public void Put([FromBody]Producto producto)
        {
            ProductoBussiness.UpdateProducto(producto);
        }

        [HttpPost(Name = "AltaProducto")]
        public void Post([FromBody] Producto producto)
        {
            ProductoBussiness.CreateProducto(producto);
        }
    }
}
