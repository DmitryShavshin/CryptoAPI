using CryptoAPI.MVVM.ViewModels.CryptingUpVM;
using System.Windows.Controls;


namespace CryptoAPI.MVVM.Views.CryptingUp
{
    public partial class CryptingUpMarketsView : UserControl
    {
        private readonly CryptingUPMarketsVM cryptingUPMarketsVM = new CryptingUPMarketsVM();

        public CryptingUpMarketsView()
        {
            InitializeComponent();
            MarketsList.ItemsSource = cryptingUPMarketsVM.GetMarkets();
        }
    }
}
