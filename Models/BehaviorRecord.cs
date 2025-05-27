namespace ClassCompassAPI.Models
{
    public class BehaviorRecord
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string Behavior { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string Notes { get; set; } = string.Empty;
    }
}