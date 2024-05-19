using CourseProject.ViewModels;
using System.Windows;
using System.Windows.Input;

namespace CourseProject.Views
{
    /// <summary>
    /// Логика взаимодействия для CreateAuditorium.xaml
    /// </summary>
    public partial class CreateAuditorium : Window
    {
        public CreateAuditorium()
        {
            InitializeComponent();
            //this.DataContext = CreateAuditVM.getInstance();
            this.DataContext = new CreateAuditVM();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
