using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Frontend.Models;
using Frontend.Services;
using System.Net.Http;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Frontend.Controllers
{

    public class StartPageController : Controller
    {

        ILogger<StartPageController> _logger;
        private readonly UserService _userService;

        public StartPageController(ILogger<StartPageController> logger, UserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register([Bind("firstName,lastName,studentNumber,email,password")] User user, string confirmPassword)
        {
            if (confirmPassword == user.password)
            {
                var data = _userService.Create(user);
                return RedirectToAction("Index", "MainPage", data);
            }
            else return View("Index");
        }



        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            User data = _userService.Login(email, password);
            //Console.WriteLine(JsonConvert.SerializeObject(data, Formatting.Indented));
            if (data != null)
            {
                if (!data.isBan)
                {
                    return RedirectToAction("Index", "MainPage", data);
                }
                else return View("Index");

            }
            return View("Index");
        }



    }
}
