using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Users_TeamsWebApi.Data.ViewModels;
using Users_TeamsWebApi.Service;

namespace Users_TeamsWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserService _userService { get; set; }

        public UserController(UserService userService)
        {
            _userService = userService;
        }
        [HttpGet("get-all-users")]
        public IActionResult GetAllUsers()
        {
            var users = _userService.GetAllUsers();
            return Ok(users);
        }
        [HttpGet("get-user-by-id")]
        public IActionResult GetUser(int id)
        {
            var user = _userService.GetUser(id);
            return Ok(user);
        }

         [HttpGet("get-user-by-status-id")]
        public IActionResult GetUserByStatusId(int statusId)
        {
            var users = _userService.GetUserByStatusId(statusId);
            return Ok(users);
        }
         [HttpGet("get-user-by-team-id")]
        public IActionResult GetUserByTeamId(int teamId)
        {
            var users = _userService.GetUserByTeamId(teamId);
            return Ok(users);
        }

        [HttpPost("add-user")]
        public IActionResult AddUser([FromBody] UserVM user)
        {
            _userService.AddUser(user);
            return Ok();
        }
        
        [HttpDelete("delete-user")]
        public IActionResult DeleteUser(int id)
        {
            _userService.DeleteUser(id);
            return Ok();
        }
    }
}
