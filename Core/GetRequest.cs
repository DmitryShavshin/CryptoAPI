using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;

namespace CryptoAPI.Core
{
    public class GetRequest
    {
        HttpWebRequest _request;
      
        private string _url = "https://cryptingup.com/api/exchanges";
        private string trending = "https://api.coingecko.com/api/v3/search/trending";

        public string Response { get; set; }

        public async void Run()
        {
            _request = (HttpWebRequest)WebRequest.Create(_url);
            _request.Method = "GET";

            try
            {
                HttpWebResponse response = (HttpWebResponse)_request.GetResponse();
                var strem = response.GetResponseStream();
                if (strem != null)
                    Response = new StreamReader(strem).ReadToEnd();
            }
            catch (Exception)
            {

            }
        }
    }
}
