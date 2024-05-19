using CourseProject.Consults;
using CourseProject.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseProject.Repositories
{
    internal class ProgressesRepository : IRepository<Progress>
    {
        private MainContext db;

        public ProgressesRepository(MainContext db)
        {
            this.db = db;
        }

        public IEnumerable<Progress> GetAll()
        {
            return db.Progresses.Include(p => p.Subject);
        }

        public Progress Get(int id)
        {
            return db.Progresses.Find(id);
        }

        public void Create(Progress progress)
        {
            db.Progresses.Add(progress);
        }

        public void Update(Progress progress)
        {
            try
            {
                db.Attach(progress);
            }
            catch { }
            db.Update(progress);
        }

        public void Delete(int id)
        {
            Progress progress = db.Progresses.Find(id);
            if (progress != null)
            {
                db.Progresses.Remove(progress);
            }
        }
    }
}
