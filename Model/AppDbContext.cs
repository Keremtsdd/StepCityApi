using Microsoft.EntityFrameworkCore;

namespace ShoeFeature
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ShoeFeature> Shoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShoeFeature>()
                .Property(s => s.Price)
                .HasColumnType("decimal(18,2)");
        }
    }
}

