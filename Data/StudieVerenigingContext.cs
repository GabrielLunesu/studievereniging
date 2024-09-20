using Microsoft.EntityFrameworkCore;
using studievereniging.Models;

namespace StudieVereniging.Data
{
    public class StudieVerenigingContext : DbContext
    {
        public StudieVerenigingContext(DbContextOptions<StudieVerenigingContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<Activity> Activities { get; set; }

       
    }
}