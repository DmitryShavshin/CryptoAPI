using System;
using System.IO;
using System.Net;


namespace CryptoAPI.Core
{
    public class Execute
    {
        HttpWebRequest _request;
        private string Response { get; set; }

        public string ExequteRequest(string url, string methodType)
        {
            _request = (HttpWebRequest)WebRequest.Create(url);
            _request.Method = methodType;

            try
            {
                HttpWebResponse response = (HttpWebResponse)_request.GetResponse();
                var strem = response.GetResponseStream();
                if (strem != null)
                   Response = new StreamReader(strem).ReadToEnd();
                return Response;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
          
        }
    }
}
