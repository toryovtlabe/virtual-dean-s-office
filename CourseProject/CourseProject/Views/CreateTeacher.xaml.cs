using CourseProject.ViewModels;
using System.Windows;
using System.Windows.Input;

namespace CourseProject.Views
{
    /// <summary>
    /// Логика взаимодействия для CreateTeacher.xaml
    /// </summary>
    public partial class CreateTeacher : Window
    {
        public CreateTeacher()
        {
            InitializeComponent();
            //this.DataContext = CreateTeacherVM.getInstance();
            this.DataContext = new CreateTeacherVM();
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
