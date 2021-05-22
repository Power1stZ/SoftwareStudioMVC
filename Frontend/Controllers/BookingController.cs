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
    public class BookingController : Controller
    {
        private readonly ILogger<BookingController> _logger;
        private readonly HistoryService _historyService;
        private readonly IHttpContextAccessor _httpContextAcessor;
        private readonly UserService _userService;

        public BookingController(ILogger<BookingController> logger, HistoryService historyService, IHttpContextAccessor httpContextAccessor, UserService userService)
        {
            _logger = logger;
            _historyService = historyService;
            _httpContextAcessor = httpContextAccessor;
            _userService = userService;
        }

        public IActionResult Index()
        {
            ViewData["Page1"] = "select";
            ViewData["Page2"] = "unselect";
            ViewData["Page3"] = "unselect";
            var data = _historyService.GetById(User.FindFirst("studentNumber").Value);
            if (data != null)
            {
                List<History> sort = data.OrderByDescending(history => history.rentTime).ToList();
                List<History> result = new List<History>();
                foreach(var item in sort){
                    if(DateTime.Compare(DateTime.Now, item.rentTime.AddMinutes(70)) <= 0 && item.lendTime == item.createTime){
                        result.Add(item);
                    }
                }
                // Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
                return View(result);
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
                List<History> sort = data.OrderByDescending(history => history.rentTime).ToList();
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
                List<History> sort = data.OrderByDescending(history => history.rentTime).ToList();
                List<History> result = new List<History>();
                foreach(var item in sort){
                    if(DateTime.Compare(DateTime.Now, item.rentTime.AddMinutes(70)) > 0 && item.lendTime == item.createTime){
                        result.Add(item);
                    }
                }
                //Console.WriteLine(JsonConvert.SerializeObject(sort, Formatting.Indented));
                return View(result);
            }

            return View("ไม่มีรายการจอง");
        }

        public IActionResult LendHistory(string id)
        {
            History tempHistory = _historyService.Get(id);
            Console.WriteLine(tempHistory.studentNumber);
            User tempUser = _userService.GetById(tempHistory.studentNumber);
            // if(temp.rentTIEnumerable.AddHours(1))
            tempHistory.lendTime = DateTime.Now.AddHours(7);
            if (DateTime.Compare(tempHistory.lendTime, tempHistory.rentTime.AddMinutes(70)) > 0) {
                tempUser.exceedCount = tempUser.exceedCount + 1;
            }
            //Console.WriteLine(JsonConvert.SerializeObject(temp, Formatting.Indented));
            _userService.Update(tempUser.id,tempUser);
            _historyService.Update(tempHistory.id,tempHistory);
            return RedirectToAction("History");
        }

        public IActionResult LendOverdue(string id)
        {
            History tempHistory = _historyService.Get(id);
            Console.WriteLine(tempHistory.studentNumber);
            User tempUser = _userService.GetById(tempHistory.studentNumber);
            // if(temp.rentTIEnumerable.AddHours(1))
            tempHistory.lendTime = DateTime.Now.AddHours(7);
            if (DateTime.Compare(tempHistory.lendTime, tempHistory.rentTime.AddMinutes(70)) > 0) {
                tempUser.exceedCount = tempUser.exceedCount + 1;
            }
            //Console.WriteLine(JsonConvert.SerializeObject(temp, Formatting.Indented));
            _userService.Update(tempUser.id,tempUser);
            _historyService.Update(tempHistory.id,tempHistory);
            return RedirectToAction("Overdue");
        }

        public IActionResult LendIndex(string id)
        {
            History tempHistory = _historyService.Get(id);
            // if(temp.rentTIEnumerable.AddHours(1))
            tempHistory.lendTime = DateTime.Now.AddHours(7);
            //Console.WriteLine(JsonConvert.SerializeObject(temp, Formatting.Indented));
            _historyService.Update(tempHistory.id,tempHistory);
            return RedirectToAction("Index");
        }
    }
}