using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CryptoAPI.MVVM.Models
{
    public class TestCoin
    {
        [JsonProperty("coins")]
        public List<Coin> Coins { get; set; }

        [JsonProperty("exchanges")]
        public List<object> Exchanges { get; set; }
    }
    public class Coin
    {
        [JsonProperty("item")]
        public Item Item { get; set; }
        [JsonProperty("exchanges")]
        public List<object> Exchanges { get; set; }
    }

    public class Item
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("coin_id")]
        public int CoinId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("market_cap_rank")]
        public int MarketCapRank { get; set; }

        [JsonProperty("thumb")]
        public string Thumb { get; set; }

        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("price_btc")]
        public double PriceBtc { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }
    }
}
