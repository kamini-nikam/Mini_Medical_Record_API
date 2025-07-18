using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mini_Medical_Record_API.Application.Login;
using Mini_Medical_Record_API.Domain.Login;

namespace Mini_Medical_Record_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ILogin _login;

        public AuthController(ILogin login)
        {
            _login = login;
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginResponse loginRequest)
        {
            if (loginRequest == null)
            {
                return BadRequest("Invalid login request.");
            }
            var response = await _login.Login(loginRequest);
            if (response == null)
            {
                return Unauthorized("Invalid username or password.");
            }
            return Ok(response);
        }
        [HttpPost("logout")]
        public IActionResult Logout()
        {
            // Implement logout logic here, such as clearing session or token
            return Ok("Logged out successfully.");
        }
        [HttpPost("Registration")]
        public async Task<IActionResult> Register(RegisterResponse Regres)
        {
            if (Regres == null)
            {
                return BadRequest("Invalid registration request.");
            }

            return Ok(await _login.UserRegistration(Regres));
        }
    }
}
