using System;
using System.Globalization;
using System.Windows.Data;
using Wpf_Bank_A.Data;

namespace Wpf_Bank_A
{
    public class SeriesVisibilityConverter : IValueConverter
    {
        public ModificationType ModificationType { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter is ModificationType modificationType && modificationType == ModificationType.Консультант)
            {
                if (value is string text && text.Length == 4)
                {
                    return new string('*', text.Length);
                }
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class NumberVisibilityConverter : IValueConverter
    {
        public ModificationType ModificationType { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter is ModificationType modificationType && modificationType == ModificationType.Консультант)
            {
                if (value is string text && text.Length == 6)
                {
                    return new string('*', text.Length);
                }
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
