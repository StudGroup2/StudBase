﻿using System;
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

namespace WpfApp2
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

        private void Button_Stud(object sender, RoutedEventArgs e)
        {
            WpfApp2.Stud f3 = new WpfApp2.Stud();
            f3.ShowDialog();
        }
        private void MenuItem_Stud(object sender, RoutedEventArgs e)
        {
            WpfApp2.Stud f3 = new WpfApp2.Stud();
            f3.ShowDialog();
        }

        private void MenuItem_Prepod(object sender, RoutedEventArgs e)
        {
            WpfApp2.Prepod f3 = new WpfApp2.Prepod();
            f3.ShowDialog();
        }

        private void MenuItem_Num(object sender, RoutedEventArgs e)
        {
            WpfApp2.Оценки f3 = new WpfApp2.Оценки();
            f3.ShowDialog();
        }

        private void MenuItem_Dolgn(object sender, RoutedEventArgs e)
        {
            WpfApp2.Должности f3 = new WpfApp2.Должности();
            f3.ShowDialog();
        }
        private void MenuItem_Discip(object sender, RoutedEventArgs e)
        {
            WpfApp2.Дисциплины f3 = new WpfApp2.Дисциплины();
            f3.ShowDialog();
        }

        private void MenuItem_Prog(object sender, RoutedEventArgs e)
        {
            WpfApp2.About f3 = new WpfApp2.About();
            f3.ShowDialog();
        }
    }
}
