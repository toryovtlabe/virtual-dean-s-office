using CourseProject.Helpers;
using CourseProject.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    internal class Request : ObservableObject
    {
        [Key]
        [ForeignKey(nameof(StudentId))]
        int id;
        string place;
        string status;
        int studentId;
        DateOnly? deactiveDate;
        DateOnly? date;

        [NotMapped]
        public string Surname {  get; set; }
        [NotMapped]
        public string Firstname {  get; set; }
        [NotMapped]
        public string Patronymic {  get; set; }

        public int Id
        {
            get
            {
                if (StudentId != 0) { }
                return id;
            }
            set
            {
                id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        public int StudentId
        {
            get
            {
                if(studentId != 0)
                {
                    UnitOfWork unit = new();
                    Student st = unit.Students.Get(studentId);
                    Surname = st.Surname;
                    Firstname = st.Firstname;
                    Patronymic = st.Patronymic;
                }
                return studentId;
            }
            set
            {
                studentId = value;
                OnPropertyChanged(nameof(StudentId));
            }
        }

        public DateOnly? DeactiveDate
        {
            get
            {
                return deactiveDate;
            }
            set
            {
                deactiveDate = value;
                OnPropertyChanged(nameof(DeactiveDate));
            }
        }

        public DateOnly? Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
                OnPropertyChanged(nameof(Date));
            }
        }

        public string Place
        {
            get
            {
                return place;
            }
            set
            {
                place = value;
                OnPropertyChanged(nameof(Place));
            }
        }

        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
                OnPropertyChanged(nameof(Status));
            }
        }
    }
}
