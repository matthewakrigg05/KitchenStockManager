using Microsoft.AspNetCore.Mvc;
using KitchenStockManager.Models.People.Users;

namespace KitchenStockManager.Controllers.PeopleControllers
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

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest registerRequest)
        {
            var user = await UserManager.RegisterUser(registerRequest.Email, registerRequest.Password, registerRequest.FirstName, registerRequest.LastName);
            if (user == null)
            {
                return BadRequest(new { message = "User already exists" });
            }
            return Ok(new { message = "Registration successful", user = user.getEmail() });
        }
    }
}

