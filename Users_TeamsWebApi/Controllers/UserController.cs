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
