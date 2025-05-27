namespace ClassCompassAPI.Models
{
    public class HomeworkGrade
    {
        public string HomeworkId { get; set; }
        public string StudentId { get; set; }
        public int Grade { get; set; }
        public string Feedback { get; set; }
    }
}