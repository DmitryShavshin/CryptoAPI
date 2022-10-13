using CryptoAPI.API.CoinCap;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CryptoAPI.MVVM.Views.CryptingUp
{
    /// <summary>
    /// Interaction logic for CUpExchanges.xaml
    /// </summary>
    public partial class CUpExchanges : UserControl
    {
        private readonly CoinCapMarkets coinCapMarkets = new CoinCapMarkets();
        public CUpExchanges()
        {
            InitializeComponent();
            ExchangesList.ItemsSource = coinCapMarkets.GetMarkets();
        }
    }
}
