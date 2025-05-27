using ClassCompassAPI.Models;
using ClassCompassAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ClassCompassAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BehaviorController : ControllerBase
    {
        private readonly IBehaviorService _behaviorService;

        public BehaviorController(IBehaviorService behaviorService)
        {
            _behaviorService = behaviorService;
        }

        // POST: api/behavior/{studentId}
        [HttpPost("{studentId}")]
        public async Task<IActionResult> RecordBehavior(string studentId, [FromBody] BehaviorRecord record)
        {
            if (record == null)
                return BadRequest("Invalid behavior record data.");

            await _behaviorService.RecordBehavior(studentId, record);
            return Ok(new { Message = "Behavior recorded successfully!" });
        }

        // GET: api/behavior/{studentId}
        [HttpGet("{studentId}")]
        public async Task<IActionResult> GetBehaviorRecords(string studentId)
        {
            var records = await _behaviorService.GetBehaviorRecords(studentId);
            return records != null && records.Any()
                ? Ok(records)
                : NotFound("No behavior records found for this student.");
        }
    }
}
