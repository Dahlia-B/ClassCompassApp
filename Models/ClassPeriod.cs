namespace ClassCompassApp.Models
{
    public class ClassPeriod
    {
        public string Name { get; set; } = string.Empty;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public bool IsUpcoming => StartTime > DateTime.Now;
        public bool IsActive => StartTime <= DateTime.Now && EndTime >= DateTime.Now;
    }
}