using System.ComponentModel.DataAnnotations;

namespace ClassCompassApp.Models;

public class HomeworkSubmission
{
    [Key]
    public int SubmissionId { get; set; }
    public required string HomeworkId { get; set; }
    public required string StudentId { get; set; }
    public string? FileURL { get; set; }
    public string? Content { get; set; }
    public DateTime SubmittedDate { get; set; } = DateTime.Now;
    public string Status { get; set; } = "Submitted";
    public int? Grade { get; set; }
    public string? TeacherFeedback { get; set; }
}