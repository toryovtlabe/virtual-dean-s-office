using CourseProject.Helpers;
using CourseProject.Models;
using CourseProject.Repositories;
using CourseProject.Views;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Win32;
using System.IO;

namespace CourseProject.ViewModels
{
    internal class NewsVM : ObservableObject
    {

        private UnitOfWork unitOfWork;


        private List<Models.News> news;
        public List<Models.News> News
        {
            get
            {
                news = unitOfWork.NewsRepository.GetAll().ToList();
                news.Reverse();
                return news;
            }
            set
            {
                news = value;
                OnPropertyChanged(nameof(News));
            }
        }

        private MyCommand createNews;
        public MyCommand CreateNews
        {
            get
            {
                return createNews ??= new MyCommand(
                    (obj) =>
                    {
                        CreateNews newWindow = new();
                        newWindow.ShowDialog();
                    });
            }
        }

        private MyCommand deleteNews;
        public MyCommand DeleteNews
        {
            get
            {
                return deleteNews ??= new MyCommand(
                    (obj) =>
                    {
                        if (obj is int id)
                        {
                            unitOfWork.NewsRepository.Delete(id);
                            unitOfWork.Save();
                            OnPropertyChanged(nameof(News));
                        }
                    });
            }
        }

        private string isRedact = "hidden";
        public string IsRedact
        {
            get
            {
                return isRedact;
            }
            set
            {
                isRedact = value;
                OnPropertyChanged(nameof(IsRedact));
            }
        }

        private string visibilityPanel = "0";
        public string VisibilityPanel
        {
            get
            {
                return visibilityPanel;
            }
            set
            {
                visibilityPanel = value;
                OnPropertyChanged(nameof(VisibilityPanel));
            }
        }

        private MyCommand redactNews;
        public MyCommand RedactNews
        {
            get
            {
                return redactNews ??= new MyCommand(
                    (obj) =>
                    {
                        if (IsRedact == "hidden") IsRedact = "visible";
                        else
                        {
                            IsRedact = "hidden";
                            foreach (var item in News)
                            {
                                unitOfWork.NewsRepository.Update(item);
                                unitOfWork.Save();
                            }
                        }
                    });
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
                        if (obj is Models.News news)
                        {
                            OpenFileDialog opf = new OpenFileDialog();
                            opf.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";
                            if (opf.ShowDialog() == true)
                            {
                                news.Photo = File.ReadAllBytes(opf.FileName);
                            }
                        }
                    });
            }

        }

        public NewsVM()
        {
            unitOfWork = new();
            Messenger.Default.Register<User>(this, "authorizedUser", u =>
            {
                if (u.Student != null)
                {
                    VisibilityPanel = "0";
                }
                else VisibilityPanel = "50";
            });
            Messenger.Default.Register<Models.News>(this, "news created", g =>
            {
                unitOfWork.NewsRepository.Create(g);
                unitOfWork.Save();
                OnPropertyChanged(nameof(News));
            });
        }
    }
}
