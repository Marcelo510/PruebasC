using AppWebCore31.Models;
using AppWebCore31.Negocio;
using AppWebCore31.Negocio.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Web.UI;
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

        public IActionResult Inicio(IApplicationBuilder app)
        {
            

            return View();
        }

        public async Task<IActionResult> DetalleDatosAsync()
        {
            var response = await _iService.ObtenerGeno();
            
            var otra = response.Body.ObtenerIntegrantesResult.ToList<IntegrantesModel>();
            return PartialView(otra);
        }

        [HttpPost]
        public async Task<IActionResult> DetalleDatosAsync(string modelo)
        {
            var response = await _iService.ObtenerGeno();
            var otra = response.Body.ObtenerIntegrantesResult.ToList<IntegrantesModel>();
            return PartialView(otra);
        }



        public async Task<List<IntegrantesModel>> GetResult()
        {
            var response = await _iService.ObtenerGeno();
            var otra = response.Body.ObtenerIntegrantesResult.ToList<IntegrantesModel>();
            Thread.Sleep(4000);
            return otra;

        }

        public void resultadocontro()
        {
            decimal principle = Convert.ToDecimal(Request["txtAmount"].ToString());
        }

        public async Task<IActionResult> Index()
        {
            //var lstvalor = new 
            //IList<Student> studentList = new List<Student>() {
            //    new Student(){ StudentID=1, StudentName="Bill"},
            //    new Student(){ StudentID=2, StudentName="Steve"},
            //    new Student(){ StudentID=3, StudentName="Ram"},
            //    new Student(){ StudentID=1, StudentName="Moin"}
            //};


            var dictionary = new Dictionary<int, string>
                {
                    { 1, "TX" },
                    { 2, "UT" },
                    { 3, "FL" }
                };

            //var laLista =  '"marcadores": [{"latitude": 40.416875, "longitude": -3.703308, "city": "Madrid", "description": "Puerta del Sol"},
            //                                {"latitude": 40.417438, "longitude": -3.693363, "city": "Madrid", "description": "Paseo del Prado"}]"'



            



            //var userlist = "{\"ID\":1,\"Name\":\"Manas\",\"Address\":\"India\"}";

            var userlist2 = "{'ID':1,'Name':'Manas','Address':'India'}";
            var otro = userlist2.ToList();


            List<IntegrantesModel> result1;
            List<IntegrantesModel> result2;

            var result1Task = GetResult();
            var result2Task = GetResult();

            await Task.WhenAll(result1Task, result2Task).ConfigureAwait(false);

            result1 = result1Task.Result;
            result2 = result2Task.Result;

            ViewData["reultado"] = result1;

            return View(result2);

            

            //var response5 = _iService.ObtenerGeno();

            //WebService1SoapClient client = new WebService1SoapClient(EndpointConfiguration.WebService1Soap);
            //var result = await client.ObtenerIntegrantesAsync();
            //log.Info("Bienvenidos a nuestra demo de Log4Net");
            //ObtenerIntegrantesResponse response = new ObtenerIntegrantesResponse();


            //var response = await _iService.ObtenerGeno();
            //var otra = response.Body.ObtenerIntegrantesResult.ToList<IntegrantesModel>();



            //try
            //{

            //    var Tarea2 = new Task(() =>
            //    {
            //        var response = _iService.ObtenerGeno();

            //        //Console.WriteLine("Tarea interna 1");
            //    });


            //    //var Tarea = new Task<ObtenerIntegrantesResponse>(() => _iService.ObtenerGeno();
            //    //{
            //    //    var response2 = _iService.ObtenerGeno();
            //    //    //Console.WriteLine("Tarea interna 2");
            //    //});

            //    //Tarea2.Start();
            //    //Tarea.Start();
            //    //await Tarea2;
            //    //await Tarea;

            //    //var response = await _iService.ObtenerGeno();
            //    //var response2 = await _iService.ObtenerGeno();
            //    //var otra = response.Body.ObtenerIntegrantesResult.ToList<IntegrantesModel>();
            //    //return View(otra);
            //    return View();
            //}
            //catch (Exception ex)
            //{
            //    //ANSESLog.Error(typeof(InicioController), ex.Message, ex);
            //    return View(ex);
            //}
        }


        public void mapear() { 
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

        // ***************************************************************************************************************************************


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult OtraVIsta()
        {
            return View();
        }


        public async Task<ActionResult> DetallesPar2(string Area)
        {
            var response = await _iService.ObtenerGeno();
            var otra = response.Body.ObtenerIntegrantesResult.ToList<IntegrantesModel>();
            List<PersonaModel> Per = new List<PersonaModel>();
            foreach (var item in otra)
            {
                PersonaModel deUno = new PersonaModel();
                deUno.Name = item.Apellido;
                Per.Add(deUno);
            }

            var ordenado = Per.OrderBy(Per => Per.Name);
            ViewData["Dato"] = Area;
            return PartialView(ordenado);
        }

        [HttpPost]
        public ActionResult DetallesPar3(List<PersonaModel> laper)
        {
            var ordenado = laper.OrderBy(Per => Per.Name);


            string javaScript = "MostrarMensaje();";
            //ScriptManager.registr.RegisterStartupScript(this, this.GetType(), "script", javaScript, true);




            Thread.Sleep(4000);
            



            return PartialView(ordenado);
        }

        
        public ActionResult TablaView()
        {
            
            return View();
        }

        public async Task<ActionResult> DetallesPar(string Area)
        {

            var response = await _iService.ObtenerGeno();
            var otra = response.Body.ObtenerIntegrantesResult.ToList<IntegrantesModel>();
            List<PersonaModel> Per = new List<PersonaModel>();
            foreach (var item in otra)
            {
                PersonaModel deUno = new PersonaModel();
                deUno.Name = item.Apellido;
                Per.Add(deUno);
            }
            //ViewData["Dato"] = Area;
            if (Area == "1")
            {
                var ordenado = Per.OrderBy(Per => Per.Name);
                return PartialView(ordenado);
            }
            else
                return PartialView(Per);
        }




        // ***************************************************************************************************************************************/


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
