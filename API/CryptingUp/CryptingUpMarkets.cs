using CryptoAPI.Core;
using CryptoAPI.MVVM.Models.Enum;

namespace CryptoAPI.API.CryptingUp
{
    public class CryptingUpMarkets
    {
        private string markets = "https://cryptingup.com/api/markets";
        private string exchanges = "https://cryptingup.com/api/exchanges";
        private string assets = "https://cryptingup.com/api/assets";
        private Execute execute = new Execute();
        private string Response { get; set; }
        private string _url;

        // Get all markets
        // GET/markets
        public string GetMarkets()
        {
            return Response = execute.ExequteRequest(markets, RequestTypes.GET.ToString());
        }

        // Get exchange markets
        // GET/exchanges{id}/markets
        public string GetExchangeMarkets(string id)
        {
            if (id != null)
            {
                _url = exchanges + "/" + id + "/markets";
            }
            return Response = execute.ExequteRequest(_url, RequestTypes.GET.ToString());
        }

        // Get asset markets
        // GET/exchanges{id}
        public string GetAssetMarkets(string id)
        {
            if (id != null)
            {
                _url = assets + "/" + id + "/markets";
            }
            return Response = execute.ExequteRequest(_url, RequestTypes.GET.ToString());
        }
    }
}
