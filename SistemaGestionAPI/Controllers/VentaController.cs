using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        [HttpGet(Name = "GetVenta")]
        public IEnumerable<Venta> GetVenta()
        {
            return VentaBussiness.GetVenta().ToArray();
        }

        [HttpGet("{id}")]
        public IActionResult GetProductoById(int id)
        {
            Venta venta = VentaBussiness.GetVentaByID(id);
            return Ok(venta);
        }

        [HttpDelete(Name = "DeleteVenta")]
        public void Delete([FromBody] int id)
        {
            VentaBussiness.DeleteVenta(id);
        }

        [HttpPut(Name = "ModificarVenta")]
        public void Put([FromBody]Venta venta)
        {
            VentaBussiness.UpdateVenta(venta);
        }

        [HttpPost(Name = "AltaVenta")]
        public void Post([FromBody] Venta venta)
        {
            VentaBussiness.CreateVenta(venta);
        }
    }
}
