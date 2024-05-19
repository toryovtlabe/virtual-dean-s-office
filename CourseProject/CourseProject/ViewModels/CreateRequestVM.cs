using CourseProject.Helpers;
using CourseProject.Models;
using GalaSoft.MvvmLight.Messaging;
using System.Windows;

namespace CourseProject.ViewModels
{
    internal class CreateRequestVM : ObservableObject
    {
        private Request newRequest = new();
        private Student thisStudent;
        private MyCommand createRequest;

        public Request NewRequest
        {
            get
            {
                return newRequest;
            }
            set
            {
                newRequest = value;
                OnPropertyChanged(nameof(NewRequest));
            }
        }

        public MyCommand CreateRequest
        {
            get
            {
                return createRequest ??= new(
                    (obj) =>
                    {
                        if (!String.IsNullOrEmpty(newRequest.Place))
                        {
                            bool isNew = true;
                            if (thisStudent != null)
                            {
                                foreach (var request in thisStudent.Requests)
                                {
                                    if (request.Place.Equals(newRequest.Place))
                                    {
                                        isNew = false;
                                        MessageBox.Show("Вы уже запросили справку по этому месту требования");
                                        break;
                                    }
                                }
                            }
                            if (isNew)
                            {
                                newRequest.Date = DateOnly.FromDateTime(DateTime.Now);
                                newRequest.Status = "В обработке";
                                newRequest.StudentId = thisStudent.Id;
                                Messenger.Default.Send(newRequest, "newRequest");
                                (obj as Window).Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Необходимо указать место требования");
                        }
                    });
            }
        }

        public CreateRequestVM()
        {
            Messenger.Default.Register<Student>(this, "toCreateRequest", s =>
            {
                thisStudent = s;
            });
        }
    }
}
