using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApi.Models;

namespace TestApi.Data
{
    public class DatabaseContext : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server = DESKTOP-S8ALGUE\\SQLEXPRESS; database = PortalStoreDB; integrated security = true;");
        //    //Initial Catalog=PortalStoreDB;
        //}
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //    optionsBuilder.UseSqlServer("server = DESKTOP-S8ALGUE\\SQLEXPRESS; database = PortalStoreDB; integrated security = true;");
        // }
        public DatabaseContext(DbContextOptions<DatabaseContext> opt):base(opt)
        {

        }

        public DbSet<Address> Address { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<SKU> SKU { get; set; }


    }
}
