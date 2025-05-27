using ClassCompassAPI.Services;
using ClassCompassAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ClassCompassAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IHomeworkService _homeworkService;

        public AuthController(IHomeworkService homeworkService)
        {
            _homeworkService = homeworkService;
        }

        // POST: api/auth/homework/assign
        [Authorize(Roles = "Teacher")]
        [HttpPost("homework/assign")]
        public async Task<IActionResult> AssignHomework([FromBody] HomeworkAssignment assignment)
        {
            if (assignment == null)
                return BadRequest("Invalid assignment data.");

            await _homeworkService.AssignHomework(assignment);
            return Ok(new { Message = "Homework assigned successfully!" });
        }

        // POST: api/auth/homework/upload
        [Authorize(Roles = "Student")]
        [HttpPost("homework/upload")]
        public async Task<IActionResult> UploadHomework([FromBody] HomeworkSubmission submission)
        {
            if (submission == null)
                return BadRequest("Invalid submission data.");

            await _homeworkService.SubmitHomework(submission);
            return Ok(new { Message = "Homework submitted successfully!" });
        }
    }
}
