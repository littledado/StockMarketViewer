namespace StockMarketViewer.Common.Services
{
    public interface IHttpClientConsumer
    {
        Task<string> GetRequest(string url);
    }
}