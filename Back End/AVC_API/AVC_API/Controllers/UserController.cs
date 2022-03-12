using AVC_API.Models;
using AVC_API.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AVC_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/<UserController>
        [HttpGet]
        public async Task<List<User>> GetAllUsers()
        {
            List<User> _users = new List<User>();
            UserService userService = new UserService();
            _users = await userService.GetAllUsers();
            return _users;
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<User> GetUser(string id)
        {           
            User user = new User();
            UserService userService = new UserService();
            user = await userService.GetUser(id);
            return user;
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<bool> AddUser([FromBody] User user)
        {
            bool result = false;
            UserService userService = new UserService();
            result = await userService.AddUser(user);
            return result;
        }

        // PUT api/<UserController>/update/5
        [HttpPost("update/{id}")]
        public async Task<bool> UpdateUser([FromBody] User user)
        {
            bool result = false;
            UserService userService = new UserService();
            result = await userService.UpdateUser(user);
            return result;
        }

        // DELETE api/<UserController>/delete/5
        [HttpPost("/delete/{id}")]
        public async Task<bool> DeleteUser([FromBody] User user)
        {
            bool result = false;
            UserService userService = new UserService();
            result = await userService.DeleteUser(user);
            return result;
        }
    }
}
