namespace StockMarketView.Api.Models;

public class Candle
{
    public int Id { get; set; }
    public int AssetId { get; set; }
    
    public DateTime Timestamp { get; set; }
    
    public decimal Open { get; set; }
    public decimal High { get; set; }
    public decimal Low { get; set; }
    public decimal Close { get; set; }
    
    public long Volume { get; set; }

    // Navigation property
    public Asset? Asset { get; set; }
}
