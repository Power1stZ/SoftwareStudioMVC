using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Frontend.Controllers
{
    public class MainPageController : Controller
    {
        
        ILogger<MainPageController> _logger;

        public MainPageController(ILogger<MainPageController> logger){
            _logger = logger;
        }

        public IActionResult Index(){
            return View();
        }

    }
}