namespace StockMarketView.Api.Models;

public class Asset
{
    public int Id { get; set; }
    public string Symbol { get; set; } = string.Empty; // e.g. AAPL, BTC
    public string Name { get; set; } = string.Empty;   // e.g. Apple Inc.
    public string Type { get; set; } = string.Empty;   // e.g. Stock, Crypto

    // Navigation property
    public ICollection<Candle> Candles { get; set; } = new List<Candle>();
}
