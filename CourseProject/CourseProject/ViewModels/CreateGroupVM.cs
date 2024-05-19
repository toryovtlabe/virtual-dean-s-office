using CourseProject.Helpers;
using CourseProject.Models;
using CourseProject.Repositories;
using GalaSoft.MvvmLight.Messaging;
using System.Text.RegularExpressions;
using System.Windows;

namespace CourseProject.ViewModels
{
    internal class CreateGroupVM : ObservableObject
    {
        private string name;
        private Course thisCourse;
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

        public MyCommand Save
        {
            get
            {
                return save ??= new(
                    (obj) =>
                    {
                        if (Name != null && obj is Window win && thisCourse != null)
                        {
                            string pattern = @"^1[0-9]-[1-2]$|^[1-9]-[1-2]$";
                            Regex regex = new Regex(pattern);
                            if (regex.IsMatch(Name))
                            {
                                UnitOfWork unit = new();
                                bool isNew = true;
                                foreach (var group in thisCourse.Groups)
                                {
                                    if (group.Name == Name)
                                    {
                                        isNew = false;
                                        break;
                                    }
                                }
                                if (isNew)
                                {
                                    Messenger.Default.Send(Name, "newGroup");
                                    win.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Группу с таким номером уже существует.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Неверный формат номера группы (00-0 или 0-0)");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Необходимо указать номер группы.");
                        }
                    });
            }
        }

        public CreateGroupVM()
        {
            Messenger.Default.Register<Course>(this, "toCreateGroup", (c) =>
            {
                thisCourse = c;
            });
        }
    }
}
