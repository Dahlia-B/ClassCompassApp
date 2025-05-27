namespace ClassCompassAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty; // Student, Teacher, Parent
        public DateTime CreatedAt { get; set; }
    }
}