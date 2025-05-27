using ClassCompassAPI.Models;
using ClassCompassAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ClassCompassAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ScheduleController : ControllerBase
    {
        private readonly ScheduleService _scheduleService;

        public ScheduleController(ScheduleService scheduleService)
        {
            _scheduleService = scheduleService;
        }

        [HttpPost("generate")]
        public async Task<IActionResult> GenerateSchedule([FromBody] ScheduleRequest request)
        {
            if (request == null)
                return BadRequest("Invalid schedule request.");

            var schedule = await _scheduleService.GenerateWeeklySchedule(request);
            return Ok(schedule);
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateSchedule([FromBody] ScheduleUpdate update)
        {
            if (update == null)
                return BadRequest("Invalid schedule update.");

            await _scheduleService.UpdateClassSchedule(update);
            return Ok(new { Message = "Schedule updated successfully!" });
        }

        [HttpGet("class/{classId}")]
        public async Task<IActionResult> GetClassSchedule(string classId)
        {
            var schedule = await _scheduleService.GetClassSchedule(classId);
            return schedule != null ? Ok(schedule) : NotFound("Schedule not found for the class.");
        }

        [HttpGet("teacher/{teacherId}")]
        public async Task<IActionResult> GetTeacherSchedule(string teacherId)
        {
            var schedule = await _scheduleService.GetTeacherSchedule(teacherId);
            return schedule != null ? Ok(schedule) : NotFound("Schedule not found for the teacher.");
        }
    }
}
