using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCompassApp.Models
{
    [SQLite.Table("Notifications")]
    public class Notification
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserType { get; set; } = string.Empty; // Student, Teacher
        public string Title { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty; // ClassReminder, Grade, Behavior, General
        public DateTime ScheduledTime { get; set; }
        public DateTime? SentTime { get; set; }
        public bool IsRead { get; set; } = false;
        public bool IsSent { get; set; } = false;
        public string RelatedId { get; set; } = string.Empty; // ClassId, GradeId, etc.

        [Ignore]
        public bool IsPending => !IsSent && DateTime.Now >= ScheduledTime;

        [Ignore]
        public string FormattedTime => ScheduledTime.ToString("h:mm tt");
    }
}

