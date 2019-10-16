using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Cha05_01
{
    public class BoolToStringConverter : IValueConverter
    {
        public string TrueString { get; set; }
        public string FalseString { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value == true ? TrueString : FalseString;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (string)value == TrueString ? true : false;
        }
    }
}
