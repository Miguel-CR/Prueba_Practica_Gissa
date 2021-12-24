using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class RepositoryUsuario : IRepositoryUsuario
    {
        public test_Usuario CreateUsuario(test_Usuario usuario, string [] telefonos,int [] idHabilidades)
        {
            try
            {
                int retorno = 0;
                test_Usuario u = null;
                using (MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                    u = GetUsuarioById(usuario.Cedula);
                    if (u==null)
                    {
                        foreach (var telefno in telefonos)
                        {
                            
                        }
                    }
                    else
                    {

                    }
                    //Select  *  from Producto where ID==id es un innerjoin
                }
                return u;

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

        public void DeleteUsuarioById(string cedula)
        {
            try
            {
                using (MyContext ctx = new MyContext())
                {
                    ctx.test_UserDelete(cedula);
                }
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

        public test_Usuario GetUsuarioById(string cedula)
        {
            try
            {
                test_Usuario u = null;
                using (MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                    u = ctx.test_UserReadById1(cedula).FirstOrDefault();
                }
                return u;

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

        public IEnumerable<test_Usuario> GetUsuarios()
        {
            try
            {
                IEnumerable<test_Usuario> listaUsuarios = null;
                using (MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                    listaUsuarios = ctx.test_UserRead1().ToList<test_Usuario>();
                }
                return listaUsuarios;

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

        public test_Usuario UpdateUsuario(test_Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
