using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RadioJavan.Interfaces
{
    public interface IHttpRequestProcessor
    {
        HttpClientHandler HttpHandler { get; set; }
        HttpClient Client { get; }
        void SetHttpClientHandler(HttpClientHandler handler);
        Task<HttpResponseMessage> SendAsync(HttpRequestMessage requestMessage);
        Task<HttpResponseMessage> GetAsync(Uri requestUri);
        Task<HttpResponseMessage> SendAsync(HttpRequestMessage requestMessage, HttpCompletionOption completionOption);
        Task<string> SendAndGetJsonAsync(HttpRequestMessage requestMessage, HttpCompletionOption completionOption);
        Task<string> GeJsonAsync(Uri requestUri);
    }
}
