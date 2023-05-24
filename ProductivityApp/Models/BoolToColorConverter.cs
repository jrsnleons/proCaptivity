using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ProductivityApp.Models
{
    public class BoolToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if ((bool)value)
                return Color.FromHex("#707f90");
            else
                return Color.White;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
