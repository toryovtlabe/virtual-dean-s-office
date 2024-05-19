using CourseProject.Helpers;
using CourseProject.Models;
using CourseProject.Repositories;
using CourseProject.Views;
using GalaSoft.MvvmLight.Messaging;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Windows;

namespace CourseProject.ViewModels
{
    internal class StudentsVM : ObservableObject
    {
        UnitOfWork unitOfWork;
        private int[] courses = [1, 2, 3, 4];
        private string[] specialities = ["ИСиТ", "ПОИТ", "ПОИБМС", "ДЭиВИ"];
        private int selectedCourse = 1;
        private string selectedSpec = "ИСиТ";
        private string? selectedGroup = "";
        private List<string> groupNums;
        private Speciality thisSpec = null;
        private Course thisCourse;
        private Models.Group thisGroup;
        private MyCommand createGroup;
        private MyCommand createStudent;
        private MyCommand moreAboutStudent;
        private Student selectedStudent;
        private ObservableCollection<Student> allStudents = [];
        private MyCommand delStudent;
        private ObservableCollection<Student> filteredList;
        private MyCommand defilter;

        private MyCommand find;
        public MyCommand Find
        {
            get
            {
                return find ??= new(
                    (obj) =>
                    {
                        if (Search != null && filteredList != null)
                        {
                            Regex regex = new Regex(Search.ToLower() + @"(\w*)");
                            AllStudents = [.. filteredList.Where(x => regex.Matches(x.Surname.ToLower()).Count > 0)];
                        }
                        else if (Search != null)
                        {
                            filteredList = allStudents;
                            Regex regex = new Regex(Search.ToLower() + @"(\w*)");
                            AllStudents = [.. allStudents.Where(x => regex.Matches(x.Surname.ToLower()).Count > 0)];
                        }
                    });
            }
        }

        private string search;
        public string Search
        {
            get
            {
                return search;
            }
            set
            {
                search = value;
                OnPropertyChanged(nameof(search));
            }
        }

        public MyCommand DelStudent
        {
            get
            {
                return delStudent ??= new MyCommand(
                    (obj) =>
                    {
                        if (obj is int id)
                        {
                            foreach (var s in unitOfWork.Users.GetAll())
                            {
                                if (s.Student != null && s.Student.Id == id)
                                {
                                    unitOfWork.Users.Delete(s.Id);
                                    break;
                                }
                            }
                            allStudents.Remove(unitOfWork.Students.Get(id));
                            unitOfWork.Students.Delete(id);
                            unitOfWork.Save();
                        }
                    });
            }
        }

        public Student SelectedStudent
        {
            get
            {
                return selectedStudent;
            }
            set
            {
                selectedStudent = value;
                OnPropertyChanged(nameof(SelectedStudent));
            }
        }

        public ObservableCollection<Student> AllStudents
        {
            get
            {
                return allStudents;
            }
            set
            {
                allStudents = value;
                OnPropertyChanged(nameof(AllStudents));
            }
        }

        public MyCommand CreateStudent
        {
            get
            {
                return createStudent ??= new MyCommand(
                    (obj) =>
                    {
                        if (thisGroup != null)
                        {
                            CreateStudent newWindow = new();
                            Messenger.Default.Send(thisSpec, "sendSpec");
                            Messenger.Default.Send(thisGroup, "sendGroup");
                            Messenger.Default.Send(thisCourse, "sendCourse");
                            newWindow.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Необходимо выбрать группу!");
                        }
                    });
            }
        }

        public MyCommand MoreAboutStudent
        {
            get
            {
                return moreAboutStudent ??= new(
                    (obj) =>
                    {
                        if (obj is int id)
                        {
                            CreateStudent newWindow = new();
                            Messenger.Default.Send(unitOfWork.Students.Get(id), "sendStudent");
                            newWindow.ShowDialog();
                        }
                    });
            }
        }

