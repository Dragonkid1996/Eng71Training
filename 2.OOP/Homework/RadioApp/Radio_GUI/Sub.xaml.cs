using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using RadioApp;

namespace Radio_GUI
{
    /// <summary>
    /// Interaction logic for Sub.xaml
    /// </summary>
    public partial class Sub : Window
    {
        public Sub()
        {
            InitializeComponent();
        }
        public string name;
        public string url;

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            
            name = tBoxName.Text;
            url = tBoxURL.Text;
            tBoxName.Clear();
            tBoxURL.Clear();
            Hide();
        }
    }
}
