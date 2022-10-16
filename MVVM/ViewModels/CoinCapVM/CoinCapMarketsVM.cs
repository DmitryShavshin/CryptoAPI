using CryptoAPI.API.CoinCap;
using CryptoAPI.Core;
using CryptoAPI.MVVM.Models.CoinCapModels;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CryptoAPI.MVVM.ViewModels.CoinCapVM
{
    public class CoinCapMarketsVM
    {

        private CoinCapMarkets coinCapMarkets = new CoinCapMarkets();       

        public List<Market> GetMarkets()
        {
            var request = coinCapMarkets.GetMarkets();
            var MarketsList = JsonConvert.DeserializeObject<MarketsList>(request);
            return MarketsList.Markets;
        }       
    }
}
