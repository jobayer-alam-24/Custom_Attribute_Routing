using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Custom_Attribute_Routing.CustomAttributeRouting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Custom_Attribute_Routing.Controllers
{
    public class EditController : Controller
    {
        private readonly ILogger<EditController> _logger;

        public EditController(ILogger<EditController> logger)
        {
            _logger = logger;
        }

        [IsAdmin("Mahinur Rahman Hridoy")]
        public IActionResult Admin(string adminName)
        {
            if(adminName == "Mahinur Rahman Hridoy")
            {
                return View();
            }
            else
            {
                return RedirectToAction("CustomError");
            }
        }
        public IActionResult CustomError()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}