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
using WpfAppPr8_9.Windows;

namespace WpfAppPr8_9
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

        private void buttonShowWeather_Click(object sender, RoutedEventArgs e)
        {
            ShowWeatherWindow showWeather = new ShowWeatherWindow();
            showWeather.ShowDialog();
        }

        private void buttonAddWeather_Click(object sender, RoutedEventArgs e)
        {
            AddWeatherWindow addWeather = new AddWeatherWindow();
            addWeather.ShowDialog();
        }
    }
}
