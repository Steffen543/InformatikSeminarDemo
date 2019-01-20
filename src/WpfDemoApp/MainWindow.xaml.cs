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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfDemoApp
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            Button bt = sender as Button;

            switch (bt.Content)
            {
                case "ExampleWindow":
                    new Examples.ExampleWindow().ShowDialog();
                    break;
                case "ExampleResource":
                    new Examples.ExampleResources().ShowDialog();
                    break;
                case "ExampleBinding":
                    new Examples.ExampleBinding().ShowDialog();
                    break;
                case "ExampleConverter":
                    new Examples.ExampleConverter().ShowDialog();
                    break;
                case "ExampleStyle":
                    new Examples.ExampleStyle().ShowDialog();
                    break;
                case "ExampleDataTemplate":
                    new Examples.ExampleDataTemplates().ShowDialog();
                    break;
                case "ExampleMVVM":
                    new Examples.ExampleMVVM().ShowDialog();
                    break;
                case "ExampleDevExpressMVVM":
                    new Examples.ExampleDevExpressMVVM().ShowDialog();
                    break;
            }
        }
    }
}
