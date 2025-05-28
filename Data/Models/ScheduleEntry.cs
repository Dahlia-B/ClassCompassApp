using SQLite;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassCompassApp.Data
{
    // Enhanced ScheduleEntry with better randomization support
    [SQLite.Table("ScheduleEntries")]
    public class ScheduleEntry
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int TeacherId { get; set; }
        public string Subject { get; set; } = string.Empty;
        public string DayOfWeek { get; set; } = string.Empty; // Monday, Tuesday, etc.
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int WeekNumber { get; set; } // For weekly randomization
        public string Room { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;

        [Ignore]
        public string FormattedTime => $"{StartTime:hh\\:mm} - {EndTime:hh\\:mm}";

        [Ignore]
        public string DisplayText => $"{Subject} - {FormattedTime}";
    }
}
