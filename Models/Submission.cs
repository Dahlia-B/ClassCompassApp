namespace ClassCompassAPI.Models
{
    public class HomeworkSubmission
    {
        public int Id { get; set; }
        public int AssignmentId { get; set; }
        public int StudentId { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime SubmittedAt { get; set; }
        public string? Grade { get; set; }
    }

    public class Submission
    {
        public int Id { get; set; }
        public int AssignmentId { get; set; }
        public int StudentId { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime SubmittedAt { get; set; }
    }
}