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
using Newtonsoft.Json.Linq;

namespace Frontend.Controllers
{
    public class NeighbourController : Controller
    {
        private readonly ILogger<NeighbourController> _logger;

        public async Task<IActionResult> Index()
        {
            var json = await GetExternalLabs();
            //Console.WriteLine(json);
            JObject o = JObject.Parse(json);
            // Console.WriteLine(JsonConvert.SerializeObject(o.GetValue("data"), Formatting.Indented));
            // var exLabs = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            // Console.WriteLine(JsonConvert.SerializeObject(exLabs, Formatting.Indented));
            // ViewBag.ExternalLabs = exLabs;
            var result = o.GetValue("data");
            ViewBag.ExternalLabs = result;
                
            return View();
            
        }
        public async Task<IActionResult> NeighbourDetails(string labName)
        {
            var json = await GetExternalLabs();
            JObject o = JObject.Parse(json);
            var temp = o.GetValue("data");
            var result = new Object();
            foreach (var item in temp)
            {
                if(item.Value<string>("name") == labName)
                {
                    result = item;
                    // Console.WriteLine(result);
                    break;
                }
            }
            ViewBag.TimeSlot = result;
            return View();
        }

        private async Task<string> GetExternalLabs()
        {
            string baseUrl = "http://akio147.nsharuk.com/LabManage/ExternalAPI";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync(baseUrl))
                    {
                        using (HttpContent content = res.Content)
                        {
                            var data = await content.ReadAsStringAsync();
                            if (data == null) return "[]";
                            return data;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                return "[]";
            }
        }

    }
}