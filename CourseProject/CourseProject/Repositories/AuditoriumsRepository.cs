using CourseProject.Consults;
using CourseProject.Models;

namespace CourseProject.Repositories
{
    internal class AuditoriumsRepository : IRepository<Auditorium>
    {
        private MainContext db;

        public AuditoriumsRepository(MainContext db)
        {
            this.db = db;
        }

        public IEnumerable<Auditorium> GetAll()
        {
            return db.Auditoriums;
        }

        public Auditorium Get(int id)
        {
            return db.Auditoriums.Find(id);
        }

        public void Create(Auditorium auditorium)
        {
            db.Auditoriums.Add(auditorium);
        }

        public void Update(Auditorium auditorium)
        {
            try
            {
                db.Attach(auditorium);
            }
            catch { }
            db.Update(auditorium);
        }

        public void Delete(int id)
        {
            Auditorium auditorium = db.Auditoriums.Find(id);
            if (auditorium != null)
            {
                db.Auditoriums.Remove(auditorium);
            }
        }
    }
}
