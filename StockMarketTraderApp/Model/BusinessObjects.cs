using System;
using DevExpress.StockMarketTrader.StockDataServiceReference;

namespace DevExpress.StockMarketTrader.Model.BusinessObjects {
    public class TradingData {
        public DateTime Date { get; set; }
        public double Price { get; set; }
        public double Open { get; set; }
        public double Close { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Volume { get; set; }

        public TradingData() {
        }
        public TradingData(TradingData data) {
            Assign(data);
        }
        public void Assign(TradingData data) {
            Date = data.Date;
            Price = data.Price;
            Open = data.Open;
            Close = data.Close;
            High = data.High;
            Low = data.Low;
            Volume = data.Volume;
        }
    }

    public class CompanyTradingData : TradingData {
        public string CompanyName { get; set; }

        public CompanyTradingData(TradingData data, string companyName) : base(data) {
            CompanyName = companyName;
        }
        public CompanyTradingData(StockData data, string companyName) {
            Date = data.Date;
            Close = (double)data.CloseP;
            Open = (double)data.OpenP;
            Price = (double)data.Price;
            High = (double)data.HighP;
            Low = (double)data.LowP;
            Volume = data.Volumne;
            CompanyName = companyName;
        }
    }

    public class TransactionData {
        string transactionType;
        int volume;
        double price;

        public int Ask { get { return transactionType == "Ask" ? volume : 0; } }
        public int Bid { get { return transactionType == "Bid" ? volume : 0; } }
        public int Volume { get { return volume; } set { volume = value; } }
        public double Price { get { return price; } set { price = value; } }
        public string TransactionType { get { return transactionType; } }

        public TransactionData(string transactionType, int volume, double price) {
            this.volume = volume;
            this.price = price;
            this.transactionType = transactionType;
        }
    }
}
