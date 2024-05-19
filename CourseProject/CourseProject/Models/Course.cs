using CourseProject.Helpers;
using System.ComponentModel.DataAnnotations;

namespace CourseProject.Models
{
    internal class Course : ObservableObject
    {
        [Key]
        private int id;
        private int courseNum;
        private List<Group> groups;
        private List<Teacher> teachers;

        public int Id 
        {
            get { return id; }
            set 
            {
                id = value; 
                OnPropertyChanged(nameof(Id));
            } 
        }
        
        public int CourseNum
        {
            get
            {
                return courseNum;
            }
            set
            {
                courseNum = value;
                OnPropertyChanged(nameof(CourseNum));
            }
        }

        public List<Group> Groups
        {
            get { return groups; }
            set
            {
                groups = value;
                OnPropertyChanged(nameof(Groups));
            }
        }

        public List<Teacher> Teachers
        {
            get { return teachers; }
            set
            {
                teachers = value;
                OnPropertyChanged(nameof(Teachers));
            }
        }
    }
}
