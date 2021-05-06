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
    public class SelectEquipmentController : Controller
    {
        private readonly ILogger<SelectEquipmentController> _logger;
        private readonly ToolService _toolService;
        private readonly IHttpContextAccessor _httpContextAcessor;

        public SelectEquipmentController(ILogger<SelectEquipmentController> logger, ToolService toolService, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _toolService = toolService;
            _httpContextAcessor = httpContextAccessor;
        }

        public IActionResult Index()
        {

            return View();
        }


    }
}