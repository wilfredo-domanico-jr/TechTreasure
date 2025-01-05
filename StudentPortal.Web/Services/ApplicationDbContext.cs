using Microsoft.EntityFrameworkCore;
using StudentPortal.Web.Models;
namespace StudentPortal.Web.Services
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
