using System;
using DevExpress.StockMarketTrader.Model.BusinessObjects;

namespace DevExpress.StockMarketTrader.ViewModel {
    public class TradingDataViewModel : ViewModelBase {
        readonly TradingData tradingData;

        public DateTime Date {
            get { return TradingData.Date; }
            set {
                TradingData.Date = value;
                OnPropertyChanged("Date");
            }
        }
        public double Price {
            get { return TradingData.Price; }
            set {
                TradingData.Price = value;
                OnPropertyChanged("Price");
            }
        }
        public double Open {
            get { return TradingData.Open; }
            set {
                TradingData.Open = value;
                OnPropertyChanged("Open");
            }
        }
        public double Close {
            get { return TradingData.Close; }
            set {
                TradingData.Close = value;
                OnPropertyChanged("Close");
            }
        }
        public double High {
            get { return TradingData.High; }
            set {
                TradingData.High = value;
                OnPropertyChanged("High");
            }
        }
        public double Low {
            get { return TradingData.Low; }
            set {
                TradingData.Low = value;
                OnPropertyChanged("Low");
            }
        }
        public double Volume {
            get { return TradingData.Volume; }
            set {
                TradingData.Volume = value;
                OnPropertyChanged("Volume");
            }
        }
        public TradingData TradingData { get { return tradingData; } }

        public TradingDataViewModel() {
            tradingData = new TradingData();
        }
        public TradingDataViewModel(TradingData data) : this() {
            Assign(data);
        }
        public TradingDataViewModel(DateTime dateTime) : this() {
            this.Date = dateTime;
        }
        public void Assign(TradingData data) {
            tradingData.Assign(data);
            OnPropertyChanged("Price");
            OnPropertyChanged("Volume");
        }
    }

    public class CompanyTradingDataViewModel : TradingDataViewModel {
        int rise;
        LockableCollection<TradingDataViewModel> volumeDynamics;

        double totalRise;
        public double TotalRise {
            get {
                return totalRise;
            }
            set {
                totalRise = value;
                 OnPropertyChanged("TotalRise");
            }
        }
        public string CompanyName { get; private set; }
        public int Rise {
            get { return rise; }
            set {
                rise = value;
                OnPropertyChanged("Rise");
            }
        }
        public LockableCollection<TradingDataViewModel> VolumeDynamics {
            get { return volumeDynamics; }
            set {
                volumeDynamics = value;
                OnPropertyChanged("VolumeDynamics");
            }
        }

        public CompanyTradingDataViewModel(TradingData data, string companyName, int rise, double totalRise) : base(data) {
            CompanyName = companyName;
            TotalRise = totalRise;
            Rise = rise;
        }
        public void Assign(CompanyTradingData ctd) {
            CompanyName = ctd.CompanyName;
            base.Assign(ctd);
        }
    }
}
