using CryptoAPI.MVVM.ViewModels.CoinCapVM;
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
            MarketsList.ItemsSource = coinCapMarkets.GetMarkets();
        }
    }
}
