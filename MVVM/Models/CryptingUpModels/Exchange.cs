using Newtonsoft.Json;
using System.Collections.Generic;


namespace CryptoAPI.MVVM.Models.CryptingUpModels
{ 
    public class Exchange
    {
        [JsonProperty("quote")]
        public Quote Quote { get; set; }
        [JsonProperty("exchange_id")]
        public string ExchangeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("volume_24h")]
        public double Volume24h { get; set; }
    }

    public class ExchangesList
    {
        [JsonProperty("exchanges")]
        public List<Exchange> Exchanges { get; set; }
    }
}
