using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Frontend.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Frontend.Services;
using System.Dynamic;
using Newtonsoft.Json;

namespace Frontend.Controllers
{
    public class SelectPageController : Controller
    {
        private readonly ILogger<SelectPageController> _logger;
        private readonly ToolService _toolService;

        private readonly RoomService _roomService;
        private readonly IHttpContextAccessor _httpContextAcessor;

        public SelectPageController(ILogger<SelectPageController> logger, ToolService toolService, RoomService roomService, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _toolService = toolService;
            _roomService = roomService;
            _httpContextAcessor = httpContextAccessor;
        }

        public IActionResult Index(string id="DataStruc Lab")
        {
            dynamic mymodel = new ExpandoObject();
            mymodel.rooms = _roomService.Get();
            mymodel.tools = _toolService.GetByRoom(id);
            // Console.WriteLine(id);
            // Console.WriteLine(JsonConvert.SerializeObject(mymodel.tools, Formatting.Indented));
            if(mymodel.rooms != null){
                return View(mymodel);
            }
            return View("ไม่มีห้องให้ใช้งาน");
        }
    }
}