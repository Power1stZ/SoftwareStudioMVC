using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Frontend.Models;

namespace Frontend.Controllers
{
    public class HomeAdminController : Controller
    {
        private readonly ILogger<HomeAdminController> _logger;

        public HomeAdminController(ILogger<HomeAdminController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["AdPage1"] = "select";
            ViewData["AdPage2"] = "unselect";
            ViewData["AdPage3"] = "unselect";
            return View();
        }
        public IActionResult ToolStock()
        {
            ViewData["AdPage1"] = "unselect";
            ViewData["AdPage2"] = "select";
            ViewData["AdPage3"] = "unselect";
            return View();
        }
        public IActionResult BannedUser()
        {
            ViewData["AdPage1"] = "unselect";
            ViewData["AdPage2"] = "select";
            ViewData["AdPage3"] = "unselect";
            return View();
        }

    }
}