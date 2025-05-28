using System;
using System.ComponentModel.DataAnnotations;

namespace ClassCompassApp.Data
{
    public class BehaviorRemark
    {
        [Key]
        public int Id { get; set; }

        public int StudentId { get; set; }

        [Required]
        [MaxLength(500)]
        public string Remark { get; set; } = string.Empty;

        [Required]
        public DateTime Date { get; set; }

        [MaxLength(100)]
        public string RemarkType { get; set; } = string.Empty; // "Positive", "Negative", "Neutral"

        [MaxLength(100)]
        public string CreatedBy { get; set; } = string.Empty; // Teacher/staff name

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Navigation property
        public virtual Student? Student { get; set; }
    }
}