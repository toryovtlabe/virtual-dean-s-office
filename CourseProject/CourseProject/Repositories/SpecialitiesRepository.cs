using CourseProject.Consults;
using CourseProject.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseProject.Repositories
{
    internal class SpecialitiesRepository : IRepository<Speciality>
    {
        private MainContext db;

        public SpecialitiesRepository(MainContext db)
        {
            this.db = db;
        }

        public IEnumerable<Speciality> GetAll()
        {
            return db.Specialities.AsSplitQuery()
                .Include(s => s.Courses)
                    .ThenInclude(c => c.Groups)
                        .ThenInclude(g => g.Students)
                            .ThenInclude(s => s.Progresses)
                .Include(s => s.Courses)
                    .ThenInclude(c => c.Groups)
                        .ThenInclude(g => g.Students)
                            .ThenInclude(s => s.Requests)
                .Include(s => s.Courses)
                    .ThenInclude(c => c.Groups)
                        .ThenInclude(g => g.Timetables)
                            .ThenInclude(t => t.Subjects)
                                .ThenInclude(s => s.Progresses)
                .Include(s => s.Courses)
                    .ThenInclude(c => c.Groups)
                        .ThenInclude(g => g.Timetables)
                            .ThenInclude(t => t.Subjects)
                                .ThenInclude(s => s.Auditorium)
                .Include(s => s.Courses)
                    .ThenInclude(c => c.Groups)
                        .ThenInclude(g => g.Timetables)
                            .ThenInclude(t => t.Subjects)
                                .ThenInclude(s => s.Teacher)
                .Include(s => s.Courses)
                    .ThenInclude(c => c.Teachers);
        }

        public Speciality Get(int id)
        {
            return db.Specialities.Find(id);
        }

        public void Create(Speciality spec)
        {
            db.Specialities.Add(spec);
        }

        public void Update(Speciality spec)
        {
            try
            {
                db.Attach(spec);
            }
            catch { }
            db.Update(spec);
        }

        public void Delete(int id)
        {
            Speciality spec = db.Specialities.Find(id);
            if (spec != null)
            {
                db.Specialities.Remove(spec);
            }
        }
    }
}
