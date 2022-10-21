using CryptoAPI.Core;
using CryptoAPI.MVVM.Models.CryptingUpModels;
using CryptoAPI.MVVM.Models.Enum;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CryptoAPI.API.CryptingUp
{
    public class CryptingUpAssets
    {
        private static string _id = "BTC";
        private const string ASSETS = "https://cryptingup.com/api/assets";
        private const string OVERVIEW = "https://cryptingup.com/api/assetsoverview";
        
        private Execute execute = new Execute();
        private string Response { get; set; }
        

        public CryptingUpAssets(string id)
        {
            _id = id;
        }

        public CryptingUpAssets()
        {

        }
        public List<Asset> GetAssets()
        {
            Response = execute.ExequteRequest(ASSETS, RequestTypes.GET.ToString());
            var AssetsList = JsonConvert.DeserializeObject<AssetList>(Response);
            return AssetsList.Assets;
        }

        //Get a specific asset
        public string GetSpecificAsset()
        {
            string specificAsset = $"https://cryptingup.com/api/assets/{_id}";
            return Response = execute.ExequteRequest(specificAsset, RequestTypes.GET.ToString());
        }

        public List<Asset> GetAssetsOverview()
        {
            string specificAsset = $"https://cryptingup.com/api/assets/{_id}";
            Response = execute.ExequteRequest(OVERVIEW, RequestTypes.GET.ToString());
            var AssetsList = JsonConvert.DeserializeObject<AssetList>(Response);
            return AssetsList.Assets;
        }        
    }
}