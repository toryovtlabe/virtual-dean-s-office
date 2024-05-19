using CourseProject.Consults;
using CourseProject.Models;

namespace CourseProject.Repositories
{
    internal class TeachersRepository : IRepository<Teacher>
    {
        private MainContext db;

        public TeachersRepository(MainContext db)
        {
            this.db = db;
        }

        public IEnumerable<Teacher> GetAll()
        {
            return db.Teachers;
        }

        public Teacher Get(int id)
        {
            return db.Teachers.Find(id);
        }

        public void Create(Teacher teacher)
        {
            db.Teachers.Add(teacher);
        }

        public void Update(Teacher teacher)
        {
            try
            {
                db.Attach(teacher);
            }
            catch { }
            db.Update(teacher);
        }

        public void Delete(int id)
        {
            Teacher teacher = db.Teachers.Find(id);
            if (teacher != null)
            {
                db.Teachers.Remove(teacher);
            }
        }
    }
}
