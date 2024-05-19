using CourseProject.Consults;

namespace CourseProject.Repositories
{
    internal class UnitOfWork : IDisposable
    {
        private MainContext db = new MainContext();
        private UsersRepository usersRepository;
        private CoursesRepository coursesRepository;
        private GroupsRepository groupsRepository;
        private ProgressesRepository progressesRepository;
        private StudentsRepository studentsRepository;
        private SubjectsRepository subjectsRepository;
        private NewsRepository newsRepository;
        private TimetablesRepository timetablesRepository;
        private RequestsRepository requestsRepository;
        private AuditoriumsRepository auditoriumsRepository;
        private TeachersRepository teachersRepository;
        private SpecialitiesRepository specialitiesRepository;

        public UsersRepository Users
        {
            get
            {
                if (usersRepository == null)
                {
                    usersRepository = new UsersRepository(db);
                }
                return usersRepository;
            }
        }

        public CoursesRepository Courses
        {
            get
            {
                if (coursesRepository == null)
                {
                    coursesRepository = new CoursesRepository(db);
                }
                return coursesRepository;
            }
        }

        public GroupsRepository Groups
        {
            get
            {
                if (groupsRepository == null)
                {
                    groupsRepository = new GroupsRepository(db);
                }
                return groupsRepository;
            }
        }

        public StudentsRepository Students
        {
            get
            {
                if (studentsRepository == null)
                {
                    studentsRepository = new StudentsRepository(db);
                }
                return studentsRepository;
            }
        }

        public SubjectsRepository Subjects
        {
            get
            {
                if (subjectsRepository == null)
                {
                    subjectsRepository = new SubjectsRepository(db);
                }
                return subjectsRepository;
            }
        }

        public ProgressesRepository Progresses
        {
            get
            {
                if (progressesRepository == null)
                {
                    progressesRepository = new ProgressesRepository(db);
                }
                return progressesRepository;
            }
        }

        public NewsRepository NewsRepository
        {
            get
            {
                if (newsRepository == null)
                {
                    newsRepository = new NewsRepository(db);
                }
                return newsRepository;
            }
        }

        public SpecialitiesRepository Specialities
        {
            get
            {
                if (specialitiesRepository == null)
                {
                    specialitiesRepository = new SpecialitiesRepository(db);
                }
                return specialitiesRepository;
            }
        }

        public TimetablesRepository Timetables
        {
            get
            {
                if (timetablesRepository == null)
                {
                    timetablesRepository = new TimetablesRepository(db);
                }
                return timetablesRepository;
            }
        }

        public TeachersRepository Teachers
        {
            get
            {
                if (teachersRepository == null)
                {
                    teachersRepository = new TeachersRepository(db);
                }
                return teachersRepository;
            }
        }

        public RequestsRepository Requests
        {
            get
            {
                if (requestsRepository == null)
                {
                    requestsRepository = new RequestsRepository(db);
                }
                return requestsRepository;
            }
        }

        public AuditoriumsRepository Auditoriums
        {
            get
            {
                if (auditoriumsRepository == null)
                {
                    auditoriumsRepository = new AuditoriumsRepository(db);
                }
                return auditoriumsRepository;
            }
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            try
            {
                db.SaveChanges();
            }
            catch { }
        }

        public MainContext GetContext()
        {
            return db;
        }
    }
}
