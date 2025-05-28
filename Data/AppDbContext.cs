using Microsoft.EntityFrameworkCore;

namespace ClassCompassApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<School> Schools { get; set; }
        public DbSet<ClassRoom> Classes { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<HomeworkSubmission> HomeworkSubmissions { get; set; }
        public DbSet<Grade> Grades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // School has many Classes (ClassRooms)
            modelBuilder.Entity<School>()
                .HasMany(s => s.Classes)
                .WithOne(c => c.School)
                .HasForeignKey(c => c.SchoolId)
                .OnDelete(DeleteBehavior.Cascade);

            // School has many Teachers
            modelBuilder.Entity<School>()
                .HasMany(s => s.Teachers)
                .WithOne(t => t.School)
                .HasForeignKey(t => t.SchoolId)
                .OnDelete(DeleteBehavior.Cascade);

            // ClassRoom has many Students
            modelBuilder.Entity<ClassRoom>()
                .HasMany(c => c.Students)
                .WithOne(s => s.ClassRoom)
                .HasForeignKey(s => s.ClassId)
                .OnDelete(DeleteBehavior.Cascade);

            // ClassRoom has many Attendance records
            modelBuilder.Entity<ClassRoom>()
                .HasMany(c => c.AttendanceRecords)
                .WithOne(a => a.ClassRoom)
                .HasForeignKey(a => a.ClassRoomId)
                .OnDelete(DeleteBehavior.Cascade);

            // ClassRoom has many HomeworkSubmissions
            modelBuilder.Entity<ClassRoom>()
                .HasMany(c => c.HomeworkSubmissions)
                .WithOne(h => h.ClassRoom)
                .HasForeignKey(h => h.ClassRoomId)
                .OnDelete(DeleteBehavior.Cascade);

            // ClassRoom has many Grades
            modelBuilder.Entity<ClassRoom>()
                .HasMany(c => c.Grades)
                .WithOne(g => g.ClassRoom)
                .HasForeignKey(g => g.ClassRoomId)
                .OnDelete(DeleteBehavior.Cascade);

            // ClassRoom has optional Teacher
            modelBuilder.Entity<ClassRoom>()
                .HasOne(c => c.Teacher)
                .WithMany(t => t.ClassRooms)
                .HasForeignKey(c => c.TeacherId)
                .OnDelete(DeleteBehavior.SetNull);

            // Student has one Teacher (Advisor)
            modelBuilder.Entity<Student>()
                .HasOne(s => s.Teacher)
                .WithMany(t => t.Students)
                .HasForeignKey(s => s.TeacherId)
                .OnDelete(DeleteBehavior.SetNull);

            // Attendance belongs to one Student
            modelBuilder.Entity<Attendance>()
                .HasOne(a => a.Student)
                .WithMany(s => s.AttendanceRecords)
                .HasForeignKey(a => a.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            // HomeworkSubmission belongs to one Student
            modelBuilder.Entity<HomeworkSubmission>()
                .HasOne(h => h.Student)
                .WithMany(s => s.HomeworkSubmissions)
                .HasForeignKey(h => h.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            // Grade belongs to one Student
            modelBuilder.Entity<Grade>()
                .HasOne(g => g.Student)
                .WithMany(s => s.Grades)
                .HasForeignKey(g => g.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure properties constraints or defaults as needed
            modelBuilder.Entity<Teacher>()
                .Property(t => t.Subject)
                .IsRequired();

            modelBuilder.Entity<ClassRoom>()
                .Property(c => c.Schedule)
                .IsRequired();

            // Additional configurations can be added here if needed
        }
    }
}
