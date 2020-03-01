//<project>/Controllers/EscuelaController.cs
using Microsoft.AspNetCore.Mvc;

namespace project.Controllers
{
    public class EscuelaController:Controller
    {
        public IActionResult Index()
        {
            //si no se especifica la vista se lanza la de por defecto
            return View();
        }

    }//class

}//namespace