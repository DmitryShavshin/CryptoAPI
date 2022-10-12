using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace CryptoAPI.Core
{
    class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _Cliks { get; set; }
        protected void OnPropertyChanged([CallerMemberName] string prop = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
     

        public int Cliks { 
            get 
            { 
                return _Cliks; 
            }
            set
            {
                _Cliks = value;
                OnPropertyChanged();
            }
        }
    }
}
