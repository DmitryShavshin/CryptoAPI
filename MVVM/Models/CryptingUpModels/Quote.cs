using CryptoAPI.MVVM.Models.CryptingUpModels.Currencyes;
using Newtonsoft.Json;


namespace CryptoAPI.MVVM.Models.CryptingUpModels
{
    public class Quote
    {
        [JsonProperty("GBP")]
        public GBP GBP { get; set; }
        [JsonProperty("EUR")]
        public EUR EUR { get; set; }
        [JsonProperty("USD")]
        public USD USD { get; set; }
        [JsonProperty("CAD")]
        public CAD CAD { get; set; }
        [JsonProperty("AUD")]
        public AUD AUD { get; set; }
        [JsonProperty("NZD")]
        public NZD NZD { get; set; }
        [JsonProperty("JPY")]
        public JPY JPY { get; set; }
    }
}