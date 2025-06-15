using PCSPractice.Models;
using Microsoft.EntityFrameworkCore;
namespace PCSPractice.Data
{
    public class PcsDbContext : DbContext
    {
        public PcsDbContext(DbContextOptions<PcsDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

    }
}
