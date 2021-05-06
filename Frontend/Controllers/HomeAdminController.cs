using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Frontend.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Frontend.Services;

namespace Frontend.Controllers
{
    public class HomeAdminController : Controller
    {
        private readonly ILogger<HomeAdminController> _logger;
        private readonly UserService _userService;
        private readonly HistoryService _historyService;
        private readonly RoomService _roomService;
        private readonly ToolService _toolService;
        private readonly IHttpContextAccessor _httpContextAcessor;
        public HomeAdminController(ILogger<HomeAdminController> logger, UserService userService, HistoryService historyService, RoomService roomService, ToolService toolService, IHttpContextAccessor httpContextAcessor)
        {
            _logger = logger;
            _userService = userService;
            _historyService = historyService;
            _roomService = roomService;
            _toolService = toolService;
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
            ViewData["AdPage2"] = "unselect";
            ViewData["AdPage3"] = "select";
            var user = _userService.Get();
            if (user != null)
            {
                return View(user);
            }
            return View();
        }

        [HttpPost]
        public IActionResult Ban()
        {

            return View("BannedUser");
        }

    }
}