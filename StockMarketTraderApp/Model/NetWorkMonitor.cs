using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace DevExpress.StockMarketTrader.Model {
    public class NetworkMonitor {
        const string serverName = "google.com";

        readonly Timer timer;
        readonly Ping ping;
        bool isInit = false;

        public event EventHandler<EventArgs> InternetAvaliableChanged;

        public bool IsInternetAvaliable { get; private set; }

        public NetworkMonitor() {
            ping = new Ping();
            ping.PingCompleted += PingCompleted;
            timer = new Timer() { Interval = 1 };
            timer.Tick += OnTimerTick;
            timer.Start();
        }
        void OnTimerTick(object sender, EventArgs e) {
            timer.Stop();
            ping.SendAsync(serverName, null);
        }
        void PingCompleted(object sender, PingCompletedEventArgs e) {
            bool isAvaliable = e.Reply == null || e.Reply.Status != IPStatus.Success ? false : true;
            if (isAvaliable != IsInternetAvaliable) {
                isInit = true;
                IsInternetAvaliable = isAvaliable;
                RaiseInternetAvaliableChanged();
            }
            else if (!isInit) {
                isInit = true;
                RaiseInternetAvaliableChanged();
            }
            //timer.Start();
        }
        void RaiseInternetAvaliableChanged() {
            if (InternetAvaliableChanged != null)
                InternetAvaliableChanged(this, EventArgs.Empty);
        }
    }
}
