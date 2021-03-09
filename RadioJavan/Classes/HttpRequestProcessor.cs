using RadioJavan.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RadioJavan.Classes
{
    internal class HttpRequestProcessor : IHttpRequestProcessor
    {
        public HttpRequestProcessor(HttpClient httpClient, HttpClientHandler httpHandler)
        {
            Client = httpClient;
            HttpHandler = httpHandler;
        }

        public HttpClientHandler HttpHandler { get; set; }
        public HttpClient Client { get; set; }
        public void SetHttpClientHandler(HttpClientHandler handler)
        {
            HttpHandler = handler;
            Client = new HttpClient(handler);
        }

        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage requestMessage)
        {
            Client.DefaultRequestHeaders.ConnectionClose = false;
            requestMessage.Headers.Add("Connection", "Keep-Alive");
            var response = await Client.SendAsync(requestMessage);
            return response;
        }

        public async Task<HttpResponseMessage> GetAsync(Uri requestUri)
        {
            Client.DefaultRequestHeaders.ConnectionClose = false;
            var response = await Client.GetAsync(requestUri);
            return response;
        }

        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage requestMessage,
            HttpCompletionOption completionOption)
        {
            Client.DefaultRequestHeaders.ConnectionClose = false;
            requestMessage.Headers.Add("Connection", "Keep-Alive");
            var response = await Client.SendAsync(requestMessage, completionOption);
            return response;
        }

        public async Task<string> SendAndGetJsonAsync(HttpRequestMessage requestMessage,
            HttpCompletionOption completionOption)
        {
            Client.DefaultRequestHeaders.ConnectionClose = false;
            var response = await Client.SendAsync(requestMessage, completionOption);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GeJsonAsync(Uri requestUri)
        {
            Client.DefaultRequestHeaders.ConnectionClose = false;
            var response = await Client.GetAsync(requestUri);
            return await response.Content.ReadAsStringAsync();
        }

    }
}
