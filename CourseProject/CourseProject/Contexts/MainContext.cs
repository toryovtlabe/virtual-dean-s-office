using CourseProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace CourseProject.Consults
{
    internal class MainContext : DbContext
    {
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Progress> Progresses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Timetable> Timetables { get; set; }
        public DbSet<Auditorium> Auditoriums { get; set; }

        readonly string CS = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("data source=CourseProject.db");
            base.OnConfiguring(optionsBuilder);
        }

        public MainContext()
        {
            Database.EnsureCreated();
        }

    }
}
