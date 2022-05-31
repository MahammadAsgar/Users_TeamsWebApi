using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Users_TeamsWebApi.Data.ViewModels;
using Users_TeamsWebApi.Service;

namespace Users_TeamsWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        public TeamService _teamService { get; set; }

        public TeamController(TeamService teamService)
        {
            _teamService = teamService;
        }
        [HttpGet("get-all-teams")]
        public IActionResult GetAllTeams()
        {
            var teams = _teamService.GetAllTeams();
            return Ok(teams);
        }
        [HttpGet("get-team-by-id")]
        public IActionResult GetTeam(int id)
        {
            var team = _teamService.GetTeam(id);
            return Ok(team);
        }

        [HttpPost("add-team")]
        public IActionResult AddTeam([FromBody] TeamVM team)
        {
            _teamService.AddTeam(team);
            return Ok();
        }

        [HttpDelete("delete-team")]
        public IActionResult DeleteTeam(int id)
        {
            _teamService.DeleteTeam(id);
            return Ok();
        }
    }
}
