using System;
using Microsoft.Win32;
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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show();
            this.Close();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog { Filter = "Image Files| *.jpg;*.jpeg;*.png;*.gif;*.bmp;" };
            if (openFileDialog.ShowDialog() == true)
            {
                BitmapImage bitmapImage = new BitmapImage(new Uri(openFileDialog.FileName));
                DisplayImage.Source = bitmapImage;
            }
        }

        private void Kakahe_Click(object sender, RoutedEventArgs e)
        {
            kakahe.Text = "пуки каки";
        }

        private void Button_Click_kombo(object sender, RoutedEventArgs e)
        {
            Window2 window = new Window2();
            window.Show();
            this.Close();
        }

        private void Button_Click_win3(object sender, RoutedEventArgs e)
        {
            Window3 window = new Window3();
            window.Show();
            this.Close();
        }
    }
}
