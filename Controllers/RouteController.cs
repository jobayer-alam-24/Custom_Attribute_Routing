using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Custom_Attribute_Routing.Controllers
{
    [Route("Home")]
    public class RouteController : Controller
    {
        private readonly ILogger<RouteController> _logger;

        public RouteController(ILogger<RouteController> logger)
        {
            _logger = logger;
        }
        [Route("Index")]
        public IActionResult Index()
        {   
            return View();
        }
        //Working as Default
        [Route("/")]
        [Route("~/Students/{id=10}")]
        public IActionResult Students(int id)
        {
            ViewBag.ID = id;
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}