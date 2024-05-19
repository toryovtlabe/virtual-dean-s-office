using CourseProject.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    internal class Speciality : ObservableObject
    {
        [Key]
        int id;
        string name;
        List<Course> courses;

        public int Id
        {
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

        public List<Course> Courses
        {
            get
            {
                return courses;
            }
            set
            {
                courses = value;
                OnPropertyChanged(nameof(Courses));
            }
        }
    }
}
