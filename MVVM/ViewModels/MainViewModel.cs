using CryptoAPI.Core;
using CryptoAPI.MVVM.ViewModels.CoinCapVM;
using CryptoAPI.MVVM.ViewModels.CryptingUpVM;

namespace CryptoAPI.MVVM.ViewModels
{
    class MainViewModel : ObservableObject
    {
        private object _currentView;
        private CryptingUPMarketsVM CryptingUPMarkets { get; set; }
        private CoinCapMarketsVM CoinCapMarkets { get; set; }
        private CoinCapCandlesVM CoinCapCandles { get; set; }

        public RelayCommand CryptingUpMarketsCommand { get; set; }
        public RelayCommand CoinCapMarketsCommand { get; set; }
        public RelayCommand CoinCapCandlesComand { get; set; }

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
            CoinCapCandles = new CoinCapCandlesVM();
            CurrentView = CryptingUPMarkets;



            CryptingUpMarketsCommand = new RelayCommand(o =>
            {
                CurrentView = CryptingUPMarkets;
            });

            CoinCapMarketsCommand = new RelayCommand( o =>
            {
                CurrentView = CoinCapMarkets;
            });

            CoinCapCandlesComand = new RelayCommand(o =>
            {
                CurrentView = CoinCapCandles;
            });
        }
    }
}
