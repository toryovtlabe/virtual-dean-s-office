using CourseProject.Consults;
using CourseProject.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseProject.Repositories
{
    internal class SubjectsRepository : IRepository<Subject>
    {
        private MainContext db;

        public SubjectsRepository(MainContext db)
        {
            this.db = db;
        }

        public IEnumerable<Subject> GetAll()
        {
            return db.Subjects.Include(x => x.Teacher)
                              .Include(x => x.Auditorium)
                              .Include(x => x.Progresses);
        }

        public Subject Get(int id)
        {
            return db.Subjects.Find(id);
        }

        public void Create(Subject subject)
        {
            db.Subjects.Add(subject);
        }

        public void Update(Subject subject)
        {
            try
            {
                db.Attach(subject);
            }
            catch { }
            db.Update(subject);
        }

        public void Delete(int id)
        {
            Subject subject = db.Subjects.Find(id);
            if (subject != null)
            {
                db.Subjects.Remove(subject);
            }
        }
    }
}
