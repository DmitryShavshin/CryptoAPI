using CryptoAPI.API.CoinCap;
using CryptoAPI.MVVM.Models.CoinCapModels;
using LiveCharts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CryptoAPI.MVVM.ViewModels.CoinCapVM
{
    public class CoinCapMarketsVM
    {
        private CoinCapMarkets coinCapMarkets = new CoinCapMarkets();
        public List<Market> GetMarkets()
        {
            var elements = new List<List<int>>();
            var request = coinCapMarkets.GetMarkets();
            var MarketsList = JsonConvert.DeserializeObject<MarketsList>(request);
            return MarketsList.Markets;
        }
    }
}
