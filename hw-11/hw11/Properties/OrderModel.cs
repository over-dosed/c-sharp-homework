using System;
using System.Data.Entity;
using System.Linq;
using hw6_framework;
using MySql.Data.EntityFramework;


namespace hw8.Properties
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class OrderModel : DbContext
    {
        public OrderModel():base("name=OrderContext")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<OrderModel>());
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
    }
}