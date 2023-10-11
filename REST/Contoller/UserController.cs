using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REST.Entities;
using REST.Interface;

namespace REST.Contoller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepastory _userRepastory;
        public UserController(IUserRepastory userRepastory) => _userRepastory = userRepastory;
        [HttpGet]
        public async Task<IActionResult> GetAllUsers() => Ok(_userRepastory.GetAllUsers());
        [HttpGet("id")]
        public async Task<IActionResult> GetUser(int id) => Ok(_userRepastory.GetUsersById(id));
        [HttpPut]
        public async Task<IActionResult> UpdateUser(int id, Users user) => Ok(_userRepastory.UpdateUser(id,user));
        [HttpPost]
        public async Task<IActionResult> CreateUser(Users user) => Ok(_userRepastory.CreateUser(user));
        [HttpDelete]
        public async Task<IActionResult> DeleteUser(int id) => Ok(_userRepastory?.DeleteUser(id));

    }
}
