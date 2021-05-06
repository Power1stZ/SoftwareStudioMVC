using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Frontend.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Frontend.Controllers
{
    [Authorize]
    public class MainPageController : Controller
    {

        ILogger<MainPageController> _logger;

        public MainPageController(ILogger<MainPageController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            if (User.FindFirst(ClaimTypes.Role).Value == "1")
            {
                return RedirectToAction("AdminMainPage");
            }
            Console.WriteLine(User.FindFirst(ClaimTypes.Role).Value);
            return View();

        }
        public IActionResult AdminMainPage()
        {
            return View();
        }

    }
}