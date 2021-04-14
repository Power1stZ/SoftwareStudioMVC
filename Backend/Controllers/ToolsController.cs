using Backend.Models;
using Backend.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Backend.Controllers
{
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

            return CreatedAtRoute("Gettool", new { id = tool.Id.ToString() }, tool);
        }
    }

}