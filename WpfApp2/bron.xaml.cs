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
    /// Логика взаимодействия для bron.xaml
    /// </summary>
    public partial class bron : Page
    {
        public bron()
        {
            InitializeComponent();
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new zakazfood());
        }

        private void TextBlock_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new zakazpc());
        }
    }
}
