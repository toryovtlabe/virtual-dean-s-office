using CourseProject.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CourseProject.Models
{
    internal class News : ObservableObject
    {
        [Key]
        private int id;
        private string name;
        private string info;
        private DateOnly date;
        private byte[] photo;

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

        public string Name
        {
            get 
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Info
        {
            get
            {
                return info;
            }
            set
            {
                info = value;
                OnPropertyChanged("Info");
            }
        }

        public DateOnly Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
                OnPropertyChanged("Date");
            }
        }

        public byte[] Photo
        {
            get
            {
                if (photo == null)
                {
                    Uri resourceUri = new("pack://application:,,,/Resources/newsdefault.jpg", UriKind.Absolute);
                    BitmapImage imagefile = new BitmapImage(resourceUri);
                    photo = ImageToByteConverter.ImageToByteArray(imagefile);
                }
                return photo;
            }
            set
            {
                photo = value;
                OnPropertyChanged("Photo");
            }
        }
    }
}
