using ClassCompassAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.Data;

namespace ClassCompassAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly FirebaseAuthService _firebaseAuthService;

        public AuthenticationController(FirebaseAuthService firebaseAuthService)
        {
            _firebaseAuthService = firebaseAuthService;
        }

        // POST: api/authentication/login
        [HttpPost("login")]
        public async Task<IActionResult> SecureLogin([FromBody] LoginRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Email) || string.IsNullOrWhiteSpace(request.Password))
            {
                return BadRequest("Email and password are required.");
            }

            var user = await _firebaseAuthService.AuthenticateUser(request.Email, request.Password);

            if (user != null)
            {
                return Ok(user); // ניתן להחזיר כאן טוקן JWT אם תוסיף אותו ב־FirebaseAuthService
            }

            return Unauthorized(new { Message = "Invalid credentials." });
        }
    }
}
