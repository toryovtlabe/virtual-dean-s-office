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
    class AddingSubjectVM : ObservableObject
    {
        private UnitOfWork unitOfWork;
        private Subject thisSubject = new();
        private List<TimeOnly> startTimes = [new TimeOnly(8, 00), new TimeOnly(9, 35), new TimeOnly(11, 25), new TimeOnly(13, 00), new TimeOnly(14, 40), new TimeOnly(16, 30), new TimeOnly(18, 05), new TimeOnly(19, 40)];
        private string weekday;
        private Models.Group thisGroup;
        private Course thisCourse;
        private Models.Timetable thisTimetable = new();
        private MyCommand addSubject;
        private ObservableCollection<Teacher> teachers = [];

        public ObservableCollection<Teacher> Teachers
        {
            get
            {
                if (thisCourse != null) teachers = [.. thisCourse.Teachers];
                return teachers;
            }
            set
            {
                teachers = value;
                OnPropertyChanged(nameof(Teachers));
            }
        }

        private ObservableCollection<Auditorium> auditoriums = [];

        public ObservableCollection<Auditorium> Auditoriums
        {
            get
            {
                auditoriums = [.. unitOfWork.Auditoriums.GetAll()];
                return auditoriums;
            }
            set
            {
                auditoriums = value;
                OnPropertyChanged(nameof(Auditoriums));
            }
        }

        private MyCommand createAuditorium;
        public MyCommand CreateAuditorium
        {
            get
            {
                return createAuditorium ??= new(
                    (obj) =>
                    {
                        CreateAuditorium win = new();
                        win.ShowDialog();
                    });
            }
        }

        private MyCommand createTeacher;
        public MyCommand CreateTeacher
        {
            get
            {
                return createTeacher ??= new(
                    (obj) =>
                    {
                        CreateTeacher win = new();
                        Messenger.Default.Send(thisCourse, "toCreateTeacher");
                        win.ShowDialog();

                    });
            }
        }

        public List<TimeOnly> StartTimes
        {
            get
            {
                return startTimes;
            }
            set
            {
                startTimes = value;
                OnPropertyChanged(nameof(StartTimes));
            }
        }

        public Subject ThisSubject
        {
            get
            {
                return thisSubject;
            }
            set
            {
                thisSubject = value;
                OnPropertyChanged(nameof(ThisSubject));
            }
        }

        public MyCommand AddSubject
        {
            get
            {
                return addSubject ??= new MyCommand(
                    (obj) =>
                    {
                        if (thisGroup != null && weekday != null)
                        {
                            if (thisSubject.Name != null && thisSubject.Auditorium != null && thisSubject.Teacher != null && thisSubject.Start != new TimeOnly(0, 0))
                            {
                                string pattern = @"^[а-яА-ЯёЁ\-]+$";
                                Regex regex = new Regex(pattern);
                                if (regex.IsMatch(thisSubject.Name))
                                {
                                    if (thisGroup.Timetables.Count != 0)
                                    {
                                        foreach (var timetable in thisGroup.Timetables)
                                        {
                                            if (timetable.WeekDay == weekday)
                                            {
                                                thisTimetable = timetable;
                                                break;
                                            }
                                        }
                                    }
                                    if (thisTimetable.WeekDay == null)
                                    {
                                        thisTimetable = new Models.Timetable() { WeekDay = weekday };
                                        thisGroup.Timetables.Add(thisTimetable);
                                    }
                                    bool isNew = true;
                                    if (thisTimetable.Subjects != null)
                                    {
                                        foreach (var subject in thisTimetable.Subjects)
                                        {
                                            if (subject.Start == thisSubject.Start)
                                            {
                                                isNew = false;
                                                break;
                                            }
                                        }
                                    }
                                    if (isNew)
                                    {
                                        thisSubject.Finish = thisSubject.Start.AddHours(1).AddMinutes(20);
                                        thisSubject.AuditoriumId = thisSubject.Auditorium.Id;
                                        thisSubject.Auditorium = null;
                                        foreach (var timetable in thisGroup.Timetables)
                                        {
                                            if (timetable.WeekDay == weekday)
                                            {
                                                timetable.Subjects.Add(thisSubject);
                                                break;
                                            }
                                        }
                                        Messenger.Default.Send(thisGroup, "newTimetable");
                                        (obj as Window).Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("На данное время уже запланирован предмет!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Проверьте правильность ввода названия предмета. Название может состоять только из символов русского алфавита.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Для добавления предмета в расписание, все поля должны быть заполнены!");
                            }
                        }
                    });
            }
        }

        public AddingSubjectVM()
        {
            unitOfWork = new UnitOfWork();
            Messenger.Default.Register<string>(this, "weekday", w =>
            {
                unitOfWork = new UnitOfWork();
                weekday = w;
            });
            Messenger.Default.Register<Models.Group>(this, "groupForSubject", g =>
            {
                unitOfWork = new UnitOfWork();
                thisGroup = g;
            });
            Messenger.Default.Register<Course>(this, "courseForSubject", c =>
            {
                unitOfWork = new UnitOfWork();
                thisCourse = c;
                OnPropertyChanged(nameof(Teachers));
            });
            Messenger.Default.Register<Auditorium>(this, "newAudit", a =>
            {
                unitOfWork = new UnitOfWork();
                unitOfWork.Auditoriums.Create(a);
                unitOfWork.Save();
                OnPropertyChanged(nameof(Auditoriums));
            });
            Messenger.Default.Register<Teacher>(this, "newTeacher", t =>
            {
                unitOfWork = new UnitOfWork();
                bool isNew = true;
                foreach(var teacher in thisCourse.Teachers)
                {
                    if(teacher.Name == t.Name && teacher.Patronymic == t.Patronymic && teacher.Surname == t.Surname)
                    {
                        isNew = false;
                        break;
                    }
                }
                if (isNew)
                {
                    thisCourse.Teachers.Add(t);
                    unitOfWork.Courses.Update(thisCourse);
                    unitOfWork.Save();
                }
                OnPropertyChanged(nameof(Teachers));
            });
        }
    }
}
