using CourseProject.Consults;
using CourseProject.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseProject.Repositories
{
    internal class UsersRepository : IRepository<User>
    {
        private MainContext db;
        public UsersRepository(MainContext db)
        {
            this.db = db;
        }

        public IEnumerable<User> GetAll()
        {
            return db.Users.Include(u => u.Student)
                                .ThenInclude(s => s.Progresses)
                           .Include(u => u.Student)
                                .ThenInclude(s => s.Requests);
        }

        public User Get(int id)
        {
            return db.Users.Find(id);
        }

        public void Create(User user)
        {
            db.Users.Add(user);
        }

        public void Update(User user)
        {
            try
            {
                db.Attach(user);
            }
            catch { }
            db.Update(user);
        }

        public void Delete(int id)
        {
            User user = db.Users.Find(id);
            if (user != null)
            {
                db.Users.Remove(user);
            }
        }
    }
}
