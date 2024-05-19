using CourseProject.Helpers;
using CourseProject.Models;
using CourseProject.Views;
using GalaSoft.MvvmLight.Messaging;

namespace CourseProject.ViewModels
{
    internal class MainWindowVM : ObservableObject
    {
        private static MainWindowVM? instance;
        private List<object> ViewModelsCollection;
        private MyCommand goToPerfomance;
        private MyCommand goToTimetable;
        private MyCommand goToNews;
        private MyCommand goToProfile;
        private MyCommand goToAuthorization;
        private MyCommand goToStudents;
        private MyCommand goToRequest;
        private User authorizedUser;
        private string visibillityStudents = "hidden";
        private string visibillityProfile = "visible";

        private object selectedPage;
        public object SelectedPage
        {
            get { return selectedPage; }
            set
            {
                selectedPage = value;
                OnPropertyChanged(nameof(SelectedPage));
            }
        }

        public string VisibillityStudents
        {
            get
            {
                return visibillityStudents;
            }
            set
            {
                visibillityStudents = value;
                OnPropertyChanged("VisibillityStudents");
            }
        }

        public string VisibillityProfile
        {
            get
            {
                return visibillityProfile;
            }
            set
            {
                visibillityProfile = value;
                OnPropertyChanged("VisibillityProfile");
            }
        }

        public MyCommand GoToNews
        {
            get
            {
                return goToNews ?? (goToNews = new MyCommand(
                    (obj) =>
                    {
                        Messenger.Default.Send(authorizedUser, "authorizedUser");
                        SelectedPage = ViewModelsCollection[0];
                        ViewModelsCollection[1] = new Perfomance();
                        ViewModelsCollection[2] = new Views.Timetable();
                        ViewModelsCollection[3] = new Profile();
                    },
                    (obj) =>
                    {
                        return SelectedPage != ViewModelsCollection[0];
                    }));
            }
        }

        public MyCommand GoToPerfomance
        {
            get
            {
                return goToPerfomance ?? (goToPerfomance = new MyCommand(
                    (obj) =>
                    {
                        Messenger.Default.Send(authorizedUser, "toPerfomance");
                        SelectedPage = ViewModelsCollection[1];
                        ViewModelsCollection[0] = new Views.News();
                        ViewModelsCollection[2] = new Views.Timetable();
                        ViewModelsCollection[3] = new Profile();
                    },
                    (obj) =>
                    {
                        return SelectedPage != ViewModelsCollection[1];
                    }));
            }
        }

        public MyCommand GoToTimetable
        {
            get
            {
                return goToTimetable ?? (goToTimetable = new MyCommand(
                    (obj) =>
                    {
                        ViewModelsCollection[2] = new Views.Timetable();
                        Messenger.Default.Send(authorizedUser, "toTimetable");
                        SelectedPage = ViewModelsCollection[2];
                        ViewModelsCollection[0] = new Views.News();
                        ViewModelsCollection[1] = new Perfomance();
                        ViewModelsCollection[3] = new Profile();
                    },
                    (obj) =>
                    {
                        return SelectedPage != ViewModelsCollection[2];
                    }));
            }
        }

        public MyCommand GoToRequest
        {
            get
            {
                return goToRequest ?? (goToRequest = new MyCommand(
                    (obj) =>
                    {
                        SelectedPage = ViewModelsCollection[5];
                        ViewModelsCollection[0] = new Views.News();
                        ViewModelsCollection[1] = new Perfomance();
                        ViewModelsCollection[2] = new Views.Timetable();
                        ViewModelsCollection[3] = new Profile();
                    },
                    (obj) =>
                    {
                        return SelectedPage != ViewModelsCollection[5];
                    }));
            }
        }

        public MyCommand GoToProfile
        {
            get
            {
                return goToProfile ?? (goToProfile = new MyCommand(
                    (obj) =>
                    {
                        Messenger.Default.Send(authorizedUser, "toProfile");
                        SelectedPage = ViewModelsCollection[3];
                        ViewModelsCollection[0] = new Views.News();
                        ViewModelsCollection[1] = new Perfomance();
                        ViewModelsCollection[2] = new Views.Timetable();
                    },
                    (obj) =>
                    {
                        return SelectedPage != ViewModelsCollection[3];
                    }));
            }
        }

        public MyCommand GoToStudents
        {
            get
            {
                return goToStudents ?? (goToStudents = new MyCommand(
                    (obj) =>
                    {
                        SelectedPage = ViewModelsCollection[4];
                        ViewModelsCollection[0] = new Views.News();
                        ViewModelsCollection[1] = new Perfomance();
                        ViewModelsCollection[2] = new Views.Timetable();
                    },
                    (obj) =>
                    {
                        return SelectedPage != ViewModelsCollection[4];
                    }));
            }
        }

        public MyCommand GoToAuthorization
        {
            get
            {
                return goToAuthorization ?? (goToAuthorization = new MyCommand(
                    (obj) =>
                    {
                        AuthorizationWindow authorizationWindow = new AuthorizationWindow();
                        authorizationWindow.Show();
                        App.Current.Windows[0].Close();
                        SelectedPage = ViewModelsCollection[0];
                    }));
            }
        }

        private void check(User user)
        {
            authorizedUser = user;
            if (authorizedUser.Student != null)
            {
                VisibillityProfile = "visible";
                VisibillityStudents = "hidden";
            }
            else
            {
                VisibillityProfile = "hidden";
                VisibillityStudents = "visible";
            }
            Messenger.Default.Send(authorizedUser, "authorizedUser");
        }


        public MainWindowVM()
        {
            Messenger.Default.Register<User>(this, "logging", check);

            ViewModelsCollection = [new Views.News(), new Perfomance(), new Views.Timetable(), new Profile(), new Students(), new RequestView()];
            SelectedPage = ViewModelsCollection[0];
        }

        public static MainWindowVM getInstance()
        {
            if (instance == null)
            {
                instance = new();
            }
            return instance;
        }
    }
}
