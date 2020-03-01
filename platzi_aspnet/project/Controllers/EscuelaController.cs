//<project>/Controllers/EscuelaController.cs
using System;
using Microsoft.AspNetCore.Mvc;
using project.Models;

namespace project.Controllers
{
    public class EscuelaController:Controller
    {
        public IActionResult Index()
        {
            var objescuela = new EscuelaModel();
            objescuela.Anyo=2005;
            objescuela.EscuelaId = Guid.NewGuid().ToString();
            objescuela.Nombre = "Some school";
            //si no se especifica la vista se lanza la de por defecto
            return View(objescuela);
        }

    }//class

}//namespace