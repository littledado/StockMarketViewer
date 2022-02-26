var stockClient = new StockMartketViewer.Core.Services.AlphaVantageStockClient("demo");
var quote = await stockClient.GetQuote("MSFT");
Console.WriteLine($"Price: {quote.Price}");
