using AppWebCore31.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWebCore31.Controllers
{
    public class AjaxController : Controller
    {
        public IActionResult Index()
        {

            List<PersonaModel> Persona = new List<PersonaModel>();

            Persona.Add(new PersonaModel { Name = "Marcelo", Edad = 30 });
            Persona.Add(new PersonaModel { Name = "Alonso", Edad = 20 });

            return View(Persona);
        }


        [BindProperty]
        public List<PersonaModel> Usuario { get; set; }
        public IActionResult ParcialAjax2()
        {

            var ver = Usuario[0].Name;
            return PartialView();
        }




    }
}
