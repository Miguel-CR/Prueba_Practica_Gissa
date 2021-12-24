using Infraestructure.Models;
using Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ServiceTelefono : IServiceTelefono
    {
        public test_Telefono CreateTelefono(test_Telefono telefono)
        {
            IRepositoryTelefono repository = new RepositoryTelefono();

            return repository.CreateTelefono(telefono);
        }

        public IEnumerable<test_Telefono> GetTelefonoByIdUsuario(string cedula)
        {
            IRepositoryTelefono repository = new RepositoryTelefono();
            return repository.GetTelefonoByIdUsuario(cedula);
        }

        public test_Telefono UpdateTelefono(test_Telefono telefono)
        {
            IRepositoryTelefono repository = new RepositoryTelefono();
            return repository.UpdateTelefono(telefono);
        }
    }
}
