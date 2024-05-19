using CourseProject.Helpers;
using CourseProject.Models;
using CourseProject.Repositories;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Win32;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;

namespace CourseProject.ViewModels
{
    internal class CreateStudentVM : ObservableObject
    {
        private UnitOfWork unitOfWork;
        private string group;
        private string course;
        private string speciality;
        private string userLogin;
        private string userPassword;
        private Student student = new();
        private Models.Group thisGroup;
        private Course thisCourse;
        private Speciality thisSpec;
        private MyCommand saveStudent;
        private MyCommand editStudent;
        private MyCommand addImage;
        private User thisUser;
        private string isRedact = "hidden";
        private string visibilityRedact = "hidden";
        private string visibilityRedactNot = "hidden";

        private string isNotRedact = "hidden";
        public string IsNotRedact
        {
            get
            {
                return isNotRedact;
            }
            set
            {
                isNotRedact = value;
                OnPropertyChanged(nameof(IsNotRedact));
            }
        }

        private MyCommand activateRedact;
        public MyCommand ActivateRedact
        {
            get
            {
                return activateRedact ??= new(
                    (obj) =>
                    {
                        VisibilityRedact = "hidden";
                        VisibilityRedactNot = "visible";
                    });
            }
        }

        public string VisibilityRedact
        {
            get
            {
                return visibilityRedact;
            }
            set
            {
                visibilityRedact = value;
                OnPropertyChanged(nameof(VisibilityRedact));
            }
        }

        public string VisibilityRedactNot
        {
            get
            {
                return visibilityRedactNot;
            }
            set
            {
                visibilityRedactNot = value;
                OnPropertyChanged(nameof(VisibilityRedactNot));
            }
        }

