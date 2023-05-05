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

namespace Store
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public static MainWindow GetWindow { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            GetWindow = this;
            Manager.frameManager = mainFrame;
            //mainFrame.Content = PageLogIn.LogIn.GetPage();
            mainFrame.Navigate(PageLogIn.LogIn.GetPage());
        }
    }
}
