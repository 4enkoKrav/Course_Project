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
using System.Windows.Shapes;
using WarehouseManagementSystem.ViewModels;

namespace WarehouseManagementSystem.Views
{
    /// <summary>
    /// Логика взаимодействия для HomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {
        public HomeWindow()
        {
            InitializeComponent();

            //Binding view with ViewModel
            DataContext = new HomeViewModel();
        }
    }

    /// <summary>
    /// Логика взаимодействия для HomeWindow.xaml
    /// </summary>
    public partial class CopyOfHomeWindow : Window
    {
        public CopyOfHomeWindow()
        {
            InitializeComponent();

            //Binding view with ViewModel
            DataContext = new HomeViewModel();
        }
    }
}