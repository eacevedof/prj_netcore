using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;


namespace dotnetapi.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : ControllerBase
    {
        private static readonly string[] endpoints = new[]
        {
            "/api/v1/products","/api/v1/clients/","/api/v1/orders/","/api/v1/users"
        };

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<List<Product>> Get(
            [FromQuery] bool discontinuedOnly = false)
        {
            List<Product> products = new List<Product>();
            Product oProduct = new Product();
            
            oProduct.id = 55;
            oProduct.is_active = true;


            products.Add(oProduct);

            // if (discontinuedOnly)
            // {
            //     products = _productsInMemoryStore.Where(p => p.IsDiscontinued).ToList();
            // }
            // else
            // {
            //     products = _productsInMemoryStore;
            // }

            return products;
        }

    }// HomeController
    
}//dotnetapi.Controllers
