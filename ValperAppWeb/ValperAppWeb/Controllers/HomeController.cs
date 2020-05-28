using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ValperAppWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Funciones()
        {
            return View();
        }

        public class Funcion
        {
            public string idFuncion { get; set; }
            public string Descripcion { get; set; }
        }

        public ActionResult FuncionesConexiones()
        {
            return View();
        }

        public class FuncionConexion
        {
            public string idFuncion { get; set; }
            public string idConexion { get; set; }
        }

        public ActionResult FuncionesParametros()
        {
            return View();
        }

        public class FuncionParametro
        {
            public string idFuncion { get; set; }
            public string idParametro { get; set; }
        }

        public ActionResult Parametros()
        {
            return View();
        }

        public class Parametro
        {
            public string idParametro { get; set; }
            public string Descripcion { get; set; }
            public string Orden { get; set; }
            public string idTipo { get; set; }
            public string idFuncion { get; set; }
        }

        public ActionResult Tipos()
        {
            return View();
        }

        public class Tipo
        {
            public string idTipo { get; set; }
            public string Descripcion { get; set; }
            public string tipoBasico { get; set; }
        }
        
        public ActionResult Conexiones()
        {
            return View();
        }

        public class Conexion
        {
            public string idConexion { get; set; }
            public string Descripcion { get; set; }
            public string Conector { get; set; }
        }

        public ActionResult UsuariosConexiones()
        {
            return View();
        }

        public class UsuarioConexion
        {
            public string idUsuario { get; set; }
            public string idConexion { get; set; }
        }

        public ActionResult Usuarios()
        {
            return View();
        }

        public class Usuario
        {
            public string idUsuario { get; set; }
            public string Nombre { get; set; }

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}