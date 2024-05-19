using CourseProject.Helpers;
using CourseProject.Models;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace CourseProject.ViewModels
{
    internal class CreateNewsVM : ObservableObject
    {

        private News news = new();
        public News News
        {
            get
            {
                return news;
            }
            set
            {
                news = value;
                OnPropertyChanged("News");
            }
        }

        private MyCommand addImage;
        public MyCommand AddImage
        {
            get
            {
                return addImage ??= new MyCommand(
                    (obj) =>
                    {
                        OpenFileDialog opf = new OpenFileDialog();
                        opf.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";
                        if (opf.ShowDialog() == true)
                        {
                            News.Photo = File.ReadAllBytes(opf.FileName);
                        }
                    });
            }

        }

        private MyCommand saveNews;
        public MyCommand SaveNews
        {
            get
            {
                return saveNews ??= new MyCommand(
                    (obj) =>
                    {
                        if (News.Info != null && News.Name != null)
                        {
                            News.Date = DateOnly.FromDateTime(DateTime.Now);
                            Messenger.Default.Send(News, "news created");
                            (obj as Window).Close();
                            MessageBox.Show("Новость добавлена!");
                        }
                        else
                        {
                            MessageBox.Show("Необходимо указать заголовок и информацию");
                        }
                    });
            }
        }
    }
}
