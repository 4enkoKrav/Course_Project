using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Data.SqlClient;

using System.IO;
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
    class CustomersViewModel : BaseViewModel
    {
        
       
        public CustomersWindow CurrentWindows { get; set; }
        public ICommand CancelCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ICommand SaveCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand SearchCommand { get; set; }


        private List<Customer> _customerList;
        public List<Customer> CustomerList
        {
            get { return _customerList; }
            set
            {
                _customerList = value;
                OnPropertyChanged("CustomerList");
            }
        }

        private Customer _selectedCustomer;
        public Customer SelectedCustomer
        {
            get { return _selectedCustomer; }
            set
            {
                _selectedCustomer = value;
                IsNew = false;
                OnPropertyChanged("SelectedCustomer");
            }
        }

        public bool IsNew { get; set; }
        public string SearchTerm { get; set; }

        //Constructor
        public CustomersViewModel(CustomersWindow window)
        {
            this.CurrentWindows = window;
            this.Add();

            this.CancelCommand = new RelayCommand(param => this.Cancel(), param => true);
            this.AddCommand = new RelayCommand(param => this.Add(), param => true);
            this.SaveCommand = new RelayCommand(param => this.Save(), param => true);
            this.DeleteCommand = new RelayCommand(param => this.Delete(), param => true);
            this.SearchCommand = new RelayCommand(param => this.Search(), param => true);
          
            
            //Load data from database
            WarehouseDbContext ctx = new WarehouseDbContext();
            CustomerList = new List<Customer>(ctx.Customers.ToList());
              
        }

        
         private void Search()
        {
            
            WarehouseDbContext ctx = new WarehouseDbContext();
            CustomerList = new List<Customer>(ctx.Customers.ToList().Where(u => u.Name.Contains(SearchTerm)));
            
            }
        
        private void Delete()
        {
            
            if (SelectedCustomer == null || SelectedCustomer.ID == 0)
            {
                MessageBox.Show(CurrentWindows, "Please select a user before deleting.");
                return;
            }

            MessageBoxResult result = MessageBox.Show(CurrentWindows, "Are you sure you want to delete:\n" +
               SelectedCustomer.Name, "Confirm delete", MessageBoxButton.OKCancel, MessageBoxImage.Warning);

            if (result == MessageBoxResult.OK)
            {
                try
                {
                    WarehouseDbContext ctx = new WarehouseDbContext();
                    var customer = ctx.Customers.Single(u => u.ID == SelectedCustomer.ID);
                    ctx.Customers.Remove(customer);
                    ctx.SaveChanges();

                    CustomerList = new List<Customer>(ctx.Customers.ToList());
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(CurrentWindows, ex.Message, "Database error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            
        }

        private void Add()
        {
            SelectedCustomer = new Customer();
            IsNew = true;
        }

        private void Cancel()
        {
            this.CurrentWindows.Close();
        }





        private void Save()
        {
            
            if (!IsNew)
            {
                if (SelectedCustomer == null)
                {
                    MessageBox.Show(CurrentWindows, "Please select a user before editting.");
                    return;
                }

                WarehouseDbContext ctx = new WarehouseDbContext();
                var customer = ctx.Customers.Single(u => u.ID == SelectedCustomer.ID);

                customer.Name = SelectedCustomer.Name;
                customer.CompanyName = SelectedCustomer.CompanyName;
                customer.Address = SelectedCustomer.Address;
                customer.City = SelectedCustomer.City;
                customer.Telephone = SelectedCustomer.Telephone;
                customer.Email = SelectedCustomer.Email;

                ctx.SaveChanges();

                MessageBox.Show(CurrentWindows, "Updated successfully !");
            }
            else
            {
                WarehouseDbContext ctx = new WarehouseDbContext();

                ctx.Customers.Add(SelectedCustomer);

               
                try
                {
                    ctx.SaveChanges();
                }
                catch(DbEntityValidationException ex)
                {
                    foreach(var entityValidationErrors in ex.EntityValidationErrors)
                    {
                        foreach(var validationError in entityValidationErrors.ValidationErrors)
                        {
                            string property = ("Property:" + validationError.PropertyName + "Error:" + validationError.ErrorMessage);
                        }
                    }
                }
            
                CustomerList = new List<Customer>(ctx.Customers.ToList());

                IsNew = false;
                
            }
                
            
        }
       
 
    
             
    }

}
