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

namespace Backend.Controllers.api
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ToolsController : ControllerBase
    {
        private readonly ToolService _toolService;

        public ToolsController(ToolService toolService)
        {
            _toolService = toolService;
        }

        [HttpGet]
        public ActionResult<List<Tool>> Get() =>
            _toolService.Get();

        [HttpGet("{id:length(24)}", Name = "GetTool")]
        public ActionResult<Tool> Get(string id)
        {
            var tool = _toolService.Get(id);

            if (tool == null)
            {
                return NotFound();
            }

            return tool;
        }

        [HttpPost]
        public ActionResult<Tool> Create(Tool tool)
        {
            _toolService.Create(tool);

            return CreatedAtRoute("GetTool", new { id = tool.id.ToString() }, tool);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Tool toolIn)
        {
            var tool = _toolService.Get(id);

            if (tool == null)
            {
                return NotFound();
            }

            _toolService.Update(id, toolIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var tool = _toolService.Get(id);

            if (tool == null)
            {
                return NotFound();
            }

            _toolService.Remove(tool.id);

            return NoContent();
        }
    }

}