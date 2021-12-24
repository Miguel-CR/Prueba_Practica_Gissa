using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
  public  interface IServiceTelefono
    {
        IEnumerable<test_Telefono> GetTelefonoioByIdUsuario(string cedula);
    }
}
