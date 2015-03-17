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
using System.Windows.Forms;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            slider.TickFrequency = 1000.0;
                    
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.AddExtension = true;
            ofd.DefaultExt = "*.*";
            ofd.Filter = "Media(*.*)|*.*";
            ofd.ShowDialog();
            media.MediaOpened += new RoutedEventHandler(media_MediaOpened);
            media.Source = new Uri(ofd.FileName);
        }
        void media_MediaOpened(object sender, RoutedEventArgs e)
        {
            label.Content = media.Source.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            media.Pause();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            media.Play();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            media.Stop();
        }
    
        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
          
        }
    }
}
