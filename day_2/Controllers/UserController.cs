using day_2.Dtos;
using day_2.Services;
using Microsoft.AspNetCore.Mvc;

namespace day_2.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController(IUserService userService) : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<UserDto[]>> GetUser([FromQuery] int? id = null, [FromQuery] string? name = null)
        {
            try
            {
                var user = await userService.GetUserAsync(id, name);
                return Ok(user);
            }
            catch (KeyNotFoundException)
            {
                return NotFound("User not found");
            }
        }
    }
}
