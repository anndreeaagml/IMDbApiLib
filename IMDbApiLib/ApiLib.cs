﻿using System;
using System.Net;

namespace IMDbApiLib
{
    //k_9o16s5zl
    public partial class ApiLib
    {
        public string BaseUrl => "https://imdb-api.com";

        private readonly string _apiKey;
        public WebProxy WebProxy { get; }

        public ApiLib(string apiKey)
        {
            _apiKey = apiKey;
        }

        public ApiLib(string apiKey, string proxyAddress, string proxyUsername = null, string proxyPassword = null)
        {
            _apiKey = apiKey;
            if (!string.IsNullOrEmpty(proxyAddress))
            {
                var webProxy = new WebProxy();
                webProxy.Address = new Uri(proxyAddress);
                if (!string.IsNullOrEmpty(proxyUsername) && !string.IsNullOrEmpty(proxyPassword))
                {
                    webProxy.Credentials = new NetworkCredential(
                        proxyUsername,
                        proxyPassword);
                    webProxy.UseDefaultCredentials = false;
                }
                webProxy.BypassProxyOnLocal = false;

                WebProxy = webProxy;
            }
        }
    }
}
