using CryptoAPI.API.CryptingUp;
using CryptoAPI.MVVM.Models.CryptingUpModels;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Windows;

namespace CryptoAPI.MVVM.ViewModels.CryptingUpVM
{
    public class CryptingUpExchangesVM
    {
        CryptingUpExchanges CryptingUpExchange = new CryptingUpExchanges();
        public List<Exchange> ExchangesList { get; set; }
        public List<Quote> Quotes { get; set; }
        public CryptingUpExchangesVM()
        {
            try
            {
                Quotes = new List<Quote>();
                ExchangesList = GetExchanges();
                foreach (var item in ExchangesList)
                {
                    var quote = item.Quote;
                    Quotes.Add(quote);
                }
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public List<Exchange> GetExchanges()
        {
            var request = CryptingUpExchange.GetExchanges();
            var ExchangesList = JsonConvert.DeserializeObject<ExchangesList>(request);
            return ExchangesList.Exchanges;
        }
    }
}