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
    /// Interaktionslogik für ExampleStyle.xaml
    /// </summary>
    public partial class ExampleStyle : Window
    {
        public ExampleStyle()
        {
            HandlerTest();
            InitializeComponent();
        }

        void HandlerTest()
        {
            var button = new Button();
            button.Click += Button_Click;
            button.Click += (s, e) => { MessageBox.Show("Also clicked"); };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Clicked");
        }
    }
}
