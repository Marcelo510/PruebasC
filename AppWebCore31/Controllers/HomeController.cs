using AppWebCore31.Models;
using AppWebCore31.Negocio.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using WSGenograma;
using static WSGenograma.WebService1SoapClient;

namespace AppWebCore31.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly IGeno _iService;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        

        public HomeController(IGeno iService)
        {
            _iService = iService;

        }

        

        public async Task<IActionResult> Index()
        {
            //WebService1SoapClient client = new WebService1SoapClient(EndpointConfiguration.WebService1Soap);
            //var result = await client.ObtenerIntegrantesAsync();
            log.Info("Bienvenidos a nuestra demo de Log4Net");
            
            try
            {
                var response = await _iService.ObtenerGeno();
                var otra = response.Body.ObtenerIntegrantesResult.ToList<IntegrantesModel>();
                return View(otra);
            }
            catch (Exception ex)
            {
                //ANSESLog.Error(typeof(InicioController), ex.Message, ex);
                return View(ex);
            }
        }


        public ActionResult ParcialVista(List<WSGenograma.IntegrantesModel> modelo)
        {
            var retorne = from person in modelo
                          orderby person.Apellido descending
                                      select person.Apellido;
            modelo[0].Nombre = "aaaaaaaaaaaaaaa";
            return PartialView(modelo);
        }


        public async Task<ActionResult> Detalles(string Area)
        {
            var response = await _iService.ObtenerGeno();
            var otra = response.Body.ObtenerIntegrantesResult.ToList<IntegrantesModel>();
            PersonaModel Per = new PersonaModel();
            Per.Name = otra[0].Apellido;
            ViewData["Dato"] = Area;
            return PartialView(Per);
        }

        //public static ViewDataDictionary ToViewDataDictionary(this object values)
        //{
        //    var dictionary = new ViewDataDictionary();
        //    foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(values))
        //    {
        //        dictionary.Add(property.Name, property.GetValue(values));
        //    }
        //    return dictionary;
        //}


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult OtraParcial()
        {
            PersonaModel perso = new PersonaModel();
            perso.Name = "Marcelo";
            return View(perso);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
