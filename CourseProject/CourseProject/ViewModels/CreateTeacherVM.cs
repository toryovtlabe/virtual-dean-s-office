using CourseProject.Helpers;
using CourseProject.Models;
using CourseProject.Repositories;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace CourseProject.ViewModels
{
    internal class CreateTeacherVM : ObservableObject
    {
        //private static CreateTeacherVM? instance;
        private Teacher thisTeacher = new();
        private Course thisCourse;
        private MyCommand save;
        public Teacher ThisTeacher
        {
            get
            {
                return thisTeacher;
            }
            set
            {
                thisTeacher= value;
                OnPropertyChanged(nameof(ThisTeacher));
            }
        }

        public MyCommand Save
        {
            get
            {
                return save ??= new(
                    (obj) =>
                    {
                        if (thisTeacher.Name != null && thisTeacher.Surname != null && thisTeacher.Patronymic != null && obj is Window win)
                        {
                            string pattern = @"^[а-яА-ЯёЁ]+$";
                            Regex regex = new Regex(pattern);
                            if (regex.IsMatch(thisTeacher.Name) && regex.IsMatch(thisTeacher.Surname) && regex.IsMatch(thisTeacher.Patronymic)) {
                                UnitOfWork unit = new();
                                bool isNew = true;
                                foreach (var teacher in thisCourse.Teachers)
                                {
                                    if (teacher.Surname == thisTeacher.Surname && teacher.Name == thisTeacher.Name && teacher.Patronymic == thisTeacher.Patronymic)
                                    {
                                        isNew = false;
                                        break;
                                    }
                                }
                                if (isNew)
                                {
                                    Messenger.Default.Send(thisTeacher, "newTeacher");
                                    //ThisTeacher = new();
                                    win.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Данный преподаватель уже создан.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Проверьте правильность ввода данных о преподавателе. Поля должны быть заполнены только символами русского алфавита");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Необходимо указать фамилию, имя и отчество преподавателя");
                        }
                    });
            }
        }

        //public static CreateTeacherVM getInstance()
        //{
        //    if (instance == null)
        //    {
        //        instance = new();
        //    }
        //    return instance;
        //}

        public CreateTeacherVM()
        {
            Messenger.Default.Register<Course>(this, "toCreateTeacher", (c) =>
            {
                thisCourse = c;
            });
        }

    }
}
