using CourseProject.Helpers;
using CourseProject.Models;
using CourseProject.Repositories;
using CourseProject.Views;
using GalaSoft.MvvmLight.Messaging;
using System.Collections.ObjectModel;
using System.Windows;

namespace CourseProject.ViewModels
{
    internal class TimetableVM : ObservableObject
    {
        private UnitOfWork unitOfWork;
        private List<Models.Timetable> timetables;
        private int selectedCourse = 1;
        private string selectedGroup;
        private string selectedSpeciality = "ИСиТ";
        private Course thisCourse;
        private Group thisGroup;
        private Speciality thisSpec;
        private int[] courses = [1, 2, 3, 4];
        private string[] specialities = ["ИСиТ", "ПОИТ", "ПОИБМС", "ДЭиВИ"];
        private List<string> groupNums = [];

        private string forStudent = "0";
        public string ForStudent
        {
            get
            {
                return forStudent;
            }
            set
            {
                forStudent = value;
                OnPropertyChanged(nameof(ForStudent));
            }
        }

        private bool isAdmin = true;
        public bool IsAdmin
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

        private string timetableYes = "hidden";
        public string TimetableYes
        {
            get
            {
                return timetableYes;
            }
            set
            {
                timetableYes = value;
                OnPropertyChanged("TimetableYes");
            }
        }

        private string timetableNo = "visible";
        public string TimetableNo
        {
            get
            {
                return timetableNo;
            }
            set
            {
                timetableNo = value;
                OnPropertyChanged("TimetableNo");
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
                if (groupNums.Count > 0) SelectedGroup = groupNums[0];
                return groupNums;
            }
            set
            {
                groupNums = value;
                OnPropertyChanged(nameof(GroupNums));
            }
        }

        private MyCommand addSubject;
        public MyCommand AddSubject
        {
            get
            {
                return addSubject ??= new MyCommand(
                    (obj) =>
                    {
                        AddingSubject newWindow = new();
                        Messenger.Default.Send(thisGroup, "groupForSubject");
                        Messenger.Default.Send(thisCourse, "courseForSubject");
                        if (obj is string str)
                        {
                            if (str == "Понедельник") Messenger.Default.Send(EnumWeekdays.Monday.ToString(), "weekday");
                            if (str == "Вторник") Messenger.Default.Send(EnumWeekdays.Tuesday.ToString(), "weekday");
                            if (str == "Среда") Messenger.Default.Send(EnumWeekdays.Wednesday.ToString(), "weekday");
                            if (str == "Четверг") Messenger.Default.Send(EnumWeekdays.Thursday.ToString(), "weekday");
                            if (str == "Пятница") Messenger.Default.Send(EnumWeekdays.Friday.ToString(), "weekday");
                            if (str == "Суббота") Messenger.Default.Send(EnumWeekdays.Saturday.ToString(), "weekday");
                        }
                        newWindow.ShowDialog();
                    },
                    (obj) =>
                    {
                        return thisCourse != null && thisGroup != null;
                    });
            }
        }

