using CourseProject.Consults;
using CourseProject.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseProject.Repositories
{
    internal class StudentsRepository : IRepository<Student>
    {
        private MainContext db;

        public StudentsRepository(MainContext db)
        {
            this.db = db;
        }

        public IEnumerable<Student> GetAll()
        {
            return db.Students.Include(s => s.Progresses)
                                .Include(s => s.Requests);
        }

        public Student Get(int id)
        {
            return db.Students.Find(id);
        }

        public void Create(Student student)
        {
            db.Students.Add(student);
        }

        public void Update(Student student)
        {
            try
            {
                db.Attach(student);
            }
            catch { }
            db.Update(student);
        }

        public void Delete(int id)
        {
            Student student = db.Students.Find(id);
            if (student != null)
            {
                db.Students.Remove(student);
            }
        }
    }
}
