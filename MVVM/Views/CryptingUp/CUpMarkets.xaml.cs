using CryptoAPI.MVVM.ViewModels.CryptingUpVM;
using System.Windows.Controls;


namespace CryptoAPI.MVVM.Views.CryptingUp
{
    /// <summary>
    /// Interaction logic for CUpMarkets.xaml
    /// </summary>
    public partial class CUpMarkets : UserControl
    {
        private readonly CryptingUPMarketsVM CryptingUPMarkets = new CryptingUPMarketsVM();
        public CUpMarkets()
        {
            InitializeComponent();
            DataContext = new CryptingUPMarketsVM();
            ExchangesList.ItemsSource = CryptingUPMarkets.GetMarkets();
        }
    }
}
