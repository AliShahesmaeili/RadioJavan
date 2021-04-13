using RadioJavan.Classes;
using RadioJavan.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RadioJavan.API.Builder
{
    public class RadioJavanApiBuilder : IRadioJavanApiBuilder
    {
        private HttpClient _httpClient;
        private HttpClientHandler _httpHandler = new HttpClientHandler();
        private IHttpRequestProcessor _httpRequestProcessor;

        private RadioJavanApiBuilder()
        {
        }

        /// <summary>
        ///     Create new API instance
        /// </summary>
        /// <returns>
        ///     API instance
        /// </returns>
        /// <exception cref="ArgumentNullException">User auth data must be specified</exception>
        public IRadioJavanApi Build()
        {
            if (_httpHandler == null) _httpHandler = new HttpClientHandler();

            if (_httpClient == null)
                _httpClient = new HttpClient(_httpHandler) { BaseAddress = new Uri(RadioJavanApiConstants.RADIOJAVAN_URL) };



            if (_httpRequestProcessor == null)
                _httpRequestProcessor =
                    new HttpRequestProcessor(_httpClient, _httpHandler);



            var radioJavanApi = new RadioJavanApi(_httpRequestProcessor);

            return radioJavanApi;
        }

        /// <summary>
        ///     Set specific HttpClient
        /// </summary>
        /// <param name="httpClient">HttpClient</param>
        /// <returns>
        ///     API Builder
        /// </returns>
        public IRadioJavanApiBuilder UseHttpClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
            return this;
        }

        /// <summary>
        ///     Set custom HttpClientHandler to be able to use certain features, e.g Proxy and so on
        /// </summary>
        /// <param name="handler">HttpClientHandler</param>
        /// <returns>
        ///     API Builder
        /// </returns>
        public IRadioJavanApiBuilder UseHttpClientHandler(HttpClientHandler handler)
        {
            _httpHandler = handler;
            return this;
        }

        /// <summary>
        ///     Set Http request processor
        /// </summary>
        /// <param name="httpRequestProcessor">HttpRequestProcessor</param>
        /// <returns>
        ///     API Builder
        /// </returns>
        public IRadioJavanApiBuilder SetHttpRequestProcessor(IHttpRequestProcessor httpRequestProcessor)
        {
            _httpRequestProcessor = httpRequestProcessor;
            return this;
        }

        /// <summary>
        ///     Creates the builder.
        /// </summary>
        /// <returns>
        ///     API Builder
        /// </returns>
        public static IRadioJavanApiBuilder CreateBuilder()
        {
            return new RadioJavanApiBuilder();
        }
    }
}
