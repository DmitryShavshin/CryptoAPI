using CryptoAPI.MVVM.ViewModels.CryptingUpVM;
using System.Windows.Controls;


namespace CryptoAPI.MVVM.Views.CryptingUp
{
    /// <summary>
    /// Interaction logic for CUpMarkets.xaml
    /// </summary>
    public partial class CUpMarkets : UserControl
    {
        private readonly CryptingUPMarketsVM cryptingUPMarketsVM = new CryptingUPMarketsVM();
        public CUpMarkets()
        {
            InitializeComponent();
            ExchangesList.ItemsSource = cryptingUPMarketsVM.GetMarkets();
        }
    }
}
