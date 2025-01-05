using Microsoft.EntityFrameworkCore;
using TechTreasure.Models;

namespace TechTreasure.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
