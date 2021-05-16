using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
using WarehouseManagementSystem.ViewModels;

namespace WarehouseManagementSystem.Views
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        //WarehouseDbContext ctx;
        public LoginWindow()
        {
            InitializeComponent();

            //Binding view with ViewModel
            DataContext = new LoginViewModel(this);

            //ctx = new WarehouseDbContext();
        }


        /*
        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string email = textBoxEmail.Text.Trim().ToLower();
            string pass = passBox.Password.Trim();
            string pass_2 = passBox_2.Password.Trim();

            if (email.Length < 5 && !email.Contains("@") || !email.Contains("."))
            {
                textBoxEmail.ToolTip = "Incorrected email!";
                textBoxEmail.Background = Brushes.Red;
            }
            else if (pass.Length < 5)
            {
                passBox.ToolTip = "Incorrected password!";
                passBox.Background = Brushes.Red;
            }
            else if (pass != pass_2)
            {
                passBox_2.ToolTip = "Password mismatch!";
                passBox_2.Background = Brushes.Red;
            }
            else
            {
                textBoxEmail.ToolTip = "";
                textBoxEmail.Background = Brushes.Transparent;
                passBox.ToolTip = "";
                passBox.Background = Brushes.Transparent;
                passBox_2.ToolTip = "";
                passBox_2.Background = Brushes.Transparent;


                User user = new User(email, pass);
                ctx.Users.Add(user);

                try
                {
                    ctx.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var entityValidationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in entityValidationErrors.ValidationErrors)
                        {
                            string property = ("Property:" + validationError.PropertyName + "Error:" + validationError.ErrorMessage);
                        }
                    }
                }



            }

            MessageBox.Show("Всё хорошо");

        }

        */


    }

}
