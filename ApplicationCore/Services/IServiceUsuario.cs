using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
   public interface IServiceUsuario
    {

        IEnumerable<test_Usuario> GetUsuarios();

        test_Usuario GetUsuarioById(string cedula);

        test_Usuario CreateUsuario(test_Usuario usuario, string[] telefonos, int[] idHabilidades);

        test_Usuario UpdateUsuario(test_Usuario usuario);

        void DeleteUsuarioById(string cedula);
    }
}
