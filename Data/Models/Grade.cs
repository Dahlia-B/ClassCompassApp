using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using ClassCompassApp.Data;
[Table("Grades")]
public class Grade
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    public int StudentId { get; set; }
    public int TeacherId { get; set; }
    public int ClassId { get; set; }

    public int ClassRoomId { get; set; }
    public ClassRoom ClassRoom { get; set; } = null!;

    public string Subject { get; set; } = string.Empty;
    public string AssignmentName { get; set; } = string.Empty;
    public string AssignmentType { get; set; } = string.Empty; // Test, Quiz, Homework, Project

    public double? Score { get; set; } // Nullable to support missing grades
    public double MaxScore { get; set; }
    public DateTime DateRecorded { get; set; }
    public string Comments { get; set; } = string.Empty;
    public bool IsExcused { get; set; } = false;

    public Student? Student { get; set; }


    [Ignore]
    public double Percentage => MaxScore > 0 && Score.HasValue ? Math.Round((Score.Value / MaxScore) * 100, 2) : 0;

    [Ignore]
    public string DisplayGrade => IsExcused ? "Excused" : $"{Score?.ToString() ?? "N/A"}/{MaxScore} ({Percentage}%)";

    [Ignore]
    public string FormattedDate => DateRecorded.ToString("MMM dd, yyyy");
}