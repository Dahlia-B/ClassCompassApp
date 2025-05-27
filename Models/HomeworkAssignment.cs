namespace ClassCompassAPI.Models
{
    public class HomeworkAssignment
    {
        public string HomeworkId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string TeacherId { get; set; }
        public string ClassId { get; set; }
        public string DueDate { get; set; }
    }
}