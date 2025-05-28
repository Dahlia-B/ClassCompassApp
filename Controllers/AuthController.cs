using ClassCompassAPI.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ClassCompassAPI.Data.Models;

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
    }
}