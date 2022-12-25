using Microsoft.EntityFrameworkCore;

namespace lab6.Data
{
    public class OrderContext : DbContext
    {
        public DbSet<Users> User { get; set; } = null!;
        public DbSet<Service> Service { get; set; } = null!;

        public DbSet<Orders> Order { get; set; } = null!;
    }
}
