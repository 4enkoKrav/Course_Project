using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WarehouseManagementSystem.Helpers;
using WarehouseManagementSystem.Models;
using WarehouseManagementSystem.Views;

namespace WarehouseManagementSystem.ViewModels

{

     public class LoginViewModel : BaseViewModel
     {
         public LoginWindow CurrentWindows { get; set; }
         public ICommand LoginCommand { get; set; }

         public User CurrentUser { get; set; }

         public LoginViewModel(LoginWindow windows)
         {
             CurrentWindows = windows;
             this.CurrentUser = new User();

             this.LoginCommand = new RelayCommand(param => this.Login(), param => true);
         }

         private void Login()
         {
             WarehouseDbContext ctx = new WarehouseDbContext();

             var user = ctx.Users.SingleOrDefault(u => u.Email == CurrentUser.Email);

             if (user != null && CurrentUser.Email!="admin@gmail.com" && CurrentUser.Password == user.Password)
             {
                 user.LastLoginDate = DateTime.Now;

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

                HomeWindow myWindow = new HomeWindow();
                 myWindow.Show();

                 this.CurrentWindows.Close();

                 //keep current user id in the application
                 App.Current.Properties["CurrentUserID"] = user.ID;
             }
              else  if (user != null && CurrentUser.Email == "admin@gmail.com" && CurrentUser.Password == "admin")
              {  
                    user.LastLoginDate = DateTime.Now;

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

                    UsersWindow myWindow = new UsersWindow();
                    myWindow.Show();

                    this.CurrentWindows.Close();

                    //keep current user id in the application
                    App.Current.Properties["CurrentUserID"] = user.ID;
                }
             else
             {
                 MessageBox.Show(CurrentWindows, "Invalid email or password !");
                 return;
             }
         }
     }
     

}
