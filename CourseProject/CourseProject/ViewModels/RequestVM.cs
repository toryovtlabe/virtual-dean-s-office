using CourseProject.Helpers;
using CourseProject.Models;
using CourseProject.Repositories;
using GalaSoft.MvvmLight.Messaging;

namespace CourseProject.ViewModels
{
    internal class RequestVM : ObservableObject
    {
        private UnitOfWork unitOfWork;
        private Student thisStudent;
        private List<Request> studRequests;
        private MyCommand createRequest;
        private MyCommand delete;

        private bool isAdmin = false;
        private List<Request> requests;
        private string adminVisible;
        private MyCommand changeStatus;
        private MyCommand cancel;
        private Student student;
        public MyCommand Delete
        {
            get
            {
                return delete ??= new(
                    (obj) =>
                    {
                        if (obj is int id)
                        {
                            thisStudent.Requests = thisStudent.Requests.Where(x => x.Id != id).ToList();
                            unitOfWork.Requests.Delete(id);
                            unitOfWork.Save();
                            OnPropertyChanged(nameof(StudRequests));
                        }
                    },
                    (obj) =>
                    {
                        if (obj is int id)
                        {
                            if (unitOfWork.Requests.Get(id) != null)
                            {
                                return unitOfWork.Requests.Get(id).Status == "В обработке";
                            }
                        }
                        return false;
                    });
            }
        }

        public MyCommand ChangeStatus
        {
            get
            {
                return changeStatus ??= new(
                    (obj) =>
                    {
                        if (obj is int id)
                        {
                            Request req = unitOfWork.Requests.Get(id);
                            if (req.Status == "В обработке")
                            {
                                req.Status = "Отдана на подпись";
                            }
                            else
                            {
                                req.Status = "Готова к выдаче";
                                req.DeactiveDate = DateOnly.FromDateTime(DateTime.Now);
                            }
                            unitOfWork.Requests.Update(req);
                            unitOfWork.Save();
                        }
                    },
                    (obj) =>
                    {
                        if (obj is int id)
                        {
                            Request req = unitOfWork.Requests.Get(id);
                            return req.Status == "В обработке" || req.Status == "Отдана на подпись";
                        }
                        return false;
                    });
            }
        }

        public MyCommand Cancel
        {
            get
            {
                return cancel ??= new(
                    (obj) =>
                    {
                        if (obj is int id)
                        {
                            Request req = unitOfWork.Requests.Get(id);
                            req.Status = "Отменена";
                            req.DeactiveDate = DateOnly.FromDateTime(DateTime.Now);
                        }
                    },
                    (obj) =>
                    {
                        if (obj is int id)
                        {
                            return unitOfWork.Requests.Get(id).Status == "В обработке";
                        }
                        return false;
                    });
            }
        }

        public string AdminVisible
        {
            get
            {
                if (isAdmin) adminVisible = "visible";
                else adminVisible = "hidden";
                return adminVisible;
            }
            set
            {
                adminVisible = value;
                OnPropertyChanged(nameof(AdminVisible));
            }
        }

        public List<Request> Requests
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
        public MyCommand CreateRequest
        {
            get
            {
                return createRequest ??= new(
                    (obj) =>
                    {
                        Views.CreateRequest newWindow = new();
                        Messenger.Default.Send(thisStudent, "toCreateRequest");
                        newWindow.ShowDialog();
                    });
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

        public List<Request> StudRequests
        {
            get
            {
                if (thisStudent != null)
                    studRequests = thisStudent.Requests.ToList();
                return studRequests;
            }
            set
            {
                studRequests = value;
                OnPropertyChanged(nameof(StudRequests));
            }
        }


        public RequestVM()
        {
            unitOfWork = new UnitOfWork();
            //unitOfWork.Requests.GetAll().Where(r=>r.DeactiveDate != null && r.DeactiveDate.Value.DayNumber + 7 > DateOnly.FromDateTime(DateTime.Now).DayNumber); dodelat' udalenie!
            Messenger.Default.Register<User>(this, "toRequest", user =>
            {
                if (user.Student != null)
                {
                    isAdmin = false;
                    OnPropertyChanged(nameof(AdminVisible));
                    thisStudent = user.Student;
                    OnPropertyChanged(nameof(StudRequests));
                }
                else
                {
                    isAdmin = true;
                    OnPropertyChanged(nameof(AdminVisible));
                    Requests = unitOfWork.Requests.GetAll().ToList();
                    Requests.Reverse();
                }
            });
            Messenger.Default.Register<Request>(this, "newRequest", r =>
            {
                thisStudent.Requests.Add(r);
                unitOfWork.Requests.Create(r);
                unitOfWork.Save();
                OnPropertyChanged(nameof(StudRequests));
            });
        }
    }
}
