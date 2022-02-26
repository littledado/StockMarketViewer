using System.Text.Json.Serialization;

namespace StockMarketViewer.Common.Models
{
    public class Quote
    {
        [JsonPropertyName("01. symbol")]
        public string? Symbol { get; set; }
        [JsonPropertyName("02. open")]
        [JsonNumberHandlingAttribute(JsonNumberHandling.AllowReadingFromString)]
        public float? Open { get; set; }
        [JsonPropertyName("03. high")]
        [JsonNumberHandlingAttribute(JsonNumberHandling.AllowReadingFromString)]
        public float? High { get; set; }
        [JsonPropertyName("04. low")]
        [JsonNumberHandlingAttribute(JsonNumberHandling.AllowReadingFromString)]
        public float? Low { get; set; }
        [JsonPropertyName("05. price")]
        [JsonNumberHandlingAttribute(JsonNumberHandling.AllowReadingFromString)]
        public float? Price { get; set; }
        [JsonPropertyName("06. volume")]
        [JsonNumberHandlingAttribute(JsonNumberHandling.AllowReadingFromString)]
        public float? Volume { get; set; }
        [JsonPropertyName("07. latest trading day")]
        public DateOnly? LatestTradingDay { get; set; }
        [JsonPropertyName("08. previous close")]
        [JsonNumberHandlingAttribute(JsonNumberHandling.AllowReadingFromString)]
        public float? PreviousClose { get; set; }
        [JsonPropertyName("09. change")]
        [JsonNumberHandlingAttribute(JsonNumberHandling.AllowReadingFromString)]
        public float? Change { get; set; }
        [JsonPropertyName("10. change percent")]
        public string? ChangePercent { get; set; }
    }
}