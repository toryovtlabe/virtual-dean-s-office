using CourseProject.Consults;
using CourseProject.Models;

namespace CourseProject.Repositories
{
    internal class RequestsRepository : IRepository<Request>
    {
        private MainContext db;

        public RequestsRepository(MainContext db)
        {
            this.db = db;
        }

        public IEnumerable<Request> GetAll()
        {
            return db.Requests;
        }

        public Request Get(int id)
        {
            return db.Requests.Find(id);
        }

        public void Create(Request request)
        {
            db.Requests.Add(request);
        }

        public void Update(Request request)
        {
            try
            {
                db.Attach(request);
            }
            catch { }
            db.Update(request);
        }

        public void Delete(int id)
        {
            Request request = db.Requests.Find(id);
            if (request != null)
            {
                db.Requests.Remove(request);
            }
        }
    }
}
