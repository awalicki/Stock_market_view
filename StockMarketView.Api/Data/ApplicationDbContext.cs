using Microsoft.EntityFrameworkCore;
using StockMarketView.Api.Models;

namespace StockMarketView.Api.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Asset> Assets => Set<Asset>();
    public DbSet<Candle> Candles => Set<Candle>();
    public DbSet<WatchlistItem> WatchlistItems => Set<WatchlistItem>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Asset>()
            .HasIndex(a => a.Symbol)
            .IsUnique();

        modelBuilder.Entity<Candle>()
            .Property(c => c.Open).HasPrecision(18, 6);
        modelBuilder.Entity<Candle>()
            .Property(c => c.High).HasPrecision(18, 6);
        modelBuilder.Entity<Candle>()
            .Property(c => c.Low).HasPrecision(18, 6);
        modelBuilder.Entity<Candle>()
            .Property(c => c.Close).HasPrecision(18, 6);
    }
}
