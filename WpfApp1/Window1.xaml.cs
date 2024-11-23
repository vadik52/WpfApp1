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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void thunder(object sender, RoutedEventArgs e)
        {
            if (RadioBtn3.IsChecked == true)
            {
                MessageBox.Show("правильно!");
            }
            if (RadioBtn.IsChecked == true)
            {
                MessageBox.Show("неправилно!");
            }
            if (RadioBtn2.IsChecked == true)
            {
                MessageBox.Show("неправилно!");
            }
        }

        private void lox(object sender, RoutedEventArgs e)
        {
            if (RadioBt.IsChecked == true)
            {
                MessageBox.Show("правильно!");
            }
            if (RadioBt2.IsChecked == true)
            {
                MessageBox.Show("неправилно!");
            }
            if (RadioBt3.IsChecked == true)
            {
                MessageBox.Show("неправилно!");
            }
            if (RadioBt4.IsChecked == true)
            {
                MessageBox.Show("неправилно!");
            }
        }
        private void tanki(object sender, RoutedEventArgs e)
        {
            if (RadioB.IsChecked == true)
            {
                MessageBox.Show("правильно!");
            }
            if (RadioB2.IsChecked == true)
            {
                MessageBox.Show("ты предал танк!");
            }
            if (RadioB3.IsChecked == true)
            {
                MessageBox.Show("правильно!");
            }
            if (RadioB4.IsChecked == true)
            {
                MessageBox.Show("пей пиво!");
            }
        }
        private void visual(object sender, RoutedEventArgs e)
        {
            if (Radio.IsChecked == true)
            {
                MessageBox.Show("неправильно!");
            }
            if (Radio2.IsChecked == true)
            {
                MessageBox.Show("правильно!");
            }
            if (Radio3.IsChecked == true)
            {
                MessageBox.Show("неправильно!");
            }
            if (Radio4.IsChecked == true)
            {
                MessageBox.Show("неправильно!");
            }
        }
    }
}
