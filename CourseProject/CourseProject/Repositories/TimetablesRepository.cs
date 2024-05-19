using CourseProject.Consults;
using CourseProject.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseProject.Repositories
{
    internal class TimetablesRepository : IRepository<Timetable>
    {
        private MainContext db;

        public TimetablesRepository(MainContext db)
        {
            this.db = db;
        }

        public IEnumerable<Timetable> GetAll()
        {
            return db.Timetables.Include(x => x.Subjects).ThenInclude(s => s.Progresses)
                                .Include(x => x.Subjects).ThenInclude(s => s.Auditorium)
                                .Include(x => x.Subjects).ThenInclude(s => s.Teacher);
        }

        public Timetable Get(int id)
        {
            return db.Timetables.Find(id);
        }

        public void Create(Timetable timetable)
        {
            db.Timetables.Add(timetable);
        }

        public void Update(Timetable timetable)
        {
            try
            {
                db.Attach(timetable);
            }
            catch { }
            db.Update(timetable);
        }

        public void Delete(int id)
        {
            Timetable timetable = db.Timetables.Find(id);
            if (timetable != null)
            {
                db.Timetables.Remove(timetable);
            }
        }
    }
}
