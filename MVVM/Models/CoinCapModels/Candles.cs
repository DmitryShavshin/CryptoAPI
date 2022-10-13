using Newtonsoft.Json;
using System.Collections.Generic;

namespace CryptoAPI.MVVM.Models.CoinCapModels
{
    public class Candles
    {
        [JsonProperty("open")]
        public double Open { get; set; }

        [JsonProperty("high")]
        public double High { get; set; }

        [JsonProperty("low")]
        public double Low { get; set; }

        [JsonProperty("close")]
        public double Close { get; set; }

        [JsonProperty("volume")]
        public double Volume { get; set; }

        [JsonProperty("period")]
        public long Period { get; set; }
    }
        
    public class CandlesList
    {
        [JsonProperty("data")]
        public List<Candles> DataList { get; set; }
    }
}
