using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassCompassApp.Models
{
    [SQLite.Table("ClassRosters")]
    public class ClassRoster
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int StudentId { get; set; }
        public int TeacherId { get; set; }
        public string Subject { get; set; } = string.Empty;
        public DateTime EnrollmentDate { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
