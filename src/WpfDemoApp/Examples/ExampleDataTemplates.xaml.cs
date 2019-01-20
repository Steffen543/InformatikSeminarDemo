using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaktionslogik für ExampleDataTemplates.xaml
    /// </summary>
    public partial class ExampleDataTemplates : Window
    {
        public ObservableCollection<string> Names { get; set; }

        public ExampleDataTemplates()
        {
            Names = new ObservableCollection<string>()
            {
                "Hallo 12345",
                "Max Mustermann",
                "Hello World"
            };
            InitializeComponent();
        }

        
    }
}
