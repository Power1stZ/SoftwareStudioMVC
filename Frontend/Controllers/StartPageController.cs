using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Frontend.Controllers
{
    public class StartPageController : Controller
    {
        
        ILogger<StartPageController> _logger;

        public StartPageController(ILogger<StartPageController> logger){
            _logger = logger;
        }

        public IActionResult Index(){
            return View();
        }

    }
}