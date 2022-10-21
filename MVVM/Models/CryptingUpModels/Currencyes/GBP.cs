using Newtonsoft.Json;


namespace CryptoAPI.MVVM.Models.CryptingUpModels.Currencyes
{
    public class GBP
    {
        [JsonProperty("price")]
        public double? Price { get; set; }
        [JsonProperty("volume_24h")]
        public double? Volume24h { get; set; }
        [JsonProperty("market_cap")]
        public double? MarketCap { get; set; }
        [JsonProperty("fully_diluted_market_cap")]
        public double? FullyDilutedMarketCap { get; set; }
    }
}
