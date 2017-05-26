using System;
using Xamarin.Forms;

namespace ToDo
{
    public class DateTimeConverter : IValueConverter
    {

        public object Convert(object value, Type typeTarget, object parameter, System.Globalization.CultureInfo culture)
        {
            var time = (DateTime)value;
            return time.ToString("M/d/yyyy h:mm tt");
        }

        public object ConvertBack(object value, Type typeTarget, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
