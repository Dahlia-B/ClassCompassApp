using ClassCompassAPI.Services;
using ClassCompassAPI.Models; // ודא ש-NotificationRequest נמצא במיקום הנכון
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ClassCompassAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificationController : ControllerBase
    {
        private readonly NotificationService _notificationService;

        public NotificationController(NotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpPost("send")]
        public async Task<IActionResult> SendNotification([FromBody] NotificationRequest request)
        {
            if (string.IsNullOrWhiteSpace(request?.UserId))
                return BadRequest("User ID is required.");

            await _notificationService.SendClassReminder(request.UserId);
            return Ok(new { Message = "Notification sent successfully!" });
        }
    }
}
