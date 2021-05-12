using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementSystem.Models
{
    //DbContext: определяет контекст данных, используемый для взаимодействия с базой данных
    public class WarehouseDbContext : DbContext
    {
        public WarehouseDbContext() : base("name=WarehouseConnection")
        {

        }

        // представляет набор сущностей, хранящихся в базе данных
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderDetail> Details { get; set; }
        
    }
}
