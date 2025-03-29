using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Scrabble.Contracts.Authentication;

namespace WebAPI.Controllers
{
    [Route("auth")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        [HttpPost("register")]
        public IActionResult Register(RegisterRequest registerRequest)
        {
            return Ok(registerRequest);
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequest loginRequest)
        {
            return Ok(loginRequest);
        }
    }
}
