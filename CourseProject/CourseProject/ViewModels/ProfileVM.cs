using CourseProject.Helpers;
using CourseProject.Models;
using CourseProject.Repositories;
using GalaSoft.MvvmLight.Messaging;

namespace CourseProject.ViewModels
{
    internal class ProfileVM : ObservableObject
    {
        private UnitOfWork unitOfWork;
        private string headmanVisibility = "hidden";
        private string group;
        private Student thisStudent = new();
        private int course;
        private string speciality;

        public Student ThisStudent
        {
            get
            {
                return thisStudent;
            }
            set
            {
                thisStudent = value;
                OnPropertyChanged(nameof(ThisStudent));
            }
        }

        public string Group
        {
            get
            {
                return group;
            }
            set
            {
                group = value;
                OnPropertyChanged(nameof(Group));
            }
        }

        public int Course
        {
            get
            {
                return course;
            }
            set
            {
                course = value;
                OnPropertyChanged(nameof(Course));
            }
        }

        public string Speciality
        {
            get
            {
                return speciality;
            }
            set
            {
                speciality = value;
                OnPropertyChanged(nameof(Speciality));
            }
        }

        public string HeadmanVisibility
        {
            get
            {
                return headmanVisibility;
            }
            set
            {
                headmanVisibility = value;
                OnPropertyChanged(nameof(HeadmanVisibility));
            }
        }

        private void takeUser(User user)
        {
            foreach (Speciality item in unitOfWork.Specialities.GetAll())
            {
                foreach (Course item1 in item.Courses)
                {
                    foreach (Group item2 in item1.Groups)
                    {
                        foreach (Student item3 in item2.Students)
                        {
                            if (user.Student != null && user.Student.Id == item3.Id)
                            {
                                Speciality = item.Name;
                                Course = item1.CourseNum;
                                Group = item2.Name;
                                thisStudent.Surname = item3.Surname;
                                thisStudent.Firstname = item3.Firstname;
                                thisStudent.Patronymic = item3.Patronymic;
                                thisStudent.Image = item3.Image;
                                thisStudent.Hb = item3.Hb;
                                if (item3.IsHeadman) HeadmanVisibility = "visible";
                                break;
                            }
                        }
                    }
                }
            }
        }

        public ProfileVM()
        {
            unitOfWork = new UnitOfWork();
            Messenger.Default.Register<User>(this, "toProfile", user => takeUser(user));
        }
    }
}
