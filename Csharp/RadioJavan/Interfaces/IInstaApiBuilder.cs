using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RadioJavan.Interfaces
{
    public interface IRadioJavanApiBuilder
    {
        /// <summary>
        ///     Create new API instance
        /// </summary>
        /// <returns>API instance</returns>
        IRadioJavanApi Build();


        /// <summary>
        ///     Set specific HttpClient
        /// </summary>
        /// <param name="httpClient">HttpClient</param>
        /// <returns>API Builder</returns>
        IRadioJavanApiBuilder UseHttpClient(HttpClient httpClient);

        /// <summary>
        ///     Set custom HttpClientHandler to be able to use certain features, e.g Proxy and so on
        /// </summary>
        /// <param name="handler">HttpClientHandler</param>
        /// <returns>API Builder</returns>
        IRadioJavanApiBuilder UseHttpClientHandler(HttpClientHandler handler);

        /// <summary>
        ///     Set Http request processor
        /// </summary>
        /// <param name="httpRequestProcessor">HttpRequestProcessor</param>
        /// <returns></returns>
        IRadioJavanApiBuilder SetHttpRequestProcessor(IHttpRequestProcessor httpRequestProcessor);

    }
}
