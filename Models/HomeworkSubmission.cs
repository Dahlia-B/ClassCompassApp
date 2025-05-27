using System;

namespace ClassCompassAPI.Models
{
    public class HomeworkSubmission
    {
        public int SubmissionId { get; set; } // Primary key for EF Core, optional if not using EF
        public string HomeworkId { get; set; }
        public string StudentId { get; set; }
        public string FileURL { get; set; }
        public string Content { get; set; }
        public DateTime SubmittedDate { get; set; }
        public string Status { get; set; }
        public int? Grade { get; set; }
        public string TeacherFeedback { get; set; }
    }
}