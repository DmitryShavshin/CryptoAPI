using CryptoAPI.Core;
using CryptoAPI.MVVM.Models.Enum;

namespace CryptoAPI.API.CoinCap
{
    public class CoinCapMarkets
    {
        private string marketUrl = "http://api.coincap.io/v2/markets";
        private Execute execute = new Execute();
        private string Response { get; set; }

        // GET/markets
        public string GetMarkets()
        {
            return Response = execute.ExequteRequest(marketUrl, RequestTypes.GET.ToString());
        }
    }
}