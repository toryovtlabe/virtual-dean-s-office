using CourseProject.Helpers;
using CourseProject.Repositories;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Windows.Media.Imaging;

namespace CourseProject.Models
{
    internal class Student : ObservableObject, IComparable
    {
        [Key]
        [ForeignKey("GroupId")]
        private int id;
        private string surname;
        private string firstname;
        private string patronymic;
        private DateOnly hb;
        private List<Progress>? progresses;
        private List<Request>? requests;
        private bool isHeadman;
        private int groupId;
        private byte[] image;

        [NotMapped]
        public int CourseName {  get; set; }
        [NotMapped]
        public string SpecName {  get; set; }
        [NotMapped]
        public string GroupName { get; set; }

        public byte[] Image
        {
            get
            {
                if (image == null)
                {
                    Uri resourceUri = new("pack://application:,,,/Resources/student.png", UriKind.Absolute);
                    BitmapImage imagefile = new BitmapImage(resourceUri);
                    image = ImageToByteConverter.ImageToByteArray(imagefile);
                }
                return image;
            }
            set
            {
                image = value;
                OnPropertyChanged(nameof(image));
            }
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public int GroupId
        {
            get
            {
                if(groupId != 0)
                {
                    UnitOfWork unit = new();
                    foreach(var spec in unit.Specialities.GetAll())
                    {
                        foreach(var course in spec.Courses)
                        {
                            foreach(var group in course.Groups)
                            {
                                if(group.Id == groupId)
                                {
                                    GroupName = group.Name;
                                    CourseName = course.CourseNum;
                                    SpecName = spec.Name;
                                    break;
                                }
                            }
                        }
                    }
                }
                return groupId;
            }
            set
            {
                groupId = value;
                OnPropertyChanged(nameof(GroupId));
            }
        }

        public string Surname
        {
            get
            {
                if (GroupId != 0) { }
                return surname;
            }
            set
            {
                if (value.Length > 0)
                {
                    char firstletter = char.ToUpper(value[0]);
                    surname = firstletter + value[1..].ToLower();
                }
                OnPropertyChanged("Surname");
            }
        }

        public string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                if (value.Length > 0)
                {
                    char firstletter = char.ToUpper(value[0]);
                    firstname = firstletter + value[1..].ToLower();
                }
                OnPropertyChanged("Firstname");
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
                if (value.Length > 0)
                {
                    char firstletter = char.ToUpper(value[0]);
                    patronymic = firstletter + value[1..].ToLower();
                }
                OnPropertyChanged("Patronymic");
            }
        }

        public DateOnly Hb
        {
            get
            {
                return hb;
            }
            set
            {
                hb = value;
                OnPropertyChanged("Hb");
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
                OnPropertyChanged("Progress");
            }
        }

        public List<Request>? Requests
        {
            get
            {
                return requests;
            }
            set
            {
                requests = value;
                OnPropertyChanged(nameof(Requests));
            }
        }

        public bool IsHeadman
        {
            get
            {
                return isHeadman;
            }
            set
            {
                isHeadman = value;
                OnPropertyChanged("IsHeadman");
            }
        }

        public int CompareTo(object? o)
        {
            if (o is Student student) return Surname.CompareTo(student.Surname);
            else throw new ArgumentException("Некорректное значение параметра");
        }
    }
}
