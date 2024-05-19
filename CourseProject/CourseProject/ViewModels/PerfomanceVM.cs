using CourseProject.Helpers;
using CourseProject.Models;
using CourseProject.Repositories;
using GalaSoft.MvvmLight.Messaging;
using System.Diagnostics;
using System.Windows;

namespace CourseProject.ViewModels
{
    internal class PerfomanceVM : ObservableObject
    {
        private UnitOfWork unitOfWork;
        private Student student;
        private int selectedCourse;
        private string? selectedGroup;
        private string selectedSpeciality;
        private Course thisCourse;
        private Group thisGroup;
        private Speciality thisSpec;
        private int[] courses = [1, 2, 3, 4];
        private string[] specialities = ["ИСиТ", "ПОИТ", "ПОИБМС", "ДЭиВИ"];
        private List<string> groupNums = [];
        private List<Student> students = [];
        private MyCommand saveStudent;
        private double avarageMark;
        private int sumSkips;
        private int sumMarks;
        private int isAdmin;
        private string adminVisible = "hidden";
        private int index = -1;
        private MyCommand back;
        private MyCommand next;
        private int studentSelect = 0;
        private int studentUnSelect = 240;

        public int StudentSelect
        {
            get
            {
                return studentSelect;
            }
            set
            {
                studentSelect = value;
                OnPropertyChanged(nameof(StudentSelect));
            }
        }

        public int StudentUnSelect
        {
            get
            {
                return studentUnSelect;
            }
            set
            {
                studentUnSelect = value;
                OnPropertyChanged(nameof(StudentUnSelect));
            }
        }

