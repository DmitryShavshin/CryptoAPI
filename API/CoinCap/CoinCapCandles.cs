using CryptoAPI.Core;
using CryptoAPI.MVVM.Models.Enum;

namespace CryptoAPI.API.CoinCap
{
    public class CoinCapCandles
    {
        private static string _exchange = "poloniex";
        private static string _baseId = "ethereum";
        private static string _quoteId = "bitcoin";
        private static string _interval = Interval.w1.ToString();
        private string marketUrl = $"http://api.coincap.io/v2/candles?exchange={_exchange}&interval={_interval}&baseId={_baseId}&quoteId={_quoteId}";
        private Execute execute = new Execute();
        private string Response { get; set; }

        public CoinCapCandles(string exchange, string baseId, string quoteId)
        {
            _exchange = exchange;
            _baseId = baseId;
            _quoteId = quoteId;
        }

        public CoinCapCandles() 
        {
        }
      
        // GET/Candles
        public string GetCandles()
        {
            return Response = execute.ExequteRequest(marketUrl, RequestTypes.GET.ToString());
        }
    }
}
