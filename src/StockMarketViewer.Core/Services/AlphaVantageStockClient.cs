using System.Text.Json;
using System.Text.Json.Serialization;
using StockMarketViewer.Common.Models;
using StockMarketViewer.Common.Services;

namespace StockMartketViewer.Core.Services
{
    public class AlphaVantageStockClient : HttpClientConsumer, IStockClient
    {
        private const string QUERY_URL = "https://www.alphavantage.co/query?";
        private readonly string _apiKey;

        #region Constructors
        public AlphaVantageStockClient(string apiKey) : base(QUERY_URL)
        {
            _apiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
        }
        #endregion

        public async Task<Quote> GetQuote(string symbol)
        {
            var serializedResponse = await GetRequest($"function=GLOBAL_QUOTE&symbol={symbol}&apikey={_apiKey}");
            var jsonOptions = new JsonSerializerOptions(JsonSerializerDefaults.Web);
            jsonOptions.Converters.Add(new JsonDateOnlyConverter());

            return JsonSerializer.Deserialize<GlobalQuote>(serializedResponse, jsonOptions).Root;
        }
    }
}