using System;
using System.Threading.Tasks;
using WebApi.Model;
using Microsoft.AspNetCore.Mvc;
using WebApi.Data.UserMemory;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserServices UserServices;

        public UserController(IUserServices userServices)
        {
            UserServices = userServices;
        }

        [HttpGet]
        public async Task<ActionResult<User>> ValidateUser([FromQuery] string? username, [FromQuery] string? password)
        {
            Console.WriteLine("Here");
            try
            {
                var user = UserServices.ValidateUser(username, password);
                return Ok(user.Result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}