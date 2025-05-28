namespace ClassCompassAPI.Data.Models
{
    public class HomeworkAssignment
    {
        public string HomeworkId { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string TeacherId { get; set; } = string.Empty;
        public string ClassId { get; set; } = string.Empty;
        public string DueDate { get; set; } = string.Empty; 
    }
}