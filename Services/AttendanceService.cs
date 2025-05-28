using System.Collections.Generic;
using System.Threading.Tasks;
using ClassCompassAPI.Data.Models;

namespace ClassCompassAPI.Services
{
    public class AttendanceService
    {
        // In-memory storage for demo; replace with DB logic as needed
        private static readonly Dictionary<string, List<Attendance>> _attendanceRecords = new();

        public async Task<bool> MarkAttendance(string studentId, Attendance record)
        {
            if (!_attendanceRecords.ContainsKey(studentId))
                _attendanceRecords[studentId] = new List<Attendance>();

            _attendanceRecords[studentId].Add(record);
            return await Task.FromResult(true);
        }

        public async Task<List<Attendance>> GetAttendanceRecords(string studentId)
        {
            _attendanceRecords.TryGetValue(studentId, out var records);
            return await Task.FromResult(records ?? new List<Attendance>());
        }
    }
}