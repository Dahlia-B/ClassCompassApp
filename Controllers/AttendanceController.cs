using ClassCompassAPI.Data.Models;
using ClassCompassAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ClassCompassAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AttendanceController : ControllerBase
    {
        private readonly AttendanceService _attendanceService;

        public AttendanceController(AttendanceService attendanceService)
        {
            _attendanceService = attendanceService;
        }

        // POST: api/attendance/{studentId}
        [HttpPost("{studentId}")]
        public async Task<IActionResult> MarkAttendance(string studentId, [FromBody] Attendance record)
        {
            if (record == null)
            {
                return BadRequest("Attendance record is required.");
            }

            var result = await _attendanceService.MarkAttendance(studentId, record);

            if (!result)
            {
                return StatusCode(500, "Failed to record attendance.");
            }

            return Ok(new { Message = "Attendance recorded successfully!" });
        }

        // GET: api/attendance/{studentId}
        [HttpGet("{studentId}")]
        public async Task<IActionResult> GetAttendanceHistory(string studentId)
        {
            var records = await _attendanceService.GetAttendanceRecords(studentId);

            if (records == null || records.Count == 0)
            {
                return NotFound(new { Message = "No attendance records found." });
            }

            return Ok(records);
        }
    }
}