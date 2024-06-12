using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet(Name = "GetUsuario")]
        public IEnumerable<Usuario> GetUsuario()
        {
            return UsuarioBussiness.GetUsuario().ToArray();
        }

        [HttpGet("{id}")]
        public IActionResult GetUsuarioById(int id)
        {
            Usuario usuario = UsuarioBussiness.GetUsuarioByID(id);
            return Ok(usuario);
        }

        [HttpDelete(Name = "DeleteUsuario")]
        public void Delete([FromBody] int id)
        {
            UsuarioBussiness.DeleteUsuario(id);
        }

        [HttpPut(Name = "ModificarUsuario")]
        public void Put([FromBody] Usuario usuario)
        {
            UsuarioBussiness.UpdateUsuario(usuario);
        }

        [HttpPost(Name = "AltaUsuario")]
        public void Post([FromBody] Usuario usuario)
        {
            UsuarioBussiness.CreateUsuario(usuario);
        }
    }
}
