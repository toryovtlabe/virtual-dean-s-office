using CourseProject.Helpers;
using System.ComponentModel.DataAnnotations;

namespace CourseProject.Models
{
    internal class User : ObservableObject
    {
        [Key]
        private int id;
        private string login;
        private string password;
        private Student? student;

        public int Id
        {
            get { return id; } 
            set
            {
                id = value;
            }
        }

        public Student? Student
        {
            get
            {
                return student;
            }
            set
            {
                student = value;
                OnPropertyChanged("Student");
            }
        }

        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
                OnPropertyChanged("Login");
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }
    }
}
