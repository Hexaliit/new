
using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace Exir.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profile>().HasData(
                new Profile() { Id = 1, Title = "Diploma"},
                new Profile() { Id = 2, Title = "Bachlor"},
                new Profile() { Id = 3, Title = "Master"}
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
