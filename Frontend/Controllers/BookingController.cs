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
    public class BookingController : Controller
    {
        private readonly ILogger<BookingController> _logger;
        private readonly HistoryService _historyService;
        private readonly IHttpContextAccessor _httpContextAcessor;

        public BookingController(ILogger<BookingController> logger, HistoryService historyService, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _historyService = historyService;
            _httpContextAcessor = httpContextAccessor;

        }

        public IActionResult Index()
        {
            ViewData["Page1"] = "select";
            ViewData["Page2"] = "unselect";
            ViewData["Page3"] = "unselect";
            var data = _historyService.GetById(User.FindFirst("studentNumber").Value);
            if (data != null)
            {
                List<History> sort = data.OrderByDescending(history => history.createTime).ToList();
                //Console.WriteLine(JsonConvert.SerializeObject(sort, Formatting.Indented));
                return View(sort);
            }

            return View("ไม่มีรายการจอง");
        }

        public IActionResult History()
        {
            ViewData["Page1"] = "unselect";
            ViewData["Page2"] = "unselect";
            ViewData["Page3"] = "select";


            var data = _historyService.GetById(User.FindFirst("studentNumber").Value);
            if (data != null)
            {
                List<History> sort = data.OrderByDescending(history => history.createTime).ToList();
                //Console.WriteLine(JsonConvert.SerializeObject(sort, Formatting.Indented));
                return View(sort);
            }

            return View("ไม่มีรายการจอง");
        }

        public IActionResult Overdue()
        {
            ViewData["Page1"] = "unselect";
            ViewData["Page2"] = "select";
            ViewData["Page3"] = "unselect";

            var data = _historyService.GetById(User.FindFirst("studentNumber").Value);
            if (data != null)
            {
                List<History> sort = data.OrderByDescending(history => history.createTime).ToList();
                //Console.WriteLine(JsonConvert.SerializeObject(sort, Formatting.Indented));
                return View(sort);
            }

            return View("ไม่มีรายการจอง");
        }


    }
}