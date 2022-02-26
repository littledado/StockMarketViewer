

using System.Text.Json.Serialization;

namespace StockMarketViewer.Common.Models
{
    public class GlobalQuote
    {
        [JsonPropertyName("Global Quote")]
        public Quote? Root { get; set; }
    }
}