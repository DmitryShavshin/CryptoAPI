using CryptoAPI.MVVM.ViewModels.CoinCapVM;
using System.Windows.Controls;

namespace CryptoAPI.MVVM.Views.CoinCap
{
    /// <summary>
    /// Interaction logic for CCMarkets.xaml
    /// </summary>
    public partial class CCMarkets : UserControl
    {
        private CoinCapMarketsVM CoinCapMarketsVM = new CoinCapMarketsVM();
        public CCMarkets()
        {
            InitializeComponent();
            DataContext = CoinCapMarketsVM;
        }
    }
}