        private MyCommand deleteSubject;
        public MyCommand DeleteSubject
        {
            get
            {
                return deleteSubject ??= new MyCommand(
                    (obj) =>
                    {
                        if (obj is int id)
                        {
                            unitOfWork.Subjects.Delete(id);
                            unitOfWork.Save();
                            LoadSubjects();
                        }
                    });
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
                    foreach (var group in thisCourse.Groups)
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

        private ObservableCollection<Subject> mondaySubj = [];
        public ObservableCollection<Subject> MondaySubj
        {
            get
            {
                return mondaySubj;
            }
            set
            {
                mondaySubj = value;
                OnPropertyChanged(nameof(MondaySubj));
            }
        }

        private ObservableCollection<Subject> tuesdaySubj = [];
        public ObservableCollection<Subject> TuesdaySubj
        {
            get
            {
                return tuesdaySubj;
            }
            set
            {
                tuesdaySubj = value;
                OnPropertyChanged(nameof(tuesdaySubj));
            }
        }

        private ObservableCollection<Subject> wednesdaySubj = [];
        public ObservableCollection<Subject> WednesdaySubj
        {
            get
            {
                return wednesdaySubj;
            }
            set
            {
                wednesdaySubj = value;
                OnPropertyChanged(nameof(WednesdaySubj));
            }
        }

        private ObservableCollection<Subject> thursdaySubj = [];
        public ObservableCollection<Subject> ThursdaySubj
        {
            get
            {
                return thursdaySubj;
            }
            set
            {
                thursdaySubj = value;
                OnPropertyChanged(nameof(ThursdaySubj));
            }
        }

        private ObservableCollection<Subject> fridaySubj = [];
        public ObservableCollection<Subject> FridaySubj
        {
            get
            {
                return fridaySubj;
            }
            set
            {
                fridaySubj = value;
                OnPropertyChanged(nameof(FridaySubj));
            }
        }

        private ObservableCollection<Subject> saturdaySubj = [];
        public ObservableCollection<Subject> SaturdaySubj
        {
            get
            {
                return saturdaySubj;
            }
            set
            {
                saturdaySubj = value;
                OnPropertyChanged(nameof(SaturdaySubj));
            }
        }

        private string addingRow = "0";
        public string AddingRow
        {
            get
            {
                return addingRow;
            }
            set
            {
                addingRow = value;
                OnPropertyChanged(nameof(AddingRow));
            }
        }

        private MyCommand findSubjects;
        public MyCommand FindSubjects
        {
            get
            {
                return findSubjects ??= new MyCommand(
                    (obj) =>
                    {
                        if (thisGroup != null && SelectedGroup != null)
                        {
                            LoadSubjects();
                            TimetableYes = "visible";
                            TimetableNo = "hidden";
                        }
                        else
                        {
                            TimetableYes = "hidden";
                            TimetableNo = "visible";
                            MessageBox.Show("Необходимо выбрать группу!");
                        }
                    });
            }
        }

        private void takeUser(User user)
        {
            if (user.Student == null)
            {
                AddingRow = "50";
                ForStudent = "30";
                IsAdmin = true;
            }
        }

        private void LoadSubjects()
        {
            timetables = thisGroup.Timetables;
            mondaySubj.Clear();
            tuesdaySubj.Clear();
            wednesdaySubj.Clear();
            thursdaySubj.Clear();
            fridaySubj.Clear();
            saturdaySubj.Clear();
            foreach (Models.Timetable thisTime in timetables)
            {
                if (thisTime.WeekDay == EnumWeekdays.Monday.ToString())
                {
                    mondaySubj = [.. thisTime.Subjects.ToList()];
                    MondaySubj = [.. mondaySubj.OrderBy(x => x.Start)];
                }
                else if (thisTime.WeekDay == EnumWeekdays.Tuesday.ToString())
                {
                    tuesdaySubj = [.. thisTime.Subjects.ToList()];
                    TuesdaySubj = [.. tuesdaySubj.OrderBy(x => x.Start)];
                }
                else if (thisTime.WeekDay == EnumWeekdays.Wednesday.ToString())
                {
                    wednesdaySubj = [.. thisTime.Subjects.ToList()];
                    WednesdaySubj = [.. wednesdaySubj.OrderBy(x => x.Start)];
                }
                else if (thisTime.WeekDay == EnumWeekdays.Thursday.ToString())
                {
                    thursdaySubj = [.. thisTime.Subjects.ToList()];
                    ThursdaySubj = [.. thursdaySubj.OrderBy(x => x.Start)];
                }
                else if (thisTime.WeekDay == EnumWeekdays.Friday.ToString())
                {
                    fridaySubj = [.. thisTime.Subjects.ToList()];
                    FridaySubj = [.. fridaySubj.OrderBy(x => x.Start)];
                }
                else if (thisTime.WeekDay == EnumWeekdays.Saturday.ToString())
                {
                    saturdaySubj = [.. thisTime.Subjects.ToList()];
                    SaturdaySubj = [.. saturdaySubj.OrderBy(x => x.Start)];
                }
            }
        }

        private void UpdateTimetable(Group group)
        {
            thisGroup = group;
            unitOfWork.Groups.Update(thisGroup);
            unitOfWork.Save();
            foreach (var timetable in thisGroup.Timetables)
            {
                foreach (var subject in timetable.Subjects)
                {
                    if (subject.Auditorium == null)
                    {
                        subject.Auditorium = unitOfWork.Auditoriums.Get(subject.AuditoriumId);
                    }
                }
            }
            LoadSubjects();
        }

        public TimetableVM()
        {
            unitOfWork = new UnitOfWork();
            Messenger.Default.Register<Group>(this, "newTimetable", UpdateTimetable);
            Messenger.Default.Register<User>(this, "toTimetable", takeUser);
        }
    }
}
