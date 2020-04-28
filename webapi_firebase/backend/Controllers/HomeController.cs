using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;
using Theframework.Components;
using Newtonsoft.Json;


namespace dotnetapi.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : ControllerBase
    {
        private static List<string> endpoints = new List<string>
        {
            "/api/v1/products","/api/v1/clients","/api/v1/orders","/api/v1/users"
        };

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string[] Get()
        {
            string thisdomain = Utils.get_domain();
            Log.console(thisdomain, "title console :)");
            Log.file(thisdomain,"title for file");
            //Product o = new Product();
            //Log.file(o,"o product");
            endpoints.Add(thisdomain);
            return endpoints.ToArray();
        }

    }// HomeController
    
}//dotnetapi.Controllers
