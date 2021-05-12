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
using WarehouseManagementSystem.Models;

namespace WarehouseManagementSystem.Views
{
    /// <summary>
    /// Логика взаимодействия для AddProductsWindow.xaml
    /// </summary>
    public partial class AddProductsWindow : Window
    {
        private Order order;

        public AddProductsWindow()
        {
            InitializeComponent();
        }

        public AddProductsWindow(Order order)
        {
            this.order = order;
        }
    }
}
