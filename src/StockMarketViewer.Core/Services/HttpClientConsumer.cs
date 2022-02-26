using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace StockMartketViewer.Core.Services
{
    public class HttpClientConsumer
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;
        public HttpClientConsumer(string baseUrl)
        {
            if (string.IsNullOrEmpty(baseUrl)) throw new ArgumentNullException(nameof(baseUrl));

            _baseUrl = baseUrl;
            _httpClient = new HttpClient();
        }

        public async Task<string> GetRequest(string url)
        {
            HttpResponseMessage response = _httpClient.
                                           GetAsync($"{_baseUrl}{url}").
                                           Result;

            if (!response.IsSuccessStatusCode)
                throw new ArgumentException($"Path {_baseUrl}{url} given error message: {response.StatusCode}");

            return await response.Content.ReadAsStringAsync();
        }
    }
}