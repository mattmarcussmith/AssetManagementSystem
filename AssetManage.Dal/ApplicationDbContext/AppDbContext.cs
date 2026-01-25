using AssetManage.Dal.Entities;
using Microsoft.EntityFrameworkCore;

namespace AssetManage.Dal.ApplicationDbContext
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Asset> Assets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Asset>()
                .HasIndex(a => a.AssetTag)
                .IsUnique();
        }
    }
}
