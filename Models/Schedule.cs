namespace ClassCompassAPI.Models
{
    public class ScheduleRequest
    {
        public int StudentId { get; set; }
        public DateTime Date { get; set; }
        public string Subject { get; set; } = string.Empty;
    }

    public class ScheduleUpdate
    {
        public int Id { get; set; }
        public DateTime NewTime { get; set; }
        public string Subject { get; set; } = string.Empty;
    }
}