//<project>/Controllers/EscuelaController.cs
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using project.Models;

namespace project.Controllers
{
    public class AsignaturaController:Controller
    {
        public IActionResult Index(){
            return View(new Asignatura{UniqueId = Guid.NewGuid().ToString(),Nombre = "Programación"});
        }

        public IActionResult MultiAsignatura()
        {
            var asignaturas = this._get_asignaturas();
            ViewBag.fecha = DateTime.Now;

            return View("MultiAsignatura",asignaturas);
        }//Index()
    
        private List<Asignatura> _get_asignaturas()
        {
            var asignaturas = new List<Asignatura>(){
                        new Asignatura{Nombre="Matemáticas",UniqueId=Guid.NewGuid().ToString()} ,
                        new Asignatura{Nombre="Educación Física",UniqueId=Guid.NewGuid().ToString()},
                        new Asignatura{Nombre="Castellano",UniqueId=Guid.NewGuid().ToString()},
                        new Asignatura{Nombre="Ciencias Naturales",UniqueId=Guid.NewGuid().ToString()},
                        new Asignatura{UniqueId = Guid.NewGuid().ToString(),Nombre = "Programación"}
                    };
            return asignaturas;
        }

    }//class AsignaturaController

}//namespace project.Controllers