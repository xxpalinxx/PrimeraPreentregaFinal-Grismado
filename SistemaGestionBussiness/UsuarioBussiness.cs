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
        public static bool DeleteUsuario(int Id)
        {
            return UsuarioData.DeleteUser(Id);
        }

        public static bool CreateUsuario(Usuario usuario)
        {
            return UsuarioData.CreateUser(usuario);
        }

        public static bool UpdateUsuario(int Id, Usuario usuario)
        {
            return UsuarioData.UpdateUser(Id, usuario);
        }

        public static Usuario GetUsuarioByID(int Id)
        {
            return UsuarioData.GetUserByID(Id);
        }
    }
}
