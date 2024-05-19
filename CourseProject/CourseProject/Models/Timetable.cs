using CourseProject.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    internal class Timetable : ObservableObject
    {
        [Key]
        private int id;
        private string weekDay;
        private List<Subject> subjects = [];

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        public string WeekDay
        {
            get
            {
                return weekDay;
            }
            set
            {
                weekDay = value;
                OnPropertyChanged(nameof(WeekDay));
            }
        }

        public List<Subject> Subjects
        {
            get { return subjects; }
            set
            {
                subjects = value;
                OnPropertyChanged(nameof(Subjects));
            }
        }
    }
}
