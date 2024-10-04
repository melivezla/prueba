using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace appdemo.Controllers
{
    public class ContactoController : Controller
    {
        private readonly ILogger<ContactoController> _logger;

        public ContactoController(ILogger<ContactoController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index(Contacto contacto) 
        {
            return View();
        }


        [HttpPost]
        public IActionResult Registrar(Contacto contacto) 
        {
            ViewData["MsgRespuesta"] = "Gracias por contactarnos nos ponemos en contacto pronto " + contacto.Nombre;
            return View("Index");
        }

        [ResponseCache(Duration =0, Location = ResponseCacheLocation.None, NoStore =true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }

    public class Contacto
    {
        public string? Nombre { get; set; }
        public string? Email { get; set; }
        public string? Mensaje { get; set; }
        public int Edad { get; set; }
    }

}