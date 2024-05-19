using CourseProject.Helpers;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseProject.Models
{
    internal class Subject : ObservableObject, IComparable<Subject>
    {
        [Key]
        [ForeignKey("AuditoriumId")]
        private int id;
        private string name;
        private TimeOnly start;
        private TimeOnly finish;
        private List<Progress>? progresses;
        private Teacher teacher;
        private Auditorium auditorium;
        private int auditoriumId;

        public int AuditoriumId
        {
            get
            {
                return auditoriumId;
            }
            set
            {
                auditoriumId = value;
                OnPropertyChanged(nameof(AuditoriumId));
            }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
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

        public TimeOnly Start
        {
            get { return start; }
            set
            {
                start = value;
                OnPropertyChanged("Start");
            }
        }

        public TimeOnly Finish
        {
            get { return finish; }
            set
            {
                finish = value;
                OnPropertyChanged("Finish");
            }
        }

        public Auditorium Auditorium
        {
            get { return auditorium; }
            set
            {
                auditorium = value;
                OnPropertyChanged("Auditorium");
            }
        }

        public Teacher Teacher
        {
            get
            {
                return teacher;
            }
            set
            {
                teacher = value;
                OnPropertyChanged(nameof(Teacher));
            }
        }


        public List<Progress>? Progresses
        {
            get
            {
                return progresses;
            }
            set
            {
                progresses = value;
                OnPropertyChanged("Progresses");
            }
        }

        public int CompareTo(Subject? subject)
        {
            if(subject is null) throw new ArgumentNullException("Некорректное значение Subject");
            else return Start.CompareTo(subject.Start);
        }
            
    }
}
