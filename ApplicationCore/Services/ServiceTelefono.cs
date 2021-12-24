using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ServiceTelefono : IServiceTelefono
    {
        public IEnumerable<test_Telefono> GetTelefonoioByIdUsuario(string cedula)
        {
            IRepositoryo repository = new RepositoryUsuario();
            return repository.GetUsuarios();
        }
    }
}
