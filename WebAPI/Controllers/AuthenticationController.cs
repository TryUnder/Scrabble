using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Scrabble.Contracts.Authentication;
using Scrabble.Application.Services.Authentication;

namespace WebAPI.Controllers
{
    [Route("auth")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterRequest registerRequest)
        {
            var authResult = _authenticationService.Register(registerRequest.Login,
                registerRequest.Email,
                registerRequest.Password);

            var response = new AuthenticationResponse(
                authResult.user.Id,
                authResult.user.Login,
                authResult.user.Email,
                authResult.Token);

            return Ok(response);
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequest loginRequest)
        {
            var authResult = _authenticationService.Login(loginRequest.Email,
                loginRequest.Password);

            var response = new AuthenticationResponse(
                authResult.user.Id,
                authResult.user.Login,
                authResult.user.Email,
                authResult.Token);

            return Ok(response);
        }
    }
}
