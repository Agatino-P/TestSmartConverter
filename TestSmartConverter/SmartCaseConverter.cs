using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Markup;

namespace TestSmartConverter
{
    public enum ConverterCase{None, Upper, Lower }
    public class SmartCaseConverter : MarkupExtension, IValueConverter
    {
        public ConverterCase ConverterCase { get; set; } = ConverterCase.None;

        public object  Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (ConverterCase)
            {
                case ConverterCase.None:
                    return $"None { value.ToString()}";
                case ConverterCase.Upper:
                    return $"Upper {value.ToString().ToUpperInvariant()}";
                case ConverterCase.Lower:
                    return $"Lower {value.ToString().ToLowerInvariant()}";
                default:
                    return "string.Empty";
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return "-" + value.ToString() + "-";
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
