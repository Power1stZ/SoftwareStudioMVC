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
using System.Dynamic;

namespace Frontend.Controllers
{
    public class SelectEquipmentController : Controller
    {
        private readonly ILogger<SelectEquipmentController> _logger;
        private readonly ToolService _toolService;
        private readonly HistoryService _historyService;
        private readonly IHttpContextAccessor _httpContextAcessor;

        public SelectEquipmentController(ILogger<SelectEquipmentController> logger, ToolService toolService, HistoryService historyService, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _toolService = toolService;
            _historyService = historyService;
            _httpContextAcessor = httpContextAccessor;
        }

        public IActionResult Index(string id)
        {
            Tool tools = _toolService.Get(id);
            //Console.WriteLine(tools.toolName);
            List<History> historys = _historyService.GetByToolName(tools.toolName);
            if(tools != null){
                dynamic mymodel = new ExpandoObject();
                mymodel.tools = tools;
                List<History> temp = historys.OrderBy(history=> history.rentTime).ToList();
                List<History> result = new List<History>();
                foreach(var item in temp)
                {
                    if(item.lendTime == item.createTime){
                        result.Add(item);
                    }
                }
                mymodel.historys = result;
                //Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
                return View(mymodel);
            }
            return View("ไม่มีอุปกรณ์");        
        }

        public IActionResult Rent(string tool,DateTime time)
        {
            return View("Index");
        }


    }
}