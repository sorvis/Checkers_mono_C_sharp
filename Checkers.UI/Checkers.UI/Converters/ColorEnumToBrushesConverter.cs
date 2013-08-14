using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Checkers.UI.Converters
{
    class ColorEnumToBrushesConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null && value is BlackWhiteColor)
            {
                switch((BlackWhiteColor) value)
                {
                    case BlackWhiteColor.Black:
                        return Brushes.Black;
                    case BlackWhiteColor.White:
                        return Brushes.White;
                }
            }
            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
