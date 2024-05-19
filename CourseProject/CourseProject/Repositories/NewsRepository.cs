using CourseProject.Consults;
using CourseProject.Models;

namespace CourseProject.Repositories
{
    internal class NewsRepository : IRepository<News>
    {
        private MainContext db;

        public NewsRepository(MainContext db)
        {
            this.db = db;
        }

        public IEnumerable<News> GetAll()
        {
            return db.News;
        }

        public News Get(int id)
        {
            return db.News.Find(id);
        }

        public void Create(News news)
        {
            db.News.Add(news);
        }

        public void Update(News news)
        {
            try
            {
                db.Attach(news);
            }
            catch { }
            db.Update(news);
        }

        public void Delete(int id)
        {
            News news = db.News.Find(id);
            if (news != null)
            {
                db.News.Remove(news);
            }
        }
    }
}
