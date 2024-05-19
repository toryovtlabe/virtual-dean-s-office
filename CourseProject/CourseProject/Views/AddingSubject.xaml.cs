using System.Windows;
using System.Windows.Input;

namespace CourseProject.Views
{
    /// <summary>
    /// Логика взаимодействия для AddingSubject.xaml
    /// </summary>
    public partial class AddingSubject : Window
    {
        public AddingSubject()
        {
            InitializeComponent();
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
