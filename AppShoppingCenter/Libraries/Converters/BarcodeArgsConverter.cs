using System.Globalization;
using ZXing.Net.Maui;

namespace AppShoppingCenter.Libraries.Converters
{
    public class BarcodeArgsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is not BarcodeDetectionEventArgs args)
                return string.Empty;

            var result = args.Results?.FirstOrDefault();

            return result?.Value ?? string.Empty;
        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
