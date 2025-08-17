using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ProyColeccionLibros.Models;

namespace ProyColeccionLibros.Controllers
{
    public class LibroController : Controller
    {
        static List<Libro> lista = new List<Libro>();

        // GET: Libro
        public ActionResult IndexLibro()
        {
            // enviamos los datos del modelo a la vista
            return View(lista);
        }

        // GET: Libro/Details/5
        public ActionResult DetailsLibro(int id)
        {
            // buscar un libro en la colección lista
            // que corresponda en el codigo con el id
            // enviado
            Libro buscado = lista.Find( L => L.IdLibro == id );

            // los datos del modelo lo enviamos a la vista
            return View(buscado);
        }

        // GET: Libro/Create
        public ActionResult CreateLibro()
        {
            Libro nuevo = new Libro();
            nuevo.FechaImpresion = DateTime.Today;
            //
            return View(nuevo);
        }

        // POST: Libro/Create
        [HttpPost]
        public ActionResult CreateLibro(Libro obj)
        {
            try
            {
                // agregando un nuevo libro a la coleccion
                lista.Add(obj);
                ViewBag.mensaje = "Libro registrado correctamente";
            }
            catch(Exception ex)
            {
                ViewBag.mensaje = ex.Message;
            }
            return View(obj);
        }

        // GET: Libro/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Libro/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Libro/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Libro/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
