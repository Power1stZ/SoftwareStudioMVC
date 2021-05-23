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
using System.Dynamic;

namespace Frontend.Controllers
{ 
    [Authorize]
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;
        private readonly UserService _userService;
        private readonly HistoryService _historyService;
        private readonly RoomService _roomService;
        private readonly ToolService _toolService;
        private readonly IHttpContextAccessor _httpContextAcessor;
        public AdminController(ILogger<AdminController> logger, UserService userService, HistoryService historyService, RoomService roomService, ToolService toolService, IHttpContextAccessor httpContextAcessor)
        {
            _logger = logger;
            _userService = userService;
            _historyService = historyService;
            _roomService = roomService;
            _toolService = toolService;
        }
 
        public IActionResult Index(string? toolName, string? time)
        {
            ViewData["Page1"] = "select";
            ViewData["Page2"] = "unselect";
            ViewData["Page3"] = "unselect";
            dynamic mymodel = new ExpandoObject();
            List<Tool> tool = new List<Tool>();
            List<History> history = new List<History>();
            // Console.WriteLine(JsonConvert.SerializeObject(mydata, Formatting.Indented));
            tool = _toolService.Get();
            history = _historyService.Get();
            List<History> temp = new List<History>();
            if(toolName != null)
            {
                // Console.WriteLine("1");
                foreach (var item in history)
                {
                    if(item.createTime == item.lendTime && item.toolName == toolName)
                    {
                        temp.Add(item);
                    }
                }
            }
            else
            {
                // Console.WriteLine("2");
                foreach (var item in history)
                {
                    if(item.createTime == item.lendTime)
                    {
                        temp.Add(item);
                    }
                }
            }
            List<History> sort = temp.OrderByDescending(history => history.rentTime).ToList();
            List<History> result = new List<History>();
            //Console.WriteLine(JsonConvert.SerializeObject(sort, Formatting.Indented));
            if(time != null){
                foreach (var item in sort) {
                    if (item.rentTime.ToString("HH:mm") == time){
                        result.Add(item);
                    }
                }
            }
            else{
                result = sort;
            }
            mymodel.tool = tool;
            mymodel.history = result;
            return View(mymodel);
        }

        public IActionResult RoomAndTool(string? roomName)
        {
            ViewData["Page1"] = "unselect";
            ViewData["Page2"] = "select";
            ViewData["Page3"] = "unselect";
            List<Room> room = _roomService.Get();
            List<Tool> tool = _toolService.Get();
            dynamic mydata = new ExpandoObject();
            List<Tool> tempTool = new List<Tool>();
            if(roomName != null)
            {
                foreach (var item in tool)
                {
                    if(item.room == roomName)
                    {
                        tempTool.Add(item);
                    }
                }
            }
            else
            {
                foreach (var item in tool)
                {
                    if(item.room == room[0].roomName)
                    {
                        tempTool.Add(item);
                    }
                }
            }
            mydata.room = room;
            mydata.tool = tempTool;
            
            return View(mydata);
        }

        public IActionResult BlackList()
        {
            ViewData["Page1"] = "unselect";
            ViewData["Page2"] = "unselect";
            ViewData["Page3"] = "select";
            // Console.WriteLine(JsonConvert.SerializeObject(data, Formatting.Indented));
           
            List<User> user = _userService.Get();
            if(user != null)
            {
                return View(user);
            }
            return View("ไม่มีผู้ใช้งาน");
        }
        
        public IActionResult BannedUser(string id)
        {
            var user = _userService.Get(id);
            // Console.WriteLine(JsonConvert.SerializeObject(user, Formatting.Indented));
            if (user != null)
            {
                user.isBan = true;
                _userService.Update(user.id,user);
                return RedirectToAction("BlackList");
            }
            return View("ไม่มีอะไร");
        }

        public IActionResult UnBanned(string id)
        {
            var user = _userService.Get(id);
            if (user != null)
            {
                user.isBan = false;
                _userService.Update(user.id,user);
                return RedirectToAction("BlackList");
            }
            return View("ไม่มีอะไร");
        }

        public IActionResult Cancel(string id)
        {
            History tempHistory = _historyService.Get(id);
            tempHistory.lendTime = DateTime.Now.AddHours(7);
            _historyService.Update(id,tempHistory);
            var tool = tempHistory.toolName;
            return RedirectToAction("Index",new {toolName = tool});

        }

        public IActionResult PlusCount(string toolName)
        {
            Tool tool = _toolService.GetByToolName(toolName);
            // Console.WriteLine(JsonConvert.SerializeObject(tool, Formatting.Indented));
            tool.maxCount += 1;
            _toolService.Update(tool.id,tool);
            return RedirectToAction("RoomAndTool",new {roomName = tool.room});
        }

        public IActionResult MinusCount(string toolName)
        {
            Tool tool = _toolService.GetByToolName(toolName);
            // Console.WriteLine(JsonConvert.SerializeObject(tool, Formatting.Indented));
            tool.maxCount -= 1;
            _toolService.Update(tool.id,tool);
            return RedirectToAction("RoomAndTool",new {roomName = tool.room});
        }
    
    }
}
