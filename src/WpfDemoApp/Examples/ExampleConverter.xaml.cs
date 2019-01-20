using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfDemoApp.Examples
{
    /// <summary>
    /// Interaktionslogik für ExampleConverter.xaml
    /// </summary>
    public partial class ExampleConverter : Window
    {
        public ExampleConverter()
        {
            CurrentDate = DateTime.Now;
            InitializeComponent();
        }

        public DateTime CurrentDate { get; set; }
    }

    public class DateTimeToWeekendConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is DateTime dt)
            {
                if (dt.DayOfWeek == DayOfWeek.Saturday || dt.DayOfWeek == DayOfWeek.Sunday)
                    return "Ja" + parameter?.ToString();
                else
                    return "Nein" + parameter?.ToString();
            }
            return String.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
