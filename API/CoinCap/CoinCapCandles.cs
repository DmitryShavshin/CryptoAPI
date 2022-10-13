using CryptoAPI.Core;
using CryptoAPI.MVVM.Models.Enum;

namespace CryptoAPI.API.CoinCap
{
    public class CoinCapCandles
    {

        private static string exchange = "poloniex";
        private static string baseId = "ethereum";
        private static string quoteId = "bitcoin";
        private static string interval = Interval.w1.ToString();

        private string marketUrl = $"http://api.coincap.io/v2/candles?exchange={exchange}&interval={interval}&baseId={baseId}&quoteId={quoteId}";
        private Execute execute = new Execute();
        private string Response { get; set; }


        // GET/Candles
        public string GetCandles()
        {
            return Response = execute.ExequteRequest(marketUrl, RequestTypes.GET.ToString());
        }
    }
}
