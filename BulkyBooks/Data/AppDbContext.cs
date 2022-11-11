using BulkyBooks.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBooks.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
    }
}
