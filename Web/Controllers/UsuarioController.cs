using ApplicationCore.Services;
using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            IEnumerable<test_Usuario> listaUsuarios = null;
            try
            {
                IServiceUsuario _ServiceRepartidor = new ServiceUsuario();
                listaUsuarios = _ServiceRepartidor.GetUsuarios();
                return View(listaUsuarios);

            }
            catch (Exception ex)
            {
                TempData["Message"] = "¡Error al procesar los datos!" + ex.Message;
                TempData.Keep();
                //Redirección a la pagina de error
                return RedirectToAction("Default", "Error");

            }
        }

        public ActionResult Details(string id)
        {
            test_Usuario u = null;
            IServiceUsuario _ServiceUsuario = new ServiceUsuario();
            try
            {
                u = _ServiceUsuario.GetUsuarioById(id);
                return View(u);
            }
            catch (Exception ex)
            {
                TempData["Message"] = "¡Error al procesar los datos!" + ex.Message;
                TempData["Redirect"] = "Usuario";
                TempData["Redirect-Action"] = "Index";
                return RedirectToAction("Default", "Error");

            }
        }
    }
}