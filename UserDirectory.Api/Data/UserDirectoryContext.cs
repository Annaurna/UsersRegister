
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;


using UserDirectory.Api.Models; // Adjust namespace as needed

namespace UserDirectory.Api.Data
{




    public class UserDirectoryContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public UserDirectoryContext(
            DbContextOptions<UserDirectoryContext> options)
            : base(options)
        {
        }

        // Add your DbSets here
        public Microsoft.EntityFrameworkCore.DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configure your entity relationships and constraints here if needed

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "John Doe", Age = 30, City = "New York", State = "NY", Pincode = "10001" },
                new User { Id = 2, Name = "Jane Smith", Age = 25, City = "Los Angeles", State = "CA", Pincode = "90001" }
            );
        }

        // Add other entity sets as needed
    }
}
