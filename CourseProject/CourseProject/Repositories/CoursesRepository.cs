using CourseProject.Consults;
using CourseProject.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseProject.Repositories
{
    internal class CoursesRepository : IRepository<Course>
    {
        private MainContext db;

        public CoursesRepository(MainContext db)
        {
            this.db = db;
        }

        public IEnumerable<Course> GetAll()
        {
            return db.Courses.AsSplitQuery()
                .Include(c => c.Groups)
                    .ThenInclude(g => g.Students)
                        .ThenInclude(s => s.Progresses)
                .Include(c => c.Groups)
                    .ThenInclude(g => g.Students).
                        ThenInclude(s => s.Requests)
                .Include(c => c.Groups)
                    .ThenInclude(g => g.Timetables)
                        .ThenInclude(t => t.Subjects)
                            .ThenInclude(s => s.Progresses)
                .Include(c => c.Groups)
                    .ThenInclude(g => g.Timetables)
                        .ThenInclude(t => t.Subjects)
                            .ThenInclude(s => s.Auditorium)
                .Include(c => c.Groups)
                    .ThenInclude(g => g.Timetables)
                        .ThenInclude(t => t.Subjects)
                            .ThenInclude(s => s.Teacher)
                .Include(c => c.Teachers);
        }

        public Course Get(int id)
        {
            return db.Courses.Find(id);
        }

        public void Create(Course course)
        {
            db.Courses.Add(course);
        }

        public void Update(Course course)
        {
            try
            {
                db.Attach(course);
            }
            catch { }
            db.Update(course);
        }

        public void Delete(int id)
        {
            Course course = db.Courses.Find(id);
            if (course != null)
            {
                db.Courses.Remove(course);
            }
        }
    }
}
