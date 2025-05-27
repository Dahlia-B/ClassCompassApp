using System.ComponentModel.DataAnnotations;

namespace ClassCompassAPI.Models
{
    public class Homework
    {
        [Key] public string HomeworkId { get; set; }
        public string ClassId { get; set; }
        public string TeacherId { get; set; }
        public string DueDate { get; set; }
    }
}