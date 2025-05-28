namespace ClassCompassAPI.Data.Models
{

    public class Submission
    {
        public int Id { get; set; }
        public int AssignmentId { get; set; }
        public int StudentId { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime SubmittedAt { get; set; }
    }
}