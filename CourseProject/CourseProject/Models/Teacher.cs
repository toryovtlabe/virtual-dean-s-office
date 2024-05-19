using CourseProject.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    internal class Teacher : ObservableObject
    {
        [Key]
        private int id;
        private string name;
        private string surname;
        private string patronymic;

        public int Id { 
            get 
            {
                return id;
            } 
            set 
            {
                id = value;
                OnPropertyChanged(nameof(Id));
            } 
        }

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

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
                OnPropertyChanged(nameof(Surname));
            }
        }

        public string Patronymic
        {
            get
            {
                return patronymic;
            }
            set
            {
                patronymic = value;
                OnPropertyChanged(nameof(Patronymic));
            }
        }
        [NotMapped]
        public string Fullname 
        {
            get
            {
                char firstletter = char.ToUpper(Surname[0]);

                return firstletter + Surname.Substring(1) + ' ' + Name.ToUpper().First() + ". " + Patronymic.ToUpper().First() + '.'; 
            }
        }
    }
}
