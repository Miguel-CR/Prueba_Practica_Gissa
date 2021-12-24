using ApplicationCore.Utils;
using Infraestructure.Models;
using Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
   public class ServiceUsuario : IServiceUsuario
    {
        public test_Usuario CreateUsuario(test_Usuario usuario, string[] telefonos, int[] idHabilidades)
        {
            IRepositoryUsuario repository = new RepositoryUsuario();
            usuario.Clave = Cryptography.EncrypthAES(usuario.Clave);
            return repository.CreateUsuario(usuario,telefonos,idHabilidades);
        }

        public void DeleteUsuarioById(string cedula)
        {
            IRepositoryUsuario repository = new RepositoryUsuario();
            repository.DeleteUsuarioById(cedula);
        }

        public test_Usuario GetUsuarioById(string cedula)
        {
            IRepositoryUsuario repository = new RepositoryUsuario();
            return repository.GetUsuarioById(cedula);
        }

        public IEnumerable<test_Usuario> GetUsuarios()
        {
            IRepositoryUsuario repository = new RepositoryUsuario();
            return repository.GetUsuarios();
        }

        public test_Usuario UpdateUsuario(test_Usuario usuario)
        {
            IRepositoryUsuario repository = new RepositoryUsuario();
            usuario.Clave = Cryptography.EncrypthAES(usuario.Clave);
            return repository.UpdateUsuario(usuario);
        }
    }
}
