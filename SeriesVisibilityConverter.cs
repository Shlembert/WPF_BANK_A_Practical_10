using System.Globalization;
using System.Windows.Data;
using Wpf_Bank_A.Data;

namespace Wpf_Bank_A
{
    public class SeriesVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter is ModificationType modificationType && modificationType == ModificationType.Менеджер)
            {
                return value;
            }
            return "*****";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class NumberVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter is ModificationType modificationType && modificationType == ModificationType.Менеджер)
            {
                return value;
            }
            return "*****";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
