using CryptoAPI.API.CryptingUp;
using CryptoAPI.MVVM.Models.CryptingUpModels;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CryptoAPI.MVVM.ViewModels.CryptingUpVM
{
    public class CryptingUpExchangesVM
    {
        CryptingUpExchanges CryptingUpExchange = new CryptingUpExchanges();

        public List<Exchange> GetExchanges()
        {
            var request = CryptingUpExchange.GetExchanges();
            var ExchangesList = JsonConvert.DeserializeObject<ExchangesList>(request);
            return ExchangesList.Exchanges;
        }

    }
}