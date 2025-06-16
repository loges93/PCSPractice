using PCSPractice.Models;
using Microsoft.EntityFrameworkCore;
namespace PCSPractice.Data
{
    public class PcsDbContext : DbContext
    {
        public PcsDbContext(DbContextOptions<PcsDbContext> options) : base(options) { }


        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, 
                    Username = "Widget",
                    Name = "Toni",
                    Password = "jingleJangle" 
                },
                new User { Id = 2, 
                    Username = "Gadget", 
                    Name = "John",
                    Password = "dutchMuffin" 
                }
            );
        }

    }
}
