using Microsoft.EntityFrameworkCore;

namespace PROJECT.Models
{
    public class ResturantContext: DbContext
    {

        public ResturantContext(DbContextOptions<ResturantContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Menu> Menus { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Payment> Payments { get; set; }

    }
}
