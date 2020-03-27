using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonTel_Click(object sender, RoutedEventArgs e)
        {
            //+380960426065
            Regex reg = new Regex(@"^\+380\d{9}$");
            if(reg.IsMatch(textBoxTel.Text))
            {
                labelTel.Foreground = Brushes.Green;
                labelTel.Content = "Ок";
            }
            else
            {
                labelTel.Foreground = Brushes.Red;
                labelTel.Content = "Помилка";
            }
        }

        private void buttonPass_Click(object sender, RoutedEventArgs e)
        {
            //АЯ123456789 | 123456789
            Regex reg = new Regex(@"^(([А-ЯІЄЇ]{2}\d{9})|(\d{9}))$");
            if (reg.IsMatch(textBoxPass.Text))
            {
                labelPass.Foreground = Brushes.Green;
                labelPass.Content = "Ок";
            }
            else
            {
                labelPass.Foreground = Brushes.Red;
                labelPass.Content = "Помилка";
            }
        }

        private void buttonNum_Click(object sender, RoutedEventArgs e)
        {
            // [10311,89645]
            Regex reg = new Regex(@"^[1-8]((031[1-9])|([1-8][0-9][0-9][0-9]|9[0-6][0-4][0-5]))$");
            if (reg.IsMatch(textBoxNum.Text))
            {
                labelNum.Foreground = Brushes.Green;
                labelNum.Content = "Ок";
            }
            else
            {
                labelNum.Foreground = Brushes.Red;
                labelNum.Content = "Помилка";
            }
        }

        private void buttonUkr_Click(object sender, RoutedEventArgs e)
        {
            // Арсеній
            Regex reg = new Regex(@"^[A-Яа-яіІєЄїЇ]{2,}$");
            if (reg.IsMatch(textBoxUkr.Text))
            {
                labelUkr.Foreground = Brushes.Green;
                labelUkr.Content = "Ок";
            }
            else
            {
                labelUkr.Foreground = Brushes.Red;
                labelUkr.Content = "Помилка";
            }
        }

        private void buttonTime_Click(object sender, RoutedEventArgs e)
        {
            // 15:09
            Regex reg = new Regex(@"^\d{2}:\d{2}$");
            if (reg.IsMatch(textBoxTime.Text))
            {
                labelTime.Foreground = Brushes.Green;
                labelTime.Content = "Ок";
            }
            else
            {
                labelTime.Foreground = Brushes.Red;
                labelTime.Content = "Помилка";
            }
        }

        private void buttonEmail_Click(object sender, RoutedEventArgs e)
        {
            // a1aa@a12a.a2a
            Regex reg = new Regex(@"\w+@\w+\.\w+", RegexOptions.IgnoreCase);
            if (reg.IsMatch(textBoxEmail.Text))
            {
                labelEmail.Foreground = Brushes.Green;
                labelEmail.Content = "Ок";
            }
            else
            {
                labelEmail.Foreground = Brushes.Red;
                labelEmail.Content = "Помилка";
            }
        }
    }
}
