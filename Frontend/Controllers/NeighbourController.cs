using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Frontend.Models;
using System.Net.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Frontend.Services;

namespace Frontend.Controllers
{
    [Authorize]
    public class NeighbourController : Controller
    {
        private readonly ILogger<NeighbourController> _logger;

        public IActionResult Index()
        {
            ViewData["Page1"] = "select";
            ViewData["Page2"] = "unselect";
            ViewData["Page3"] = "unselect";
            
            return View();
        }
        public IActionResult NeighbourDetails()
        {
            ViewData["Page1"] = "unselect";
            ViewData["Page2"] = "select";
            ViewData["Page3"] = "unselect";
            
            return View();
        }

    }
}