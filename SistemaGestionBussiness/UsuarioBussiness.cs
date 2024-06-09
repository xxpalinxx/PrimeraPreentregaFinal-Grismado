using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBussiness
{
    public class UsuarioBussiness
    {
        public int Id { get; set; }
        public static List<Usuario> GetUsuario()
        {
            return UsuarioData.GetUsuario();
        }
    }
}
