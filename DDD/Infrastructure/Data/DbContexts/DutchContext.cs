using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.DbContexts
{
    public class DutchContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}