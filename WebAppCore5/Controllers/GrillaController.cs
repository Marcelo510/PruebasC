using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppCore5.Models;

namespace WebAppCore5.Controllers
{
    public class GrillaController : Controller
    {
        // GET: GrillaController
        public ActionResult Index()
        {
            List<DatosListas> listaPalabras = new List<DatosListas>();

            listaPalabras.Add(new DatosListas() { Nombre = "Marcelo" });
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

        // GET: GrillaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GrillaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GrillaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GrillaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GrillaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GrillaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GrillaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
