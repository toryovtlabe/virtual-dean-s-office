using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace CourseProject.Helpers
{
    public class DateOnlyToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targettype, object parametr, CultureInfo culture)
        {
            return ((DateOnly)value).ToString("dd.MM.yyyy");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string dateString && DateOnly.TryParseExact(dateString, "dd.MM.yyyy", culture, DateTimeStyles.None, out DateOnly date))
            {
                return date;
            }
            else
            {
                MessageBox.Show("Значение не применено, т.к. введена дата неверного формата (dd.mm.yyyy)");
                return DependencyProperty.UnsetValue;
            }
        }
    }
}
