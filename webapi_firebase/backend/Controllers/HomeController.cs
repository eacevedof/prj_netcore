using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;
using Theframework.Components;
using Newtonsoft.Json;
using RestSharp;

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
            Log.console("homecontroller.get()");
            test();
            string thisdomain = Utils.get_domain();
            return endpoints.ToArray();
        }

        private void test()
        {
            Log.console("homecontroller.test()");
            Curl ocurl = new Curl();
            string response = ocurl.get_response();
            Log.file(response,"response");
        }

    }// HomeController
    
}//dotnetapi.Controllers
