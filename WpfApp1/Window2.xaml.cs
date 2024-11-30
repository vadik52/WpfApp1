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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            kakahe.Source = new BitmapImage(new Uri(@"C:\rikardo.gif"));
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            file.Source = new BitmapImage(new Uri(@"C:\kakaha113.png"));
        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            turms.Source = new BitmapImage(new Uri(@"C:\turmsik.jpg"));
        }
    }
}
