using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public interface IRepositoryTelefono
    {
        IEnumerable<test_Telefono> GetTelefonoByIdUsuario(string cedula);
        test_Telefono CreateTelefono(test_Telefono telefono);

        test_Telefono UpdateTelefono(test_Telefono telefono);
    }
}
