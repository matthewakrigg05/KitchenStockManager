using Microsoft.AspNetCore.Mvc;
using KitchenStockManager.Models.People.Users;

namespace KitchenStockManager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
        {
            var user = await UserManager.LogIn(loginRequest.Email, loginRequest.Password);

            if (user == null)
            {
                return Unauthorized();
            }

            return Ok(new { message = "Login successful", user = user.getEmail() });
        }
    }
}

