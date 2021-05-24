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
using System.Globalization;

namespace Frontend.Controllers
{
    [Authorize]
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
            Tool tools = _toolService.GetByToolName(id);
            //Console.WriteLine(tools.toolName);
            List<History> historys = _historyService.GetByToolName(tools.toolName);
            if (tools != null)
            {
                dynamic mymodel = new ExpandoObject();
                mymodel.tools = tools;
                List<History> temp = historys.OrderBy(history => history.rentTime).ToList();
                List<History> result = new List<History>();
                result.Add(new History
                {
                    rentTime = DateTime.Now.Date
                });
                foreach (var item in temp)
                {
                    if (item.lendTime == item.createTime && DateTime.Compare(item.rentTime.Date, DateTime.Now.Date) <= 0)
                    {
                        result.Add(item);
                    }
                }
                mymodel.historys = result;
                //Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
                return View(mymodel);
            }
            return View("ไม่มีอุปกรณ์");
        }



        [HttpPost]
        public IActionResult SelectDate(string toolName, string date)
        {
            //Console.WriteLine(date);
            DateTime realDateTime = DateTime.ParseExact(date, "d MMMM yyyy", CultureInfo.InvariantCulture);
            //Console.WriteLine(realDateTime);
            Tool tools = _toolService.GetByToolName(toolName);
            List<History> historys = _historyService.GetByToolName(tools.toolName);
            //Console.WriteLine(historys);
            
            if (tools != null)
            {
                dynamic mymodel = new ExpandoObject();
                mymodel.tools = tools;
                List<History> temp = historys.OrderBy(history => history.rentTime).ToList();
                List<History> result = new List<History>();
                result.Add(new History
                {
                    rentTime = realDateTime
                });
                foreach (var item in temp)
                {
                    
                    if (item.lendTime == item.createTime && DateTime.Compare(item.rentTime.Date, realDateTime.Date) <= 0)
                    {
                        //Console.WriteLine(item.rentTime.ToString("dd/MM/yyyy"));
                        result.Add(item);
                    }
                }
                mymodel.historys = result;
                // Console.Write("Finish");
                //Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
                return View(mymodel);
            }
            return View("ไม่มีอุปกรณ์");
        }

        [HttpPost]
        public IActionResult Rent(string inputTool,string inputDate, string inputTime)
        {
            inputTime = inputTime.Substring(0,inputTime.IndexOf(" "));
            // Console.WriteLine(inputTime);
            var stringOfDate = inputDate + " " + inputTime;
            // Console.WriteLine(stringOfDate);
            DateTime dateTime12 = DateTime.ParseExact(stringOfDate, "dd/MM/yyyy H:mm", CultureInfo.InvariantCulture);
		    // Console.WriteLine(dateTime12);
            var data = _historyService.Create(new History
                {
                    studentNumber = User.FindFirst("studentNumber").Value,
                    toolName = inputTool,
                    rentTime = dateTime12.AddHours(7),
                    lendTime = DateTime.Now.AddHours(7),
                    createTime = DateTime.Now.AddHours(7)
                });
            return RedirectToAction("Index",new {id = inputTool});
        }
    }
}