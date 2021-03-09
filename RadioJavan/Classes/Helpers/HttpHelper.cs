using RadioJavan.API;
using RadioJavan.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RadioJavan.Classes.Helpers
{
    internal class HttpHelper
    {
        readonly Random Rnd = new Random();
        public IHttpRequestProcessor _httpRequestProcessor;
        public IRadioJavanApi _radioJavanApi;
        internal HttpHelper(IHttpRequestProcessor httpRequestProcessor, IRadioJavanApi radioJavanApi)
        {
            _httpRequestProcessor = httpRequestProcessor;
            _radioJavanApi = radioJavanApi;
        }

        public HttpRequestMessage GetDefaultRequest(HttpMethod method, Uri uri)
        {
            var request = new HttpRequestMessage(method, uri);
            var cookies = _httpRequestProcessor.HttpHandler.CookieContainer.GetCookies(_httpRequestProcessor.Client
                                  .BaseAddress);
         

            request.Headers.Add(RadioJavanApiConstants.HEADER_USER_AGENT, RadioJavanApiConstants.USER_AGENT);
            request.Headers.Add(RadioJavanApiConstants.HEADER_ACCEPT_LANGUAGE, RadioJavanApiConstants.ACCEPT_LANGUAGE);

            request.Headers.Add(RadioJavanApiConstants.HOST, RadioJavanApiConstants.HOST_URI);

            return request;
        }
        public HttpRequestMessage GetDefaultRequest(HttpMethod method, Uri uri, Dictionary<string, string> data)
        {
            var request = GetDefaultRequest(HttpMethod.Post, uri);
            request.Content = new FormUrlEncodedContent(data);
            return request;
        }

        //public HttpRequestMessage GetSignedRequest(HttpMethod method,
        //    Uri uri,
        //    Dictionary<string, string> data)
        //{
        //    var hash = CryptoHelper.CalculateHash(_apiVersion.SignatureKey,
        //        JsonConvert.SerializeObject(data));
        //    var payload = JsonConvert.SerializeObject(data);
        //    var signature = $"{hash}.{payload}";

        //    var fields = new Dictionary<string, string>
        //    {
        //        {InstaApiConstants.HEADER_IG_SIGNATURE, signature},
        //        {InstaApiConstants.HEADER_IG_SIGNATURE_KEY_VERSION, InstaApiConstants.IG_SIGNATURE_KEY_VERSION}
        //    };
        //    var request = GetDefaultRequest(HttpMethod.Post, uri);
        //    request.Content = new FormUrlEncodedContent(fields);
        //    return request;
        //}


        //public HttpRequestMessage GetSignedRequest(HttpMethod method,
        //    Uri uri,
        //    AndroidDevice deviceInfo,
        //    Dictionary<string, int> data)
        //{
        //    var hash = CryptoHelper.CalculateHash(_apiVersion.SignatureKey,
        //        JsonConvert.SerializeObject(data));
        //    var payload = JsonConvert.SerializeObject(data);
        //    var signature = $"{hash}.{payload}";

        //    var fields = new Dictionary<string, string>
        //    {
        //        {InstaApiConstants.HEADER_IG_SIGNATURE, signature},
        //        {InstaApiConstants.HEADER_IG_SIGNATURE_KEY_VERSION, InstaApiConstants.IG_SIGNATURE_KEY_VERSION}
        //    };
        //    var request = GetDefaultRequest(HttpMethod.Post, uri, deviceInfo);
        //    request.Content = new FormUrlEncodedContent(fields);
        //    request.Properties.Add(InstaApiConstants.HEADER_IG_SIGNATURE, signature);
        //    request.Properties.Add(InstaApiConstants.HEADER_IG_SIGNATURE_KEY_VERSION,
        //        InstaApiConstants.IG_SIGNATURE_KEY_VERSION);
        //    return request;
        //}



        //public HttpRequestMessage GetSignedRequest(HttpMethod method,
        //    Uri uri,
        //    AndroidDevice deviceInfo,
        //    Dictionary<string, object> data)
        //{
        //    var hash = CryptoHelper.CalculateHash(_apiVersion.SignatureKey,
        //        JsonConvert.SerializeObject(data));
        //    var payload = JsonConvert.SerializeObject(data);
        //    var signature = $"{hash}.{payload}";

        //    var fields = new Dictionary<string, string>
        //    {
        //        {InstaApiConstants.HEADER_IG_SIGNATURE, signature},
        //        {InstaApiConstants.HEADER_IG_SIGNATURE_KEY_VERSION, InstaApiConstants.IG_SIGNATURE_KEY_VERSION}
        //    };
        //    var request = GetDefaultRequest(HttpMethod.Post, uri, deviceInfo);
        //    request.Content = new FormUrlEncodedContent(fields);
        //    request.Properties.Add(InstaApiConstants.HEADER_IG_SIGNATURE, signature);
        //    request.Properties.Add(InstaApiConstants.HEADER_IG_SIGNATURE_KEY_VERSION,
        //        InstaApiConstants.IG_SIGNATURE_KEY_VERSION);
        //    return request;
        //}

        //public HttpRequestMessage GetSignedRequest(HttpMethod method,
        //    Uri uri,
        //    AndroidDevice deviceInfo,
        //    JObject data)
        //{
        //    var hash = CryptoHelper.CalculateHash(_apiVersion.SignatureKey,
        //        data.ToString(Formatting.None));
        //    var payload = data.ToString(Formatting.None);
        //    var signature = $"{hash}.{payload}";
        //    var fields = new Dictionary<string, string>
        //    {
        //        {InstaApiConstants.HEADER_IG_SIGNATURE, signature},
        //        {InstaApiConstants.HEADER_IG_SIGNATURE_KEY_VERSION, InstaApiConstants.IG_SIGNATURE_KEY_VERSION}
        //    };
        //    var request = GetDefaultRequest(HttpMethod.Post, uri, deviceInfo);
        //    request.Content = new FormUrlEncodedContent(fields);
        //    request.Properties.Add(InstaApiConstants.HEADER_IG_SIGNATURE, signature);
        //    request.Properties.Add(InstaApiConstants.HEADER_IG_SIGNATURE_KEY_VERSION,
        //        InstaApiConstants.IG_SIGNATURE_KEY_VERSION);
        //    return request;
        //}

        //public string GetSignature(JObject data)
        //{
        //    var hash = CryptoHelper.CalculateHash(_apiVersion.SignatureKey, data.ToString(Formatting.None));
        //    var payload = data.ToString(Formatting.None);
        //    var signature = $"{hash}.{payload}";
        //    return signature;
        //}
    }
}
