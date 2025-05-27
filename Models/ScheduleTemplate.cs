using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCompassApp.Models
{
    [SQLite.Table("ScheduleTemplates")]
    public class ScheduleTemplate
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int SchoolId { get; set; }
        public int ClassId { get; set; }
        public string Subject { get; set; } = string.Empty;
        public int PeriodsPerWeek { get; set; }
        public int Duration { get; set; } // in minutes
        public string PreferredDays { get; set; } = string.Empty; // JSON array of preferred days
        public bool IsCore { get; set; } = true; // Core subjects vs electives
    }
}
