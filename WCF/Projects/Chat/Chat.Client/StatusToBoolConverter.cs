using System;
using System.Globalization;
using System.Windows.Data;

namespace Client
{
    public class StatusToBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return (ConnectionStatus)value != ConnectionStatus.Connected;
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}