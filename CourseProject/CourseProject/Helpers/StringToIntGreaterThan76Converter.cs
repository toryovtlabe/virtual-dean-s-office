using System.Globalization;
using System.Windows.Data;

namespace CourseProject.Helpers
{
    public class StringToIntGreaterThan76Converter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int number;
            if (int.TryParse((string)value, out number))
                return number > 76;
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
