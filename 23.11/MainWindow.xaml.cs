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

namespace _23._11
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

        private void textDigits(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int cost = Convert.ToInt32(autoCost.Text);
            int firstVznos = Convert.ToInt32(firstEntry.Text);
            int srokVznosa = Convert.ToInt32(years.Text) * 12;
            double procentVznosa = Convert.ToDouble(procent.Text) / 100;

            int summaVznosa = cost - firstVznos;
            int summaEzhViplat = summaVznosa / srokVznosa;
            double summaProcentov = summaVznosa * procentVznosa / 12;
            double ezhPlatezh = summaEzhViplat + summaProcentov;
            double credit = ezhPlatezh * srokVznosa;
            label1.Content = $"Сумма кредита: {Math.Truncate(credit).ToString()} рублей {Math.Round(((credit-Math.Truncate(credit))*100)).ToString()} копеек";
        }
    }
}
