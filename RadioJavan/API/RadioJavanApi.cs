using RadioJavan.Classes;
using RadioJavan.Classes.Helpers;
using RadioJavan.Classes.Models;
using RadioJavan.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RadioJavan.API
{
    internal class RadioJavanApi : IRadioJavanApi
    {
        private readonly IHttpRequestProcessor _httpRequestProcessor;
        private HttpHelper _httpHelper { get; set; }
        /// <summary>
        ///     Current HttpClient
        /// </summary>
        public HttpClient HttpClient { get => _httpRequestProcessor.Client; }
        /// <summary>
        ///     Current <see cref="IHttpRequestProcessor"/>
        /// </summary>
        public IHttpRequestProcessor HttpRequestProcessor => _httpRequestProcessor;

        #region Constructor
        public RadioJavanApi(IHttpRequestProcessor httpRequestProcessor)
        {
            _httpRequestProcessor = httpRequestProcessor;
            _httpHelper = new HttpHelper(httpRequestProcessor, this);
        }

        #endregion Constructor

        public async Task<IResult<RadioJavanLogin>> LoginAsync(string email, string password)
        {
            try
            {
                var data = new Dictionary<string, string>
                {
                    {"login_email", email},
                    {"login_password", password},
                };
                var uri = UriCreator.GetLoginUri();
                var request = _httpHelper.GetDefaultRequest(uri, data);
                var response = await _httpRequestProcessor.SendAsync(request);
                var json = await response.Content.ReadAsStreamAsync();
                return Result.Success(await JsonSerializer.DeserializeAsync<RadioJavanLogin>(json));
            }
            catch (Exception exception)
            {
                return Result.Fail<RadioJavanLogin>(exception);
            }
        }

        public async Task<IResult<RadioJavanForgotPassword>> ForgotPasswordAsync(string email)
        {
            try
            {
                var data = new Dictionary<string, string>
                {
                    {"email", email}
                };
                var uri = UriCreator.GetForgotPasswordUri();
                var request = _httpHelper.GetDefaultRequest(uri, data);
                var response = await _httpRequestProcessor.SendAsync(request);
                var json = await response.Content.ReadAsStreamAsync();
                return Result.Success(await JsonSerializer.DeserializeAsync<RadioJavanForgotPassword>(json));
            }
            catch (Exception exception)
            {
                return Result.Fail<RadioJavanForgotPassword>(exception);
            }
        }
    }
}
