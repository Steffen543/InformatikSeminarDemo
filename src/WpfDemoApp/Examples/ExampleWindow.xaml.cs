﻿using System;
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
    /// Interaktionslogik für ExampleWindow.xaml
    /// </summary>
    public partial class ExampleWindow : Window
    {
        public ExampleWindow()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Message");
        }
    }
}
