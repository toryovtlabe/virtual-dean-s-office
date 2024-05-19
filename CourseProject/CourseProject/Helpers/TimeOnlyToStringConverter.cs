using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace CourseProject.Helpers
{
    public class TimeOnlyToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targettype, object parametr, CultureInfo culture)
        {
            return ((TimeOnly)value).ToString("HH:mm");
        }

        public object ConvertBack(object value, Type targettype, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
