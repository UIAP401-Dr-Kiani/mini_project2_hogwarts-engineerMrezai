﻿using System;
using System.IO;
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

namespace hogward
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Dumbledore_OnClick(object sender, RoutedEventArgs e)
        {
            DumbledoreMassageSender dumbledore = new DumbledoreMassageSender();
            dumbledore.Show();
        }
        
        private void Teachers_OnClick(object sender, RoutedEventArgs e)
        {
            
        }

        private void Students_OnClick(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
