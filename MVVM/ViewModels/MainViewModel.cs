using CryptoAPI.Core;
using CryptoAPI.MVVM.Models.CoinCapModels;
using CryptoAPI.MVVM.Models.CryptingUpModels;
using CryptoAPI.MVVM.ViewModels.CoinCapVM;
using CryptoAPI.MVVM.ViewModels.CryptingUpVM;
using System.Windows;

namespace CryptoAPI.MVVM.ViewModels
{
    class MainViewModel : ObservableObject
    {
        private object _currentView;
        private CryptingUPMarketsVM CryptingUPMarkets { get; set; }
        private CryptingUpExchangesVM CryptingUPExchanges { get; set; }
        private CryptingUpAssetsVM CryptingUPAssets { get; set; }
        private CryptingUpAssetVM CryptingUPAsset { get; set; }
        private CoinCapMarketsVM CoinCapMarkets { get; set; }
        private CoinCapCandlesVM CoinCapCandles { get; set; }

        public RelayCommand CryptingUpMarketsCommand { get; set; }
        public RelayCommand CoinCapMarketsCommand { get; set; }

        private object _currentView;
        public object CurrentView {
            get { return _currentView; }
            set {
                _currentView = value;
                OnPropertyChanged();    
            }
        }


        public MainViewModel()
        {
            CryptingUPMarkets = new CryptingUPMarketsVM();
            CoinCapMarkets = new CoinCapMarketsVM();
            CurrentView = CryptingUPMarkets;



            CryptingUpMarketsCommand = new RelayCommand(o =>
            {
                CurrentView = CryptingUPMarkets;
            });

            CoinCapMarketsCommand = new RelayCommand(o =>
            {
                CurrentView = CoinCapMarkets;
            });
        }
        
        public RelayCommand GetCandlesCoinCap => new RelayCommand((obj) => 
        {
            try
            {
                var result = (obj as Models.CoinCapModels.Market);
                CoinCapCandles = new CoinCapCandlesVM(result.ExchangeId, result.BaseId, result.QuoteId);
                CurrentView = CoinCapCandles;
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        });

        public RelayCommand Exchanges => new RelayCommand((obj) => 
        {
            try
            {
                CryptingUPExchanges = new CryptingUpExchangesVM();
                CurrentView = CryptingUPExchanges;
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        });

        public RelayCommand Assets => new RelayCommand((obj) =>
        {
            try
            {
                CryptingUPAssets = new CryptingUpAssetsVM();
                CurrentView = CryptingUPAssets;
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }); 
        public RelayCommand Asset => new RelayCommand((obj) =>
        {
            try
            {
                var result = (obj as Asset);
                CryptingUPAsset = new CryptingUpAssetVM(result.AssetId);
                CurrentView = CryptingUPAsset;
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        });
    }
}
