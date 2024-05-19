using CourseProject.Helpers;
using CourseProject.Models;
using CourseProject.Repositories;
using GalaSoft.MvvmLight.Messaging;

namespace CourseProject.ViewModels
{
    internal class AuthorizationVM : ObservableObject
    {
        private string login;
        private string password;
        private string accessLogin = "transparent";
        private string accessPassword = "transparent";
        private User authorizatedUser;

        static UnitOfWork unitOfWork;
        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
                OnPropertyChanged("Login");
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }
        public string AccessLogin
        {
            get
            {
                return accessLogin;
            }
            set
            {
                accessLogin = value;
                OnPropertyChanged("AccessLogin");
            }
        }

        private bool checkLogin(String str)
        {
            if (unitOfWork.Users.GetAll().Count() == 0)
            {
                unitOfWork.Users.Create(new User() { Login = "admin", Password = "admin", Student = null });
                unitOfWork.Save();
            }
            if (unitOfWork.Specialities.GetAll().Count() == 0)
            {
                unitOfWork.Specialities.Create(new Speciality()
                {
                    Name = "ПОИТ",
                    Courses = new List<Course> { new Course() {
                    CourseNum = 1,
                    Groups = null,
                    Teachers = null },
                    new Course() {
                        CourseNum = 2,
                        Groups = null,
                        Teachers = null },
                    new Course() {
                        CourseNum = 3,
                        Groups = null,
                        Teachers = null },
                    new Course() {
                        CourseNum = 4,
                        Groups = null,
                        Teachers = null },
                }
                });
                unitOfWork.Specialities.Create(new Speciality()
                {
                    Name = "ИСиТ",
                    Courses = new List<Course> { new Course() {
                    CourseNum = 1,
                    Groups = null,
                    Teachers = null },
                    new Course() {
                        CourseNum = 2,
                        Groups = null,
                        Teachers = null },
                    new Course() {
                        CourseNum = 3,
                        Groups = null,
                        Teachers = null },
                    new Course() {
                        CourseNum = 4,
                        Groups = null,
                        Teachers = null },
                }
                });
                unitOfWork.Specialities.Create(new Speciality()
                {
                    Name = "ПОИБМС",
                    Courses = new List<Course> { new Course() {
                    CourseNum = 1,
                    Groups = null,
                    Teachers = null },
                    new Course() {
                        CourseNum = 2,
                        Groups = null,
                        Teachers = null },
                    new Course() {
                        CourseNum = 3,
                        Groups = null,
                        Teachers = null },
                    new Course() {
                        CourseNum = 4,
                        Groups = null,
                        Teachers = null },
                }
                });
                unitOfWork.Specialities.Create(new Speciality()
                {
                    Name = "ДЭиВИ",
                    Courses = new List<Course> { new Course() {
                    CourseNum = 1,
                    Groups = null,
                    Teachers = null },
                    new Course() {
                        CourseNum = 2,
                        Groups = null,
                        Teachers = null },
                    new Course() {
                        CourseNum = 3,
                        Groups = null,
                        Teachers = null },
                    new Course() {
                        CourseNum = 4,
                        Groups = null,
                        Teachers = null },
                }
                });
                unitOfWork.Save();
            }
            bool loginTrue = false;
            foreach (User user in unitOfWork.Users.GetAll())
            {
                if (user.Login == str)
                {
                    loginTrue = true;
                    authorizatedUser = user;
                }

            }
            if (!loginTrue)
            {
                AccessLogin = "red";
                AccessPassword = "transparent";
                return false;
            }
            else
            {
                AccessLogin = "transparent";
                return true;
            }
        }

        public string AccessPassword
        {
            get
            {
                return accessPassword;
            }
            set
            {
                accessPassword = value;
                OnPropertyChanged("AccessPassword");
            }
        }
        private bool checkPassword(String str)
        {
            if (authorizatedUser.Password != str)
            {
                AccessPassword = "red";
                return false;
            }
            else
            {
                AccessPassword = "transparent";
                return true;
            }
        }

        private MyCommand checkAuthorization;
        public MyCommand CheckAuthorization
        {
            get
            {
                return checkAuthorization ?? (checkAuthorization = new MyCommand(
                    (obj) =>
                    {
                        if (checkLogin(Login) && checkPassword(Password))
                        {
                            MainWindow mainWindow = new();
                            mainWindow.Show();
                            Messenger.Default.Send(authorizatedUser, "logging");
                            Messenger.Default.Send(authorizatedUser, "toRequest");
                            App.Current.Windows[0].Close();
                        }
                    }));
            }
        }

        public AuthorizationVM()
        {
            unitOfWork = new UnitOfWork();
        }
    }
}
