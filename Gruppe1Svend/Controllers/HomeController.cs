using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Gruppe1Svend.Models;

namespace Gruppe1Svend.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public IActionResult Ordreoversigt()
        {
            return View();
        }

        public IActionResult Lagerstatus()
        {
            ViewData["Message"] = "Lagerstatus";

            return View();
        }

        public IActionResult Rapport()
        {
            ViewData["Message"] = "Rapporter";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
