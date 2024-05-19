using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Input;

namespace CourseProject.Views
{
    /// <summary>
    /// Логика взаимодействия для Perfomance.xaml
    /// </summary>
    public partial class Perfomance : UserControl
    {
        public Perfomance()
        {
            InitializeComponent();
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = MyRegex();
            if (regex.IsMatch(e.Text))
            {
                TextBox textBox = sender as TextBox;
                if (textBox != null)
                {
                    textBox.Text = String.Empty;
                }
                e.Handled = true;
            }
        }

        private void MarkValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = MyRegex();
            if (regex.IsMatch(e.Text))
            {
                TextBox textBox = sender as TextBox;
                if (textBox != null)
                {
                    textBox.Text = String.Empty;
                }
                e.Handled = true;
            }
        }

        [GeneratedRegex("[^0-9]+")]
        private static partial Regex MyRegex();
    }
}
