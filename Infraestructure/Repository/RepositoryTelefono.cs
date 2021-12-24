using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class RepositoryTelefono : IRepositoryTelefono
    {
        public IEnumerable<test_Telefono> GetTelefonoioByIdUsuario(string cedula)
        {
            try
            {
                IEnumerable<test_Telefono> listaTelefonos = null;
                using (MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                    listaTelefonos = ctx.test_PhoneRead(cedula).ToList<test_Telefono>();
                }
                return listaTelefonos;

            }
            catch (DbUpdateException dbEx)
            {
                string mensaje = "";
                throw new Exception(mensaje);
            }
            catch (Exception ex)
            {
                string mensaje = "";
                throw new Exception(mensaje);
            }
        }
    }
}
