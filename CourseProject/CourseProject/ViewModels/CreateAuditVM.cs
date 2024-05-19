using CourseProject.Helpers;
using CourseProject.Models;
using CourseProject.Repositories;
using GalaSoft.MvvmLight.Messaging;
using System.Text.RegularExpressions;
using System.Windows;

namespace CourseProject.ViewModels
{
    class CreateAuditVM : ObservableObject
    {
        //private static CreateAuditVM? instance;
        private string name;
        private Auditorium thisAuditorium = new();
        private MyCommand type;
        private MyCommand save;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public Auditorium ThisAuditorium
        {
            get
            {
                return thisAuditorium;
            }
            set
            {
                thisAuditorium = value;
                OnPropertyChanged(nameof(ThisAuditorium));
            }
        }

        public MyCommand Type
        {
            get
            {
                return type ??= new(
                    (obj) =>
                    {
                        if (obj is string str)
                        {
                            ThisAuditorium.Type = str;
                        }
                    });
            }
        }

        //public static CreateAuditVM getInstance()
        //{
        //    if (instance == null)
        //    {
        //        instance = new();
        //    }
        //    return instance;
        //}

        public MyCommand Save
        {
            get
            {
                return save ??= new(
                    (obj) =>
                    {
                        if (Name != null && obj is Window win && ThisAuditorium.Type != null)
                        {
                            string pattern = @"^[1-4][0-9][0-9]-[1-4]$";
                            Regex regex = new Regex(pattern);
                            if (regex.IsMatch(Name))
                            {
                                UnitOfWork unit = new();
                                bool isNew = true;
                                foreach (var audit in unit.Auditoriums.GetAll())
                                {
                                    if (audit.Name == Name)
                                    {
                                        isNew = false;
                                        break;
                                    }
                                }
                                if (isNew)
                                {
                                    ThisAuditorium.Name = name;
                                    Messenger.Default.Send(ThisAuditorium, "newAudit");
                                    win.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Аудитория с таким номером уже существует.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Неверный формат ввода номера аудитории (Пример:102-2)");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Необходимо указать номер и выбрать тип аудитории");
                        }
                    });
            }
        }
    }
}
