using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AplicaciónWebValper.Models;

namespace AplicaciónWebValper.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Funciones()
        {
            return View();
        }

        public class Funcion
            {
            public string idFuncion { get; set; }
            public string Descripcion { get; set; }
            }

        public IActionResult FuncionesConexiones()
        {
            return View();
        }

        public class FuncionConexion
        {
            public string idFuncion { get; set; }
            public string idConexion { get; set; }
        }

        public IActionResult FuncionesParametros()
        {
            return View();
        }

        public class FuncionParametro
        {
            public string idFuncion { get; set; }
            public string idParametro { get; set; }
        }

        public IActionResult Parametros()
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

        public IActionResult Tipos()
        {
            return View();
        }

        public class Tipo
        {
            public string idTipo { get; set; }
            public string Descripcion { get; set; }
            public string tipoBasico { get; set; }
        }

        public IActionResult Conexiones()
        {
            return View();
        }

        public class Conexion
        {
            public string idConexion { get; set; }
            public string Descripcion { get; set; }
            public string Conector { get; set; }
        }

        public IActionResult UsuariosConexiones()
        {
            return View();
        }

        public class UsuarioConexion
        {
            public string idUsuario { get; set; }
            public string idConexion { get; set; }
        }

        public IActionResult Usuarios()
        {
            return View();
        }

        public class Usuario
        {
            public string idUsuario { get; set; }
            public string Nombre { get; set; }

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
