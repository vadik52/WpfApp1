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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string imgsourcel1 = @"C:\kakaha113.png";
        private string imgsourcel2 = @"C:\rikardo.gif";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            win2 window = new win2();
            window.Show();
            this.Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("приложение закрылось");
            Application.Current.Shutdown();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            DisplayImage.Source = new BitmapImage(new Uri(imgsourcel1));
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            DisplayImage.Source = new BitmapImage(new Uri(imgsourcel2));
        }
    }
}
