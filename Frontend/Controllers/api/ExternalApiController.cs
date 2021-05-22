using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Frontend.Models;
using Frontend.Services;
using System.Net.Http;
using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Frontend.Controllers.api
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class ExternalApiController : ControllerBase
    {
        private readonly ToolService _toolService;
        private readonly HistoryService _historyService;

        public ExternalApiController(ToolService toolService, HistoryService historyService)
        {
            _toolService = toolService;
            _historyService = historyService;
        }

        [HttpGet]
        public ActionResult<List<ExternalApi>> Get()
        {
            List<Tool> tools = _toolService.Get();
            List<History> allHistory = _historyService.Get();
            List<History> history = new List<History>();
            foreach (var lend in allHistory)
            {
                if(lend.createTime == lend.lendTime)
                {
                    history.Add(lend);
                }
            }

            DateTime date = DateTime.Now;
            List<ExternalApi> result = new List<ExternalApi>();
            
            foreach (var tool in tools)
            {
                ExternalApi temp = new ExternalApi();
                temp.toolName = tool.toolName;
                temp.room = tool.room;
                temp.maxCount = tool.maxCount;
                var nEquipment = tool.maxCount;
                List<History> isLend = new List<History>();

                
                for (var item = 1; item < history.Count; item++)
                {
                    if (DateTime.Compare(history[item].rentTime.AddMinutes(70), DateTime.Now) < 0)
                    {
                        nEquipment--;
                    }
                }
                // Console.WriteLine(nEquipment);
                int[] nInEachTime = { nEquipment, nEquipment, nEquipment, nEquipment, nEquipment, nEquipment };
                for (var i = 0; i < nInEachTime.Length; i++)
                {
                    if (i > 2)
                    {
                        foreach (var j in history)
                        {
                            if (DateTime.Compare(j.rentTime, history[0].rentTime.AddHours(10 + i).AddMinutes(30)) == 0)
                            {
                                nInEachTime[i]--;
                            }
                        }
                    }
                    else
                    {
                        foreach (var j in history)
                        {
                            if (DateTime.Compare(j.rentTime, history[0].rentTime.AddHours(9 + i).AddMinutes(30)) == 0)
                            {
                                nInEachTime[i]--;
                            }
                        }
                    }
                }
                temp.slot1 = nInEachTime[0];
                temp.slot2 = nInEachTime[1];
                temp.slot3 = nInEachTime[2];
                temp.slot4 = nInEachTime[3];
                temp.slot5 = nInEachTime[4];
                temp.slot6 = nInEachTime[5];
                result.Add(temp);
            }
            
            return Ok(result);
        }

    }
}