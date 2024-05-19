using System.Windows.Controls;

namespace CourseProject.Views
{
    /// <summary>
    /// Логика взаимодействия для Timetable.xaml
    /// </summary>
    public partial class Timetable : UserControl
    {
        public Timetable()
        {
            InitializeComponent();
        }

        private void ListBox_PreviewMouseWheel(object sender, System.Windows.Input.MouseWheelEventArgs e)
        {
            if (e.Delta > 0)
            {
                Scroll.LineUp();
            }
            else Scroll.LineDown();
            e.Handled = true;
        }
    }
}
