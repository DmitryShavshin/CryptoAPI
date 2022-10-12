using CryptoAPI.Core;
using CryptoAPI.MVVM.Models.Enum;


namespace CryptoAPI.API.CryptingUp
{
    public class CryptingUpExchanges
    {
        private string exchanges = "https://cryptingup.com/api/exchanges";
        private Execute execute = new Execute();
        private string Response { get; set; }
        private string _url;

        // Get all exchanges
        // GET/exchanges
        public string GetExchanges()
        {
            return Response = execute.ExequteRequest(exchanges, RequestTypes.GET.ToString());
        }

        // Get a specific exchange
        // GET/exchanges{id}
        public string GetExchangesById(string id)
        {
            if (id != null)
            {
                _url = exchanges + "/" + id;
            }
            return Response = execute.ExequteRequest(_url, RequestTypes.GET.ToString());            
        }
    }
}