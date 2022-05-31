using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Users_TeamsWebApi.Data.ViewModels;
using Users_TeamsWebApi.Service;

namespace Users_TeamsWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        public StatusService _statusService { get; set; }

        public StatusController(StatusService statusService)
        {
            _statusService = statusService;
        }
        [HttpGet("get-all-statuses")]
        public IActionResult GetAllStatuses()
        {
            var statuses = _statusService.GetAllStatuses();
            return Ok(statuses);
        }
        [HttpGet("get-status-by-id")]
        public IActionResult GetStatus(int id)
        {
            var status=_statusService.GetStatus(id);
            return Ok (status);
        }

        [HttpPost("add-status")]
        public IActionResult AddStatus([FromBody] StatusVM status)
        {
            _statusService.AddStatus(status);
            return Ok();
        }
    }
}
