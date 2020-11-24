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
using RadioApp;

namespace Radio_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            form.Hide();
            channelListBox.ItemsSource = r.channels.Keys;
        }

        public Radio r = new Radio();
        bool isPlaying = false;
        Sub form = new Sub();

        private void btnOnOff_Click(object sender, RoutedEventArgs e)
        {
            if (r.On)
            {
                btnOnOff.Content = "On";
                Player.Volume = 0;
                r.TurnOff();
            }               
            else
            {
                btnOnOff.Content = "Off";
                if (isPlaying)
                    Player.Volume = 0.5;
                else
                {
                    Player.Source = new Uri(@"http://us5.internet-radio.com:8267/", UriKind.RelativeOrAbsolute);
                    Player.Play();
                    isPlaying = true;
                }
                                    
                r.TurnOn();
            }
                
        }

        private void channelListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var station = sender as ListBox;
            string fromDict = r.channels[station.SelectedItem.ToString()];
            if (r.On)
            {
                Player.Source = new Uri($"{fromDict}", UriKind.RelativeOrAbsolute);
                Player.Play();
                isPlaying = true;
            }
            else
            {
                MessageBox.Show("The radio is turned off");
            }
        }

        private void btnVolUp_Click(object sender, RoutedEventArgs e)
        {
            Player.Volume = r.VolumeUp();
        }

        private void btnVolDown_Click(object sender, RoutedEventArgs e)
        {
            Player.Volume = r.VolumeDown();
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            form.ShowDialog();
            r.channels.Add(form.name, form.url);
            channelListBox.ItemsSource = null;
            channelListBox.ItemsSource = r.channels.Keys;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            form.Close();
        }
    }
}
