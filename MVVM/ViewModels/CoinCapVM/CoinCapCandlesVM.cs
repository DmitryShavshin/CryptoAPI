using CryptoAPI.API.CoinCap;
using CryptoAPI.MVVM.Models.CoinCapModels;
using LiveCharts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CryptoAPI.MVVM.ViewModels.CoinCapVM
{
    public class CoinCapCandlesVM
    {
        private CoinCapCandles CoinCapCandles { get; set; }
        public ChartValues<double> High { get; set; }
        public ChartValues<double> Low { get; set; }
        public ChartValues<string> Period { get; set; }
        public CoinCapCandlesVM(string exchange, string baseId, string quoteId)
        {
            CreateChart(exchange, baseId, quoteId);
        }

        public CoinCapCandlesVM()
        {

        }

        public void CreateChart(string exchange, string baseId, string quoteId)
        {
            Period = new ChartValues<string>();
            List<Candles> candlesList = new List<Candles>();
            candlesList = GetCandles(exchange, baseId, quoteId);
            High = new ChartValues<double>(candlesList.Select(h => h.High));
            Low = new ChartValues<double>(candlesList.Select(l => l.Low));
            var UnixTime = new ChartValues<long>(candlesList.Select(h => h.Period));
            TimeConverter(UnixTime);
        }

        public List<Candles> GetCandles(string exchange, string baseId, string quoteId)
        {
            CoinCapCandles = new CoinCapCandles(exchange, baseId, quoteId);
            var request = CoinCapCandles.GetCandles();
            var CandlesList = JsonConvert.DeserializeObject<CandlesList>(request);
            return CandlesList.DataList;
        }      

        private void TimeConverter(ChartValues<long> unixTime)
        {
            foreach (var item in unixTime)
            {
                DateTime time = DateTimeOffset.FromUnixTimeMilliseconds(item).UtcDateTime;
                Period.Add(time.ToString());
            }
        }
    }
}
