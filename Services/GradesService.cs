using System.Threading.Tasks;
using System.Collections.Generic;
using ClassCompassAPI.Data.Models;

namespace ClassCompassAPI.Services
{
    public class GradesService
    {
        public Task AssignGrade(string studentId, Grade grade)
        {
            // Implement logic here
            return Task.CompletedTask;
        }

        public Task<List<Grade>> GetGrades(string studentId)
        {
            // Implement logic here
            return Task.FromResult(new List<Grade>());
        }
    }
}