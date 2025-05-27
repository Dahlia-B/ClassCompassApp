using ClassCompassAPI.Models;
using ClassCompassAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ClassCompassAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeworkController : ControllerBase
    {
        private readonly IHomeworkService _homeworkService;

        public HomeworkController(IHomeworkService homeworkService)
        {
            _homeworkService = homeworkService;
        }

        [HttpPost("assign")]
        public async Task<IActionResult> AssignHomework([FromBody] HomeworkAssignment assignment)
        {
            if (assignment == null)
                return BadRequest("Invalid assignment data.");

            await _homeworkService.AssignHomework(assignment);
            return Ok(new { Message = "Homework assigned successfully!" });
        }

        [HttpPost("upload")]
        public async Task<IActionResult> UploadHomework([FromBody] HomeworkSubmission submission)
        {
            if (submission == null)
                return BadRequest("Invalid submission data.");

            await _homeworkService.SubmitHomework(submission);
            return Ok(new { Message = "Homework submitted successfully!" });
        }

        [HttpPost("grade")]
        public async Task<IActionResult> GradeHomework([FromBody] HomeworkGrade grade)
        {
            if (grade == null)
                return BadRequest("Invalid grade data.");

            await _homeworkService.GradeHomework(grade);
            return Ok(new { Message = "Homework graded successfully!" });
        }
    }
}
