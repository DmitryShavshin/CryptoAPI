using CryptoAPI.MVVM.Models.CoinCapModels;
using CryptoAPI.MVVM.ViewModels.CoinCapVM;
using System.Windows;
using System.Windows.Controls;

namespace CryptoAPI.MVVM.Views.CoinCap
{
    /// <summary>
    /// Interaction logic for CCMarkets.xaml
    /// </summary>
    public partial class CCMarkets : UserControl
    {
        private readonly CoinCapMarketsVM coinCapMarkets = new CoinCapMarketsVM();
        public CCMarkets()
        {
            InitializeComponent();
            DataContext = coinCapMarkets;
            MarketsList.ItemsSource = coinCapMarkets.GetMarkets();
        }
    }
}
