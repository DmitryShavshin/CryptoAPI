using CryptoAPI.MVVM.ViewModels.CoinCapVM;
using System.Windows.Controls;

namespace CryptoAPI.MVVM.Views.CoinCap
{
    /// <summary>
    /// Interaction logic for CCCandles.xaml
    /// </summary>
    public partial class CCCandles : UserControl
    {
        private CoinCapCandlesVM CoinCapCandles = new CoinCapCandlesVM();
        public CCCandles()
        {
            InitializeComponent();
            DataContext = CoinCapCandles;     
        }
    }
}
