using Microsoft.EntityFrameworkCore;
using ITI_Project.Models;

namespace ITI_Project.Contex
{
    public class MyContex : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-M284REV\\SQLEXPRESS; Database = ITI_Project ; Trusted_Connection = true ; Encrypt = false");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Trainee_Course>()
           .HasKey(ci => new { ci.CourseId, ci.TraineeId });
            modelBuilder.Entity<Trainee>()
           .Property(u => u.Id)
           .ValueGeneratedNever();
            modelBuilder.Entity<Instructor>()
           .Property(u => u.InstructorId)
           .ValueGeneratedNever();
            modelBuilder.Entity<Trainee_Course>()
		   .Property(u => u.TraineeId)
		   .ValueGeneratedNever();
			modelBuilder.Entity<Trainee_Course>()
           .Property(u => u.CourseId)
           .ValueGeneratedNever();
		}
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Trainee_Course> Trainee_Courses { get; set; }
    }
}
