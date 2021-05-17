using Microsoft.EntityFrameworkCore;


namespace OrderApi.Models
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options)
            : base(options)
        {
        }

        public DbSet<Order> orders { get; set; }
        public DbSet<OrderDetails> orderDetails { set; get; }
    }
}
