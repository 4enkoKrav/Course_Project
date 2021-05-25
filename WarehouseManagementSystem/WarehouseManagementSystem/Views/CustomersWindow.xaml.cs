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
using WarehouseManagementSystem.ViewModels;

namespace WarehouseManagementSystem.Views
{
    /// <summary>
    /// Логика взаимодействия для Customers.xaml
    /// </summary>
    public partial class CustomersWindow : Window
    {
        public CustomersWindow()
        {
            InitializeComponent();

            //Binding view with ViewModel
            DataContext = new CustomersViewModel(this);
        }
    }
}
