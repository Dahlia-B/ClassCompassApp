using System.ComponentModel.DataAnnotations;

namespace ClassCompassApp.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Username { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string Role { get; set; } = string.Empty; // "Teacher", "Student", "Admin"

        public int? TeacherId { get; set; }
        public int? StudentId { get; set; }

        // Navigation properties
        public virtual Teacher? Teacher { get; set; }
        public virtual Student? Student { get; set; }
    }
}