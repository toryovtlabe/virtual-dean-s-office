using CourseProject.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CourseProject.Models
{
    internal class Progress : ObservableObject
    {
        [Key]
        private int id;
        private int mark;
        private int skips;
        private Subject subject;
        private Student student;

        public int Id 
        {
            get { return id; } 
            set { id = value; }
        }

        public int Skips
        {
            get
            {
                return skips;
            }
            set
            {
                skips = value;
                OnPropertyChanged(nameof(Skips));
            }
        }

        public int Mark
        {
            get
            {
                return mark;
            }
            set
            {
                mark = value;
                OnPropertyChanged("Mark");
            }
        }

        public Subject Subject
        {
            get
            {
                return subject;
            }
            set
            {
                subject = value;
                OnPropertyChanged(nameof(Subject));
            }
        }

        public Student Student
        {
            get
            {
                return student;
            }
            set
            {
                student = value;
                OnPropertyChanged(nameof(Student));
            }
        }
    }
}
