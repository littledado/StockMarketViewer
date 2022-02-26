# Stock Market Viewer
C# Client for consume [Alpha Vantage API](https://www.alphavantage.co/) 

## Generate Free API Key
Go to https://www.alphavantage.co/support/#api-key and claim you free API token.

After generation cut and paste token inside configuration of the project.

## How to use
>var stockClient = new StockMartketViewer.Core.Services.AlphaVantageStockClient(<YOUR_TOKEN>);
>
>var quote = await stockClient.GetQuote("MSFT");
>
>Console.WriteLine($"Symbol: {quote.Symbol}, " + 
>                $"Price: {quote.Price}, " +
>                $"Last trading day: {quote.LatestTradingDay}");

## Output
>Symbol: MSFT, Price: 297,31, Last trading day: 25/02/2022
