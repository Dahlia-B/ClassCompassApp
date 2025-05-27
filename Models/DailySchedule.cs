using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassCompassApp.Models
{
    public class DailySchedule
    {
        public string Date { get; set; } = string.Empty;
        public string DayOfWeek { get; set; } = string.Empty;
        public List<ClassPeriod> Periods { get; set; } = new();
        public bool NotificationsEnabled { get; set; } = false;

        [Ignore]
        public bool HasClasses => Periods.Any();

        [Ignore]
        public ClassPeriod? NextClass => Periods
            .Where(p => p.IsUpcoming)
            .OrderBy(p => p.StartTime)
            .FirstOrDefault();

        [Ignore]
        public ClassPeriod? CurrentClass => Periods
            .FirstOrDefault(p => p.IsActive);
    }
}
