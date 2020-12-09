using Microsoft.EntityFrameworkCore;
using Promenade.Models;

namespace Promenade.Data
{
    public class PromenadeContext : DbContext
    {
        public PromenadeContext (DbContextOptions<PromenadeContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Food> Food { get; set; }
        public DbSet<Details> Details { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Food>().ToTable("Food");
            modelBuilder.Entity<Details>().ToTable("Details");
        }
    }
}