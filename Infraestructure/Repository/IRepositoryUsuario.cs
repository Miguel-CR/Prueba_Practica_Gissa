using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infraestructure.Models;

namespace Infraestructure.Repository
{
   public  interface IRepositoryUsuario
    {
        IEnumerable<test_Usuario> GetUsuarios();

        test_Usuario GetUsuarioById(string cedula);

        test_Usuario CreateUsuario(test_Usuario usuario);

        test_Usuario UpdateUsuario(test_Usuario usuario);

        void DeleteUsuarioById(string cedula);

    }
}
