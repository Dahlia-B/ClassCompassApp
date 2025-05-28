using ClassCompassAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;
using ClassCompassAPI.Data.Models;

namespace ClassCompassAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GradesController : ControllerBase
    {
        private readonly GradesService _gradesService;

        public GradesController(GradesService gradesService)
        {
            _gradesService = gradesService;
        }

        // POST: api/grades/{studentId}
        [HttpPost("{studentId}")]
        public async Task<IActionResult> AssignGrade(string studentId, [FromBody] Grade grade)
        {
            if (grade == null)
                return BadRequest("Invalid grade data.");

            await _gradesService.AssignGrade(studentId, grade);
            return Ok(new { Message = "Grade assigned successfully!" });
        }

        // GET: api/grades/{studentId}
        [HttpGet("{studentId}")]
        public async Task<IActionResult> GetGrades(string studentId)
        {
            var grades = await _gradesService.GetGrades(studentId);
            return grades != null && grades.Any()
                ? Ok(grades)
                : NotFound("No grades found for this student.");
        }
    }
}