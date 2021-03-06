using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using WarehouseManagementSystem.Helpers;
using WarehouseManagementSystem.Models;
using WarehouseManagementSystem.ViewModels;

namespace WarehouseManagementSystem.Views
{

    public class UsersViewModel : BaseViewModel
    {
        public UsersWindow CurrentWindows { get; set; }

        public ICommand CancelCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ICommand SaveCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand SearchCommand { get; set; }


        private List<User> _userList;
        public List<User> UserList
        {
            get { return _userList; }
            set
            {
                _userList = value;
                OnPropertyChanged("UserList");
            } 
        }
        

        private User _selectedUser;
        public User SelectedUser
        {
            get { return _selectedUser; }
            set
            {
                _selectedUser = value;
                OnPropertyChanged("SelectedUser");
            }
        }

        public bool IsNew { get; set; }
        public string SearchTerm { get; set; }

        //Constructor
        public UsersViewModel(UsersWindow window)
        {
            this.CurrentWindows = window;
            this.Add();

            this.CancelCommand = new RelayCommand(param => this.Cancel(), param => true);
            this.AddCommand = new RelayCommand(param => this.Add(), param => true);
            this.SaveCommand = new RelayCommand(param => this.Save(), param => true);
            this.DeleteCommand = new RelayCommand(param => this.Delete(), param => true);
            //this.SearchCommand = new RelayCommand(param => this.Search(), param => true);
           

            
            //Load data from database
            WarehouseDbContext ctx = new WarehouseDbContext();
            UserList = new List<User>(ctx.Users.ToList());
            
        }

     
        /*
        private void Search()
        {
            WarehouseDbContext ctx = new WarehouseDbContext();
            if (SearchTerm != null)
            {
                UserList = new List<User>(ctx.Users.ToList().Where(u => u.Name.Contains(SearchTerm)));
            }

   

        }
        */



        private void Delete()
        {
            if (SelectedUser == null || SelectedUser.ID == 0)
            {
                MessageBox.Show(CurrentWindows, "Please select a user before deleting.");
                return;
            }

            MessageBoxResult result = MessageBox.Show(CurrentWindows, "Are you sure you want to delete:\n" +
               SelectedUser.Name, "Confirm delete", MessageBoxButton.OKCancel, MessageBoxImage.Warning);

            if (result == MessageBoxResult.OK)
            {
                try
                {
                    WarehouseDbContext ctx = new WarehouseDbContext();
                    var user = ctx.Users.Single(u => u.ID == SelectedUser.ID);
                    ctx.Users.Remove(user);
                    ctx.SaveChanges();

                    //Reload data from databse
                    UserList = new List<User>(ctx.Users.ToList());
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(CurrentWindows, ex.Message, "Database error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }


        public void Add()
        {
            SelectedUser = new User();
            IsNew = true;
        }

        private void Cancel()
        {
            this.CurrentWindows.Close();
        }





        public void Save()
        {
            if (!IsNew)
            {
                //Edit existing user
                if (SelectedUser == null)
                {
                    MessageBox.Show(CurrentWindows, "Please select a user before editting.");
                    return;
                }

                WarehouseDbContext ctx = new WarehouseDbContext();
                var user = ctx.Users.Single(u => u.ID == SelectedUser.ID);

                user.Name = SelectedUser.Name;
                user.Address = SelectedUser.Address;
                user.City = SelectedUser.City;
                user.Tel = SelectedUser.Tel;
                user.Email = SelectedUser.Email;
                user.Password = SelectedUser.Password;
                user.LastLoginDate = SelectedUser.LastLoginDate;

                ctx.SaveChanges();

                MessageBox.Show(CurrentWindows, "Edited successfully !");
            }
            else
            {
                //Add new user
                WarehouseDbContext ctx = new WarehouseDbContext();

                ctx.Users.Add(SelectedUser);


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

                UserList = new List<User>(ctx.Users.ToList());

                IsNew = false;

                MessageBox.Show(CurrentWindows, "Updated successfully !");


                /*
                if (.Email != null && Password != null)
                {
                    MessageBox.Show(CurrentWindows, "Updated successfully !");
                }
                else
                {
                    MessageBox.Show(CurrentWindows, "Enter the Email and Password !");
                }
                */

            }

        }



    }

}