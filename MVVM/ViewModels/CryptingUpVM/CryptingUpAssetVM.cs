using CryptoAPI.API.CryptingUp;
using CryptoAPI.MVVM.Models.CryptingUpModels;
using Newtonsoft.Json;

namespace CryptoAPI.MVVM.ViewModels.CryptingUpVM
{
    public class CryptingUpAssetVM
    {
        public CryptingUpAssets CryptingUpAssets { get; set; }
        public Asset SpecificAsset { get; set; }
        public CryptingUpAssetVM(string id)
        {
            SpecificAsset = GetSpecificAsset(id);
        }
        public CryptingUpAssetVM()
        {

        }
        public Asset GetSpecificAsset(string id)
        {
            CryptingUpAssets = new CryptingUpAssets(id);
            var request = CryptingUpAssets.GetSpecificAsset();
            var specificAsset = JsonConvert.DeserializeObject<SpecificAsset>(request);
            return specificAsset.Asset;
        }      
    }
}
