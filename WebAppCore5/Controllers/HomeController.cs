using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebAppCore5.Models;

namespace WebAppCore5.Controllers
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

        public IActionResult FilterList()
        {
            List<DatosListas> listaPalabras = new List<DatosListas>();

            listaPalabras.Add(new DatosListas() { IdNombre = 1, Nombre = "Marcelo" });
            listaPalabras.Add(new DatosListas() { IdNombre = 2, Nombre = "Armando" });
            listaPalabras.Add(new DatosListas() { IdNombre = 3, Nombre = "Alonso" });
            listaPalabras.Add(new DatosListas() { IdNombre = 4, Nombre = "Marcelo2" });
            listaPalabras.Add(new DatosListas() { IdNombre = 5, Nombre = "Armando2" });
            listaPalabras.Add(new DatosListas() { IdNombre = 6, Nombre = "Alonso2" });
            listaPalabras.Add(new DatosListas() { IdNombre = 7, Nombre = "Marcelo" });
            listaPalabras.Add(new DatosListas() { IdNombre = 8, Nombre = "Armando" });
            listaPalabras.Add(new DatosListas() { IdNombre = 9, Nombre = "Alonso" });
            listaPalabras.Add(new DatosListas() { IdNombre = 10, Nombre = "Marcelo" });
            listaPalabras.Add(new DatosListas() { IdNombre = 11, Nombre = "Armando" });
            listaPalabras.Add(new DatosListas() { IdNombre = 12, Nombre = "Alonso" });




            ViewBag.data = listaPalabras;
            return View();
        }

        public IActionResult TextDropBuscador()
        {
            List<DatosListas> listaPalabras = new List<DatosListas>();
            
            listaPalabras.Add(new DatosListas() { Nombre= "Marcelo"});
            listaPalabras.Add(new DatosListas() { Nombre = "Armando" });
            listaPalabras.Add(new DatosListas() { Nombre = "Alonso" });
            listaPalabras.Add(new DatosListas() { IdNombre = 4, Nombre = "Marcelo2" });
            listaPalabras.Add(new DatosListas() { IdNombre = 5, Nombre = "Armando2" });
            listaPalabras.Add(new DatosListas() { IdNombre = 6, Nombre = "Alonso2" });
            listaPalabras.Add(new DatosListas() { IdNombre = 7, Nombre = "Marcelo" });
            listaPalabras.Add(new DatosListas() { IdNombre = 8, Nombre = "Armando" });
            listaPalabras.Add(new DatosListas() { IdNombre = 9, Nombre = "Alonso" });
            listaPalabras.Add(new DatosListas() { IdNombre = 10, Nombre = "Marcelo" });
            listaPalabras.Add(new DatosListas() { IdNombre = 11, Nombre = "Armando" });
            listaPalabras.Add(new DatosListas() { IdNombre = 12, Nombre = "Alonso" });

            ViewBag.data = listaPalabras;

            return View(listaPalabras);
        }

        
        public IActionResult TextDropBuscador1(string a)
        {
            List<DatosListas> listaPalabras = new List<DatosListas>();

            var ver = ViewData["Dato"];
            return View(listaPalabras);
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
