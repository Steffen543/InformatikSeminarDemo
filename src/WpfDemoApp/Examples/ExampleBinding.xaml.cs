using System;
using System.Collections.Generic;
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
    /// Interaktionslogik für ExampleBinding.xaml
    /// </summary>
    public partial class ExampleBinding : Window
    {
        // Dependency Property
        public static readonly DependencyProperty CurrentTimeProperty =
            DependencyProperty.Register("CurrentTime", typeof(DateTime),
                typeof(ExampleBinding), new FrameworkPropertyMetadata(DateTime.Now));

        // .NET Property wrapper
        public DateTime CurrentTime
        {
            get { return (DateTime)GetValue(CurrentTimeProperty); }
            set { SetValue(CurrentTimeProperty, value); }
        }

        public ExampleBinding()
        {
            InitializeComponent();
        }
    }
}
