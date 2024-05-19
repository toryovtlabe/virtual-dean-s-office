using CourseProject.Consults;
using CourseProject.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseProject.Repositories
{
    internal class GroupsRepository : IRepository<Group>
    {
        private MainContext db;

        public GroupsRepository(MainContext db)
        {
            this.db = db;
        }

        public IEnumerable<Group> GetAll()
        {
            return db.Groups.AsSplitQuery()
                .Include(g => g.Students)
                    .ThenInclude(s => s.Progresses)
                .Include(g => g.Students)
                    .ThenInclude(s => s.Requests)
                .Include(g => g.Timetables)
                    .ThenInclude(t => t.Subjects)
                        .ThenInclude(s => s.Teacher)
                .Include(g => g.Timetables)
                    .ThenInclude(t => t.Subjects)
                        .ThenInclude(s => s.Progresses)
                .Include(g => g.Timetables)
                    .ThenInclude(t => t.Subjects)
                        .ThenInclude(s => s.Auditorium);
        }

        public Group Get(int id)
        {
            return db.Groups.Find(id);
        }

        public void Create(Group group)
        {
            db.Groups.Add(group);
        }

        public void Update(Group group)
        {
            try
            {
                db.Attach(group);
            }
            catch { }
            db.Update(group);
        }

        public void Delete(int id)
        {
            Group group = db.Groups.Find(id);
            if (group != null)
            {
                db.Groups.Remove(group);
            }
        }
    }
}
