using ClassCompassAPI.Data.Models;
using ClassCompassAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ClassCompassAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly SupabaseAuthService _supabaseAuthService;

        public AuthenticationController(SupabaseAuthService supabaseAuthService)
        {
            _supabaseAuthService = supabaseAuthService;
        }

        // POST: api/authentication/login
        [HttpPost("login")]
        public async Task<IActionResult> SecureLogin([FromBody] LoginRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Name) || string.IsNullOrWhiteSpace(request.Password))
            {
                return BadRequest("Name and password are required.");
            }

            var user = await _supabaseAuthService.AuthenticateUser(request.Name, request.Password);

            if (user != null)
            {
                return Ok(user); // Return user info or token as needed
            }

            return Unauthorized(new { Message = "Invalid credentials." });
        }
    }
}