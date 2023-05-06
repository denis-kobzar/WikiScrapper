using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Animation;
using WikiScrapper.Core;

namespace WikiScrapper.MVVM.ViewModel
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        private int _clicks = 0;

        public int Clicks
        {
            get => _clicks;
            set
            {
                _clicks = value;
                OnPropertyChanged();
            }
        }

        public ICommand ClickAdd
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    Clicks++;
                });
            }
        }

        public ICommand ClickRemove
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    if (Clicks > 0)
                    {
                        Clicks--;
                    }
                });
            }
        }
    }
}
