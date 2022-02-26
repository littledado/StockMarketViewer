using StockMarketViewer.Common.Models;
using System.Threading.Tasks;

namespace StockMarketViewer.Common.Services
{
    public interface IStockClient
    {
        Task<Quote> GetQuote(string symbol);
    }
}
