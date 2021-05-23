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
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class HistorysController : ControllerBase
    {
        private readonly HistoryService _historyService;

        public HistorysController(HistoryService historyService)
        {
            _historyService = historyService;
        }

        [HttpGet]
        public ActionResult<List<History>> Get() =>
            _historyService.Get();

        [HttpGet("{id:length(24)}", Name = "GetHistory")]
        public ActionResult<History> Get(string id)
        {
            var history = _historyService.Get(id);

            if (history == null)
            {
                return NotFound();
            }

            return history;
        }

        [HttpGet("{id:length(8)}", Name = "GetByid")]
        public List<History> GetById(string id) =>
            _historyService.GetById(id);

        [HttpPost]
        public ActionResult<History> Create(History history)
        {
            _historyService.Create(history);

            return CreatedAtRoute("GetHistory", new { id = history.id.ToString() }, history);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, History historyIn)
        {
            var history = _historyService.Get(id);

            if (history == null)
            {
                return NotFound();
            }

            _historyService.Update(id, historyIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var history = _historyService.Get(id);

            if (history == null)
            {
                return NotFound();
            }

            _historyService.Remove(history.id);

            return NoContent();
        }
    }

}