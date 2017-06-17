using StudBaseWPF;
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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WpfApp1.Form1Студенты ff = new WpfApp1.Form1Студенты();
            ff.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WpfApp1.Form2Преподаватели ff1 = new WpfApp1.Form2Преподаватели();
            ff1.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            WpfApp1.Form3Уроки ff2 = new WpfApp1.Form3Уроки();
            ff2.ShowDialog();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            WpfApp1.Form4Оценки ff3 = new WpfApp1.Form4Оценки();
            ff3.ShowDialog();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            WpfApp1.Form5Должность ff4 = new WpfApp1.Form5Должность();
            ff4.ShowDialog();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            WpfApp1.Form6Дисциплины ff5 = new WpfApp1.Form6Дисциплины();
            ff5.ShowDialog();
        }
    }
}
