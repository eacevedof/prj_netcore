//<project>/Controllers/EscuelaController.cs
using System;
using Microsoft.AspNetCore.Mvc;
using project.Models;

namespace project.Controllers
{
    public class AsignaturaController:Controller
    {
        public IActionResult Index()
        {
            var asignatura = new Asignatura{
                UniqueId = Guid.NewGuid().ToString(),
                Nombre = "Programación"
            };
            
            ViewBag.fecha = DateTime.Now;

            return View(asignatura);
        }//Index()

    }//class AsignaturaController

}//namespace project.Controllers