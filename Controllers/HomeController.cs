using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleLoginRegistration.Models;

namespace SimpleLoginRegistration.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }
        [HttpPost("register")]
        public IActionResult CreateUser(Register  model)
        {
            Register subNewUser= model;
            if(!ModelState.IsValid)
            {
                return View("Index");
            }
            return RedirectToAction("Success");
        }
        [HttpPost("login")]
        public IActionResult login(Login  model)
        {
            Login data= model;
            if(!ModelState.IsValid)
            {
                return View("Index");
            }
            return RedirectToAction("Success");
        }

        public IActionResult Success()
        {
            return View("Success");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
