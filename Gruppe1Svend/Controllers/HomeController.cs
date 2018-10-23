 /* Gruppe 1 - Birk, Peter & René
 Home controller */ 

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Gruppe1Svend.Models;
using System.Security.Claims;

namespace Gruppe1Svend.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public IActionResult Ordreoversigt()
        {
            // Fanger hvilken bruger der er logget ind og sender dette videre til Layout.cshtml
            String name = "";
            ClaimsIdentity id = ((ClaimsIdentity)User.Identity);
            Claim claim = id.FindFirst(c => c.Type == "name");
            if (claim != null)
            {
                name = claim.Value;

            }
            return View();
        }

            public IActionResult Lagerstatus()
        {
            ViewData["Message"] = "Lagerstatus";

            return View();
        }

        public IActionResult Rapporter()
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

