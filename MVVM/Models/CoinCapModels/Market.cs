using CryptoAPI.Core;
using LiveCharts;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CryptoAPI.MVVM.Models.CoinCapModels
{
    public class Market
    {
        [JsonProperty("exchangeId")]
        public string ExchangeId { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("baseSymbol")]
        public string BaseSymbol { get; set; }

        [JsonProperty("baseId")]
        public string BaseId { get; set; }

        [JsonProperty("quoteSymbol")]
        public string QuoteSymbol { get; set; }

        [JsonProperty("quoteId")]
        public string QuoteId { get; set; }

        [JsonProperty("priceQuote")]
        public string PriceQuote { get; set; }

        [JsonProperty("priceUsd")]
        public string PriceUsd { get; set; }

        [JsonProperty("volumeUsd24Hr")]
        public string VolumeUsd24Hr { get; set; }

        [JsonProperty("percentExchangeVolume")]
        public string PercentExchangeVolume { get; set; }

        [JsonProperty("tradesCount24Hr")]
        public string TradesCount24Hr { get; set; }

        [JsonProperty("updated")]
        public object Updated { get; set; }
        public ChartValues<int> Rnd { get; set; }


        public Market()
        {
            RandomChartInfo randomChartInfo = new RandomChartInfo();
            Rnd = new ChartValues<int>();
            var nums = randomChartInfo.Numbers();
            Rnd.AddRange(nums);
        }
    }

    public class MarketsList
    {
        [JsonProperty("data")]
        public List<Market> Markets { get; set; }
    }
}