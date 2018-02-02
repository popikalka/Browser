using PersonalBrowser.Wpf.Model;
using System;
using System.Globalization;
using System.Windows.Data;

namespace PersonalBrowser.Wpf.Converters
{
    public class UrlConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value == null ? "http://www.google.com" : ((LinkUi)value).Address.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
