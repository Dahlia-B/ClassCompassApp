namespace ClassCompassAPI.Data.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int TeacherId { get; set; }
        public int ClassId { get; set; }
        public string Subject { get; set; } = string.Empty;
        public string AssignmentName { get; set; } = string.Empty;
        public string AssignmentType { get; set; } = string.Empty;
        public double? Score { get; set; }
        public double MaxScore { get; set; }
        public DateTime DateRecorded { get; set; }
        public string Comments { get; set; } = string.Empty;
        public bool IsExcused { get; set; } = false;
    }
}