        private MyCommand filter;
        public MyCommand Filter
        {
            get
            {
                return filter ??= new MyCommand(
                (obj) =>
                {
                    if (SelectedGroup != null)
                    {
                        if (allStudents.Count != 0) allStudents.Clear();
                        foreach (Student student in thisGroup.Students)
                        {
                            AllStudents.Add(student);
                        }
                    }
                    else if (SelectedCourse != 0)
                    {
                        if (allStudents.Count != 0) allStudents.Clear();
                        foreach (Models.Group group in thisCourse.Groups)
                        {
                            foreach (Student student in group.Students)
                            {
                                AllStudents.Add(student);
                            }
                        }
                    }
                    else if (SelectedSpec != null)
                    {
                        if (allStudents.Count != 0) allStudents.Clear();
                        foreach (Course course in thisSpec.Courses)
                        {
                            foreach (Models.Group group in course.Groups)
                            {
                                foreach (Student student in group.Students)
                                {
                                    AllStudents.Add(student);
                                }
                            }
                        }
                    }
                    filteredList = AllStudents;
                    Search = null;
                });
            }
        }

        public MyCommand Defilter
        {
            get
            {
                return defilter ??= new(
                    (obj) =>
                    {
                        AllStudents = [.. unitOfWork.Students.GetAll()];
                        filteredList = allStudents;
                        Search = null;
                    });
            }
        }

        public MyCommand CreateGroup
        {
            get
            {
                return createGroup ?? (createGroup = new MyCommand(
                    (obj) =>
                    {
                        if (selectedCourse != 0 && selectedSpec != null)
                        {
                            Views.CreateGroup win = new Views.CreateGroup();
                            Messenger.Default.Send(thisCourse, "toCreateGroup");
                            win.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Необходимо выбрать курс и специальность");
                        }
                    }));
            }
        }

        public List<string> GroupNums
        {
            get
            {
                groupNums = [];
                if (thisCourse != null)
                {
                    if (thisCourse.Groups.Count != 0)
                    {
                        foreach (var group in thisCourse.Groups)
                        {
                            groupNums.Add(group.Name);
                        }
                    }
                }
                if (groupNums.Count > 0) SelectedGroup = groupNums[0];
                return groupNums;
            }
            set
            {
                groupNums = value;
                OnPropertyChanged(nameof(GroupNums));
            }
        }

        public string SelectedSpec
        {
            get
            {
                foreach (var spec in unitOfWork.Specialities.GetAll())
                {
                    if (spec.Name == selectedSpec)
                    {
                        thisSpec = spec;
                        OnPropertyChanged(nameof(SelectedCourse));
                        SelectedGroup = null;
                        break;
                    }
                }
                return selectedSpec;
            }
            set
            {
                selectedSpec = value;
                OnPropertyChanged(nameof(SelectedSpec));
            }
        }

        public int SelectedCourse
        {
            get
            {
                if (thisSpec != null)
                {
                    foreach (Course course in thisSpec.Courses)
                    {
                        if (course.CourseNum == selectedCourse)
                        {
                            thisCourse = course;
                            OnPropertyChanged(nameof(GroupNums));
                            return selectedCourse;
                        }
                    }
                    OnPropertyChanged(nameof(GroupNums));
                }
                return selectedCourse;
            }
            set
            {
                selectedCourse = value;
                OnPropertyChanged(nameof(SelectedCourse));
            }
        }

        public string? SelectedGroup
        {
            get
            {
                if (selectedGroup != null)
                {
                    foreach (var group in thisCourse.Groups )
                    {
                        if (group.Name == selectedGroup)
                        {
                            thisGroup = group;
                            return selectedGroup;
                        }
                    }
                }
                return selectedGroup;
            }
            set
            {
                selectedGroup = value;
                OnPropertyChanged(nameof(SelectedGroup));
            }
        }

        public int[] Courses
        {
            get
            {
                return courses;
            }
            set
            {
                courses = value;
            }
        }

        public string[] Specialities
        {
            get
            {
                return specialities;
            }
            set
            {
                specialities = value;
            }
        }

        public StudentsVM()
        {
            unitOfWork = new UnitOfWork();
            AllStudents = [.. unitOfWork.Students.GetAll()];
            Messenger.Default.Register<Student>(this, "creating student", s =>
            {
                thisGroup.Students.Add(s);
                AllStudents.Add(s);
                unitOfWork.Groups.Update(thisGroup);
            });
            Messenger.Default.Register<User>(this, "creating user", u =>
            {
                unitOfWork.Users.Create(u);
                unitOfWork.Save();
            });
            Messenger.Default.Register<string>(this, "newGroup", g =>
            {
                thisCourse.Groups.Add(new Models.Group { Name = g, Students = new() });
                unitOfWork.Courses.Update(thisCourse);
                unitOfWork.Save();
                OnPropertyChanged(nameof(SelectedCourse));
                SelectedGroup = g;
            });
        }
    }
}
