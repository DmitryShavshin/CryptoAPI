using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CryptoAPI.MVVM.Models.CryptingUpModels
{
    public class Asset
    {
        [JsonProperty("quote")]
        public Quote Quote { get; set; }
        [JsonProperty("asset_id")]
        public string AssetId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("volume_24h")]
        public double Volume24h { get; set; }

        [JsonProperty("change_1h")]
        public double Change1h { get; set; }

        [JsonProperty("change_24h")]
        public double Change24h { get; set; }

        [JsonProperty("change_7d")]
        public double Change7d { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }

    public class AssetList
    {
        [JsonProperty("assets")]
        public List<Asset> Assets { get; set; }
    }

    public class SpecificAsset
    {
        [JsonProperty("asset")]
        public Asset Asset { get; set; }
    }
}