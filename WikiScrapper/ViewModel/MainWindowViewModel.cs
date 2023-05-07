using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WikiScrapper.Model;

namespace WikiScrapper.ViewModel
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<NavigationPageModel> Navigation { get; set; }

        public MainWindowViewModel()
        {
            Navigation = new ObservableCollection<NavigationPageModel>();

            Navigation.Add(new NavigationPageModel
            {
                PageName = "Home",
                Description = "Search"
            });
            Navigation.Add(new NavigationPageModel
            {
                PageName = "Documents",
                Description = "Documents Store"
            });
            Navigation.Add(new NavigationPageModel
            {
                PageName = "History",
                Description = "History of searching"
            });
        }
    }
}
