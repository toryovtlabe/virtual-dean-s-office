using CourseProject.Helpers;
using System.ComponentModel.DataAnnotations;

namespace CourseProject.Models
{
    internal class Group : ObservableObject
    {
        [Key]
        private int id;
        private string name;
        private List<Student> students;
        private List<Timetable> timetables;

        public int Id
        { 
            get { return id; } 
            set {  id = value; } 
        }

        public string Name
        {
            get { return name; }
            set 
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public List<Student> Students
        {
            get { return students; }
            set
            {
                students = value;
                OnPropertyChanged("Students");
            }
        }

        public List<Timetable> Timetables
        {
            get { return timetables; }
            set
            {
                timetables = value;
                OnPropertyChanged(nameof(Timetable));
            }
        }
    }
}
