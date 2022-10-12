using Newtonsoft.Json;


namespace CryptoAPI.MVVM.Models.CryptingUpModels.Currencyes
{
    public class USD
    {
        [JsonProperty("price")]
        public double? Price { get; set; }
        [JsonProperty("volume_24h")]
        public double? Volume24h { get; set; }
    }
}