        public MyCommand Back
        {
            get
            {
                return back ??= new(
                    (obj) =>
                    {
                        if (index - 1 != -1 && index != -1)
                        {
                            Index--;
                        }
                        else Index = students.Count - 1;
                    },
                    (obj) =>
                    {
                        return students != null;
                    });
            }
        }
        public MyCommand Next
        {
            get
            {
                return next ??= new(
                    (obj) =>
                    {
                        if (index + 1 != Students.Count)
                        {
                            Index++;
                        }
                        else Index = 0;
                    },
                    (obj) =>
                    {
                        return students != null;
                    });
            }
        }

        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
                OnPropertyChanged(nameof(Index));
            }
        }

        public string AdminVisible
        {
            get
            {
                return adminVisible;
            }
            set
            {
                adminVisible = value;
                OnPropertyChanged(nameof(AdminVisible));
            }
        }

        public int IsAdmin
        {
            get
            {
                return isAdmin;
            }
            set
            {
                isAdmin = value;
                OnPropertyChanged(nameof(IsAdmin));
            }
        }

        public int SumSkips
        {
            get
            {
                return sumSkips;
            }
            set
            {
                sumSkips = value;
                OnPropertyChanged(nameof(SumSkips));
            }
        }

        public double AvarageMark
        {
            get
            {
                if (student != null)
                {
                    int countMark = 0;
                    foreach (var prog in student.Progresses)
                    {
                        if (prog.Mark != 0)
                        {
                            sumMarks += prog.Mark;
                            countMark++;
                        }
                        SumSkips += prog.Skips;
                    }
                    if (countMark > 0)
                    {
                        avarageMark = Math.Round(((double)sumMarks / countMark), 2);
                    }
                }
                return avarageMark;
            }
            set
            {
                avarageMark = value;
                OnPropertyChanged(nameof(AvarageMark));
            }
        }

        public MyCommand SaveStudent
        {
            get
            {
                return saveStudent ??= new(
                    (obj) =>
                    {
                        bool isTrue = true;
                        foreach (var prog in student.Progresses)
                        {
                            if (prog.Mark > 10) isTrue = false;
                        }
                        if (student != null)
                        {
                            if (isTrue)
                            {
                                unitOfWork.Students.Update(student);
                                unitOfWork.Save();
                                MessageBox.Show("Информация об аттестации студента успешно сохранена");
                                AvarageMark = 0;
                                SumSkips = 0;
                                sumMarks = 0;
                                OnPropertyChanged(nameof(AvarageMark));
                            }
                            else
                            {
                                MessageBox.Show("Ошибка, оценка не должна быть больше 10!");
                            }
                        }
                    });
            }
        }

        public List<Student> Students
        {
            get
            {
                return students;
            }
            set
            {
                students = value;
                OnPropertyChanged(nameof(Students));
            }
        }

        public Student Student
        {
            get
            {
                if (thisGroup == null && student != null)
                {
                    foreach (var group in unitOfWork.Groups.GetAll())
                    {
                        foreach (var item in group.Students)
                        {
                            if (item.Id == student.Id)
                            {
                                thisGroup = group;
                                break;
                            }
                        }
                    }
                }
                if (thisGroup != null && student != null)
                {
                    foreach (var timetable in thisGroup.Timetables)
                    {
                        foreach (var subject in timetable.Subjects)
                        {
                            if (student.Progresses == null) student.Progresses = [];
                            bool isNew = true;
                            foreach (var progress in student.Progresses)
                            {
                                if (progress.Subject.Name == subject.Name)
                                {
                                    isNew = false;
                                    break;
                                }
                            }
                            if (isNew)
                            {
                                student.Progresses.Add(new Progress() { Student = student, Subject = subject });
                            }
                        }
                    }
                }
                AvarageMark = 0;
                SumSkips = 0;
                sumMarks = 0;
                OnPropertyChanged(nameof(AvarageMark));
                return student;
            }
            set
            {
                student = value;
                OnPropertyChanged(nameof(Student));
                if (value is not null && value.Progresses.Count != 0)
                {
                    StudentSelect = 240;
                    StudentUnSelect = 0;
                }
                else
                {
                    StudentSelect = 0;
                    StudentUnSelect = 240;
                }
            }
        }

        public string? SelectedGroup
        {
            get
            {
                if (selectedGroup != null)
                {
                    foreach (var group in thisCourse.Groups)
                    {
                        if (group.Name == selectedGroup)
                        {
                            thisGroup = group;
                            Students = thisGroup.Students;
                            Index = 0;
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
                            Students = null;
                            StudentSelect = 0;
                            StudentUnSelect = 240;
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

        public string SelectedSpeciality
        {
            get
            {
                foreach (var spec in unitOfWork.Specialities.GetAll())
                {
                    if (spec.Name == selectedSpeciality)
                    {
                        thisSpec = spec;
                        OnPropertyChanged(nameof(SelectedCourse));
                        SelectedGroup = null;
                        break;
                    }
                }
                return selectedSpeciality;
            }
            set
            {
                selectedSpeciality = value;
                OnPropertyChanged(nameof(SelectedSpeciality));
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
                OnPropertyChanged(nameof(Courses));
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
                return groupNums;
            }
            set
            {
                groupNums = value;
                OnPropertyChanged(nameof(GroupNums));
            }
        }
        public PerfomanceVM()
        {
            unitOfWork = new UnitOfWork();
            Messenger.Default.Register<User>(this, "toPerfomance", u =>
            {
                if (u.Student != null)
                {
                    if (!u.Student.IsHeadman)
                    {
                        AdminVisible = "hidden";
                    }
                    else
                    {
                        AdminVisible = "visible";
                    }
                    IsAdmin = 0;
                    Student = u.Student;
                    foreach (var group in unitOfWork.Groups.GetAll())
                    {
                        foreach (var student in group.Students)
                        {
                            if (student.Id == u.Student.Id)
                            {
                                Students = group.Students;
                                break;
                            }
                        }
                    }
                    for (int i = 0; i < students.Count; i++)
                    {
                        if (u.Student.Id == students[i].Id)
                        {
                            Index = i;
                            break;
                        }
                    }
                }
                else
                {
                    Index = -1;
                    if (students != null) Students = null;
                    AdminVisible = "visible";
                    IsAdmin = 30;
                }
            });

        }
    }
}