        public MyCommand EditStudent
        {
            get
            {
                return editStudent ??= new MyCommand(
                    (obj) =>
                    {
                        if (!String.IsNullOrEmpty(student.Surname) && !String.IsNullOrEmpty(student.Firstname) && !String.IsNullOrEmpty(student.Patronymic) && !String.IsNullOrEmpty(UserLogin) && !String.IsNullOrEmpty(UserPassword))
                        {
                            string pattern = @"^[а-яА-ЯёЁ]+$";
                            string loginPattern = @"^[a-zA-Z0-9]{5,12}$";
                            string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$";
                            Regex regex = new(pattern);
                            Regex regex2 = new(loginPattern);
                            Regex regex3 = new(passwordPattern);
                            if (regex.IsMatch(student.Surname) && regex.IsMatch(student.Firstname) && regex.IsMatch(student.Patronymic))
                            {
                                if (regex2.IsMatch(userLogin))
                                {
                                    if (regex3.IsMatch(userPassword))
                                    {
                                        if (student.Hb.Year > 1999)
                                        {
                                            bool isNew = true;
                                            bool isNewHead = true;
                                            foreach (User user in unitOfWork.Users.GetAll())
                                            {
                                                if (user.Login == UserLogin && user.Student.Id != Student.Id)
                                                {
                                                    isNew = false;
                                                    break;
                                                }
                                            }
                                            if (thisGroup.Students.Count != 0)
                                            {
                                                foreach (Student student in thisGroup.Students)
                                                {
                                                    if (Student.IsHeadman && student.IsHeadman && Student.Id != student.Id)
                                                    {
                                                        isNewHead = false;
                                                        break;
                                                    }
                                                }
                                            }
                                            if (isNew && isNewHead)
                                            {
                                                unitOfWork.Students.Update(Student);
                                                thisUser.Login = UserLogin;
                                                thisUser.Password = UserPassword;
                                                unitOfWork.Users.Update(thisUser);
                                                unitOfWork.Save();
                                                //(obj as Window).Close();
                                                VisibilityRedact = "visible";
                                                VisibilityRedactNot = "hidden";
                                                MessageBox.Show("Студент успешно изменён!");
                                            }
                                            else if (isNewHead)
                                            {
                                                MessageBox.Show("Пользователь с таким логином уже создан!");
                                            }

                                            else
                                            {
                                                MessageBox.Show("У группы №" + thisGroup.Name + " уже есть староста!");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Ошибка, пользователю слишком много лет");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Пароль должен содержать хотя бы одну цифру, прописную букву, строчную букву английского алфавита и быть длиной от 8 символов!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Логин должен содержать от 5 до 12 букв английского алфавита или цифр!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Проверьте корректность ввода данных о студенте");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Все поля должны быть заполнены!");
                        }
                    });
            }
        }

        public string IsRedact
        {
            get
            {
                return isRedact;
            }
            set
            {
                isRedact = value;
                OnPropertyChanged(nameof(IsRedact));
            }
        }

        public Student Student
        {
            get
            {
                return student;
            }
            set
            {
                student = value;
                OnPropertyChanged(nameof(student));
            }
        }

        public MyCommand AddImage
        {
            get
            {
                return addImage ??= new MyCommand(
                    (obj) =>
                    {
                        OpenFileDialog opf = new OpenFileDialog();
                        opf.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";
                        if (opf.ShowDialog() == true)
                        {
                            Student.Image = File.ReadAllBytes(opf.FileName);
                        }
                    });
            }

        }

        public MyCommand SaveStudent
        {
            get
            {
                return saveStudent ??= new MyCommand(
                    (obj) =>
                    {
                        if (!String.IsNullOrEmpty(student.Surname) && !String.IsNullOrEmpty(student.Firstname) && !String.IsNullOrEmpty(student.Patronymic) && !String.IsNullOrEmpty(UserLogin) && !String.IsNullOrEmpty(UserPassword))
                        {
                            string pattern = @"^[а-яА-ЯёЁ]+$";
                            string loginPattern = @"^[a-zA-Z0-9]{5,12}$";
                            string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$";
                            Regex regex = new Regex(pattern);
                            Regex regex2 = new Regex(loginPattern);
                            Regex regex3 = new Regex(passwordPattern);
                            if (regex.IsMatch(student.Surname) && regex.IsMatch(student.Firstname) && regex.IsMatch(student.Patronymic))
                            {
                                if (regex2.IsMatch(userLogin))
                                {
                                    if (regex3.IsMatch(userPassword))
                                    {
                                        bool isNew = true;
                                        bool isNewHead = true;
                                        foreach (User user in unitOfWork.Users.GetAll())
                                        {
                                            if (user.Login == UserLogin)
                                            {
                                                isNew = false;
                                                break;
                                            }
                                        }
                                        if (thisGroup.Students.Count != 0)
                                        {
                                            foreach (Student student in thisGroup.Students)
                                            {
                                                if (Student.IsHeadman && student.IsHeadman)
                                                {
                                                    isNewHead = false;
                                                    break;
                                                }
                                            }
                                        }
                                        if (isNew && isNewHead)
                                        {
                                            Messenger.Default.Send(Student, "creating student");
                                            Messenger.Default.Send(new User() { Student = Student, Login = UserLogin, Password = UserPassword }, "creating user");
                                            (obj as Window).Close();
                                            MessageBox.Show("Студент успешно добавлен в группу №" + thisGroup.Name);
                                        }
                                        else if (isNewHead)
                                        {
                                            MessageBox.Show("Пользователь с таким логином уже создан!");
                                        }
                                        else
                                        {
                                            MessageBox.Show("У группы №" + thisGroup.Name + " уже есть староста!");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Пароль должен содержать хотя бы одну цифру, прописную букву, строчную букву английского алфавита и быть длиной от 8 символов!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Логин должен содержать от 5 до 12 букв английского алфавита или цифр!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Проверьте корректность ввода данных о студенте");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Все поля должны быть заполнены!");
                        }
                    });
            }
        }

        public string Group
        {
            get
            {
                if (thisGroup != null)
                {
                    group = thisGroup.Name;
                }
                return group;
            }
            set
            {
                group = value;
                OnPropertyChanged(nameof(Group));
            }
        }

        public string Course
        {
            get
            {
                if (thisCourse != null)
                {
                    course = thisCourse.CourseNum.ToString();
                }
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
                if (thisSpec != null)
                {
                    speciality = thisSpec.Name;
                }
                return speciality;
            }
            set
            {
                speciality = value;
                OnPropertyChanged(nameof(Speciality));
            }
        }

        public string UserLogin
        {
            get
            {
                return userLogin;
            }
            set
            {
                userLogin = value;
                OnPropertyChanged(nameof(UserLogin));
            }
        }

        public string UserPassword
        {
            get
            {
                return userPassword;
            }
            set
            {
                userPassword = value;
                OnPropertyChanged(nameof(UserPassword));
            }
        }

        private void takeGroup(Models.Group group)
        {
            thisGroup = group;
            OnPropertyChanged(nameof(Group));
        }

        private void takeCourse(Course course)
        {
            thisCourse = course;
            OnPropertyChanged(nameof(Course));
            IsNotRedact = "visible";
        }

        private void takeStudent(Student studentInfo)
        {
            Student = studentInfo;
            foreach (var item in unitOfWork.Specialities.GetAll())
            {
                foreach (var item1 in item.Courses)
                {
                    foreach (var item2 in item1.Groups)
                    {
                        foreach (var item3 in item2.Students)
                        {
                            if (item3.Id == Student.Id)
                            {
                                thisSpec = item;
                                OnPropertyChanged(nameof(Speciality));
                                thisCourse = item1;
                                OnPropertyChanged(nameof(Course));
                                thisGroup = item2;
                                OnPropertyChanged(nameof(Group));
                                break;
                            }
                        }
                    }
                }
            }
            foreach (var item in unitOfWork.Users.GetAll())
            {
                if (item.Student != null && item.Student.Id == Student.Id)
                {
                    thisUser = item;
                    UserLogin = item.Login;
                    UserPassword = item.Password;
                }
            }
            IsRedact = "Visible";
            VisibilityRedact = "visible";
        }

        public CreateStudentVM()
        {
            unitOfWork = new UnitOfWork();
            Messenger.Default.Register<Models.Group>(this, "sendGroup", s => takeGroup(s));
            Messenger.Default.Register<Course>(this, "sendCourse", s => takeCourse(s));
            Messenger.Default.Register<Speciality>(this, "sendSpec", s =>
            {
                thisSpec = s;
                OnPropertyChanged(nameof(Speciality));
            });
            Messenger.Default.Register<Student>(this, "sendStudent", s => takeStudent(s));
        }
    }
}
