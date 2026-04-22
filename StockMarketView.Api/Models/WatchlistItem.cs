namespace StockMarketView.Api.Models;

public class WatchlistItem
{
    public int Id { get; set; }
    
    // In a real app we'd link to a UserId
    public string UserId { get; set; } = "default_user"; 
    
    public int AssetId { get; set; }
    public Asset? Asset { get; set; }
    
    public DateTime AddedAt { get; set; } = DateTime.UtcNow;
}
