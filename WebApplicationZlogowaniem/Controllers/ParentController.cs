using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplicationZlogowaniem.Models;

namespace ElectronicRedBook.Controllers
{
    public class ParentController : Controller
    {
        private readonly ILogger<ParentController> _logger;

        public ParentController(ILogger<ParentController> logger)
        {
            _logger = logger;
        }

        public IActionResult BasicInformations()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}