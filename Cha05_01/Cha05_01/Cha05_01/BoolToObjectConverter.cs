using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Cha05_01
{

    public class BoolToObjectConverter<T> : IValueConverter
    {
        public T TrueObject { get; set; }
        public T FalseObject { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value == true ? TrueObject : FalseObject;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((T)value).Equals(this.TrueObject);
        }
    }
}
