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
        public test_Telefono CreateTelefono(test_Telefono telefono)
        {
            try
            {
                int retorno = 0;
                test_Telefono t = null;
                IEnumerable<test_Telefono> listTelefonos = null;
                using (MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                        ctx.test_PhoneCreate(telefono.UsuarioCedula,telefono.Telefono);
                        retorno = ctx.SaveChanges();
                  
                     if (retorno >= 0)
                {
                       //t= ctx.test_PhoneReadByTelefono(telefono.Telefono);
                    return t;
                }

                }

               
               
                    
                return t;

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

        public IEnumerable<test_Telefono> GetTelefonoByIdUsuario(string cedula)
        {
            try
            {
                IEnumerable<test_Telefono> listaTelefonos = null;
                using (MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                    listaTelefonos = ctx.test_PhoneReadByUserId(cedula).ToList<test_Telefono>();
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

        public test_Telefono UpdateTelefono(test_Telefono telefono)
        {
            throw new NotImplementedException();
        }
    }
}
