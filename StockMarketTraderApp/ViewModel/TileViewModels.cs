using System.ComponentModel;

namespace DevExpress.StockMarketTrader.ViewModel {
    public class LiveTileViewModel : ViewModelBase {
        string arrow;
        string companyIndex;
        string persent;
        string priceIncrease;
        BindingList<TradingDataViewModel> source = new BindingList<TradingDataViewModel>();

        public string Arrow {
            get { return arrow; }
            set {
                arrow = value;
                OnPropertyChanged("Arrow");
            }
        }
        public string CompanyIndex {
            get { return companyIndex; }
            set {
                companyIndex = value;
                OnPropertyChanged("CompanyIndex");
            }
        }
        public string Persent {
            get { return persent; }
            set {
                persent = value;
                OnPropertyChanged("Persent");
            }
        }
        public string PriceIncrease {
            get { return priceIncrease; }
            set {
                priceIncrease = value;
                OnPropertyChanged("PriceIncrease");
            }
        }
        public BindingList<TradingDataViewModel> Source {
            get { return source; }
            set {
                source = value;
                OnPropertyChanged("Source");
            }
        }
    }
}
