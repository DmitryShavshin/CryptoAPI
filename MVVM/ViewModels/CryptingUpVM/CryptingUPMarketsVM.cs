using CryptoAPI.API.CryptingUp;
using CryptoAPI.MVVM.Models.CryptingUpModels;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CryptoAPI.MVVM.ViewModels.CryptingUpVM
{
    public class CryptingUPMarketsVM
    {
        CryptingUpMarkets CryptingUpMarket = new CryptingUpMarkets();
        public List<Market> GetMarkets()
        {
            var request = CryptingUpMarket.GetMarkets();
            var MarketsList = JsonConvert.DeserializeObject<MarketsList>(request);
            return MarketsList.Markets;
        }
    }
}