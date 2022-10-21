using CryptoAPI.API.CryptingUp;
using CryptoAPI.MVVM.Models.CryptingUpModels;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CryptoAPI.MVVM.ViewModels.CryptingUpVM
{
    public class CryptingUpAssetsVM
    {
        CryptingUpAssets CryptingUpAssets = new CryptingUpAssets();
        public List<Asset> AssetsList { get; private set; }
        public List<Asset> AssetsOverviewList { get; private set; }
        public CryptingUpAssetsVM()
        {
            AssetsList = CryptingUpAssets.GetAssets();
            AssetsOverviewList = CryptingUpAssets.GetAssetsOverview();
        }
    }
}