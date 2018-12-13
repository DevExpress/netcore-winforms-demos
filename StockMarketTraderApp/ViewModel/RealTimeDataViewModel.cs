using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Forms;
using DevExpress.StockMarketTrader.Model;
using DevExpress.StockMarketTrader.Model.BusinessObjects;
using DevExpress.StockMarketTrader.StockDataServiceReference;
using Application = System.Windows.Forms.Application;

namespace DevExpress.StockMarketTrader.ViewModel {
    public class RealTimeDataViewModel : ViewModelBase {
        public static bool IsReady = false;
        protected static void InvokeSync(Delegate method) {
            if (method != null && Application.OpenForms.Count > 0) {
                for(int i = 0; i < Application.OpenForms.Count; i++) {
                    Form form = Application.OpenForms[i];
                    if(form is StockMarketView)
                        form.Invoke(method, new object[] { });
                }
            }
        }

        object sem = new object();
        string selectedCompanyName = "MSFT";
        int volumeCount = 15;
        int countOfWeek = 1;
        int candlesCount = 72, currentDate = 0, tickCount = 0, offlineTimeInterval = 500, totalTicks = 5;
        bool isAllBindingDataUpdate = false, canEndUpdate = true, canUpdate = true;
        double highestPrice = 0, lowestPrice = 0;
        public RealTimeDataModel model;
        Dictionary<string, Queue<Delegate>> defferedUpdate = new Dictionary<string, Queue<Delegate>>();
        List<DateTime> dates;
        List<string> companies;
        LockableCollection<TransactionData> transactionGridBindingData;
        LockableCollection<CompanyTradingDataViewModel> watchLisBindingData;
        BindingList<CompaniesVolumeData> volumeChartBindingData;
        BindingList<TradingDataViewModel> stockChartBindingData;
        CompanyTradingDataViewModel selectedCompany;
        ObservableCollection<CompanyTradingDataViewModel> oldWatchListData;
        LiveTileViewModel sparklineTileViewModel = new LiveTileViewModel();
        List<LiveTileViewModel> topThreeCompanies = new List<LiveTileViewModel>() { new LiveTileViewModel(), new LiveTileViewModel(), new LiveTileViewModel() };

        EventHandler currentPriceIndexChanged;
        EventHandler watchListChanged;

        public event EventHandler CurrentPriceIndexChanged { add { currentPriceIndexChanged += value; } remove { currentPriceIndexChanged -= value; } }
        public event EventHandler WatchListChanged { add { watchListChanged += value; } remove { watchListChanged -= value; } }


        Timer TimerCore { get; set; }
        public int CurrentPriceIndex { get; set; }
        public int Ticks {
            get { return totalTicks; }
            set { totalTicks = value; }
        }
        public int TickCount {
            get { return tickCount; }
            set { tickCount = value; } }
        public int CandlesCount {
            get { return candlesCount; }
            set { candlesCount = value; }
        }
        public bool IsSuspendUpdating { get; set; }
        public bool IsLoading { get; set; }
        public string NetworkState { get { return model.NetworkState; } }
        public CompanyTradingDataViewModel SelectedCompany {
            get { return selectedCompany; }
            set {
                if (value != null) {
                    if(selectedCompanyName != value.CompanyName || selectedCompany != value) {
                        List<CompanyTradingDataViewModel> result = watchLisBindingData.Where(e => e.CompanyName == value.CompanyName).Select(e => e).ToList();
                        if (result.Count > 0) {
                            selectedCompanyName = value.CompanyName;
                            selectedCompany = result[0];
                            SetSelectedCompany();
                        }
                    }
                }
                OnPropertyChanged("SelectedCompany");
            }
        }
        public LiveTileViewModel SparklineTileViewModel {
            get { return sparklineTileViewModel; }
            set { sparklineTileViewModel = value; OnPropertyChanged("SparklineTileViewModel"); }
        }
        public List<LiveTileViewModel> TopThreeCompanies {
            get { return topThreeCompanies; }
            set { topThreeCompanies = value; OnPropertyChanged("TopThreeCompanies"); }
        }
        public LockableCollection<CompanyTradingDataViewModel> WatchListBindingData { get { return watchLisBindingData; } }
        public BindingList<TradingDataViewModel> StockChartBindingData { get { return stockChartBindingData; } }
        public LockableCollection<TransactionData> TransactionGridBindingData { get { return transactionGridBindingData; } }
        public BindingList<CompaniesVolumeData> VolumeChartBindingData { get { return volumeChartBindingData; } }

        public RealTimeDataViewModel(Timer timer) {
            TimerCore = timer;
            TimerCore.Interval = offlineTimeInterval;
            TimerCore.Tick += new EventHandler(UpdateOnTimer);

            model = new RealTimeDataModel();
            model.UpdateFailed += new EventHandler<RealTimeDataEventArgs>(OnUpdateFailed);
            model.Initialized += new EventHandler<EventArgs>(OnInitialized);
            stockChartBindingData = new BindingList<TradingDataViewModel>();
            watchLisBindingData = new LockableCollection<CompanyTradingDataViewModel>();
            transactionGridBindingData = new LockableCollection<TransactionData>();
            volumeChartBindingData = new BindingList<CompaniesVolumeData>();

            IsLoading = true;
        }
        void OnInitialized(object sender, EventArgs e) {
            GetDatesAsync();
        }
        void OnUpdateFailed(object sender, RealTimeDataEventArgs e) {
        }
        void OnCandlesCountChangedCallBack() {
            CorrectCurrentDate();
            tickCount = 0;
            candlesCount = CandlesCount + 1;
            StopTimer();
            UpdateAllBindingData();
        }
        void CorrectCurrentDate() {
            int delta = currentDate;
            delta = currentDate - (CandlesCount + 1) * Ticks;
            if (delta > -1)
                currentDate = delta;
            else {
                delta = currentDate - candlesCount * totalTicks;
                currentDate = delta < 0 ? 0 : delta;
            }
        }
        //void ChangeTimerInterval(int time) {
        //    TimerCore.Interval = time;
        //}
        void StartTimer() {
            InvokeSync(new Action(() => { TimerCore.Start(); }));
        }
        void StopTimer() {
            InvokeSync(new Action(() => { TimerCore.Stop(); }));
        }
        void GetDatesAsync() {
            SetDates(model.Service.GetDates());
            //Action<DateTime[]> action = new Action<DateTime[]>(SetDates);
            //AddDefferedDelegate("GetDates", action);
            //model.BeginGetDates();
        }
        void SetDates(DateTime[] dates) {
            try {
                if (dates.Length == 0)
                    throw new Exception();
                this.dates = new List<DateTime>(dates);
                GetCompaniesAsync();
                canEndUpdate = true;
            }
            catch {
                canUpdate = false;
            }
        }
        void InitializeChartBindingData() {
            isAllBindingDataUpdate = true;
            stockChartBindingData.Clear();
        }
        void GetCompaniesAsync() {
            SetCompanies(model.Service.GetCompaniesName());
        }
        void SetCompanies(string[] arrayCompanies) {
            if(model.IsOnline) {
                this.companies = new List<string>();
                for(int i = 0; i < arrayCompanies.Length; i++)
                    this.companies.Add(arrayCompanies[i]);
            }
            else
                this.companies = new List<string>(arrayCompanies);
            InitializeChartBindingData();
            GetBindingDataAsync();
        }
        void GetVolumeDynamicsDataAsyncCompleted2(StockData[] data) { }
        void GetBindingDataAsync() {
            GetWatchListBindingDataAsync();
            GetCompaniesVolumeAsync();
            currentDate = 0;
            
            GetVolumeDynamicsDataAsync();
            GetStockChartBindingDataAsync();
        }
        void GetVolumeDynamicsDataAsync(int current = 0) {
            if (companies == null) return;
            int date = current + totalTicks * ((candlesCount - volumeCount) + 1);
            GetVolumeDynamicsDataAsyncCompleted(model.Service.GetStockDataFromPeriodByCompanyList(date, volumeCount, totalTicks, companies.ToArray()));
        }
        void GetVolumeDynamicsDataAsyncCompleted(CompanyStockData[] cd) {
            foreach (CompanyStockData companyStockData in cd) {
                CompanyTradingDataViewModel vm = watchLisBindingData.Where(c => c.CompanyName == companyStockData.CompanyName).Select(c => c).FirstOrDefault();
                vm.VolumeDynamics = CreateVolumeDynamicsBindingData(companyStockData.Data);
            }
            TryEndUpdateBindingData();
        }
        void GetWatchListBindingDataAsync() {
            currentDate += candlesCount * totalTicks;
            UpdateWatchListBindingDataAsyncCompleted(model.Service.GetStockDataByDate(dates[currentDate - 1]));
        }
        void GetStockChartBindingDataAsync() {
            GetStockChartBindingDataAsyncCompleted(model.Service.GetCompanyMultipleDataFromPeriod(currentDate, candlesCount, totalTicks, selectedCompanyName));
        }
        void GetStockChartBindingDataAsyncCompleted(CompanyData[] data) {
            List<CompanyData> newStockChartData = new List<CompanyData>();
            try {
                newStockChartData = new List<CompanyData>(data);
            }
            catch { }
            AddChartPoints(newStockChartData);
        }
        void AddChartPoints(List<CompanyData> newStockChartData) {
            CreateChartBindingData(newStockChartData);
            UpdateSparklineViewModelSource();
            isAllBindingDataUpdate = false;
            TryEndUpdateBindingData();
        }
        void UpdateSparklineViewModelSource() {
            SparklineTileViewModel.Source = stockChartBindingData;
        }
        void UpdateWatchListBindingDataAsync() {
            if (dates == null) return;
            if(currentDate >= 0 && currentDate < dates.Count)
                UpdateWatchListBindingDataAsyncCompleted(model.Service.GetStockDataByDate(dates[currentDate]));
            else
                UpdateWatchListBindingDataAsyncCompleted(model.Service.GetStockDataByDate(dates.FirstOrDefault()));
        }
        void UpdateCompaniesVolumeAsync() {
            if (tickCount == totalTicks || tickCount == 0)
                GetCompaniesVolumeAsync();
        }
        void UpdateWatchListBindingDataAsyncCompleted(StockData[] gridData) {
            UpdateWatchList(gridData);
            UpdateSparklineViewModelCompany();
            UpdateTopThreeCompany();
            TryEndUpdateBindingData();
        }
        void UpdateTopThreeCompany() {
            var topThree = GetTopThreeVolume();
            if (topThree.Count < 3) return;
            var result = new List<LiveTileViewModel>();
            foreach (CompaniesVolumeData volumeData in topThree) {
                LiveTileViewModel vm = new LiveTileViewModel();
                vm.CompanyIndex = volumeData.CompanyName;
                double delta = 0;
                double increace = CalcIncrease(volumeData.CompanyName, ref delta);
                vm.Arrow = increace > 0 ? "▲" : "▼";
                vm.Persent = Math.Abs(increace) * 100 + "%";
                vm.PriceIncrease = Math.Abs(Math.Round(delta, 3)).ToString();
                result.Add(vm);
            }
            TopThreeCompanies = result;
        }
        void GetCompaniesVolumeAsync() {
            int endIndex = currentDate - totalTicks;
            if (dates != null && currentDate < dates.Count && endIndex > 0) {
                DateTime start = dates[currentDate];
                DateTime end = dates[endIndex];
                GetCompaniesVolumeCompleted(model.Service.GetCompaniesVolumeFromPeriod(start, end));
            }
        }
        void GetCompaniesVolumeCompleted(CompaniesVolumeData[] data) {
            UpdateVolumeChartBindingData(data);
        }
        void UpdateVolumeChartBindingData(CompaniesVolumeData[] data) {
            volumeChartBindingData.Clear();
            SetVolumeOfSelectedCompany();
            int index = 1;
            for (int i = 0; i < data.Length - 1; i++) {
                if (data[i].CompanyName == selectedCompanyName)
                    continue;
                if (volumeChartBindingData.Count < data.Length + 1)
                    volumeChartBindingData.Add(data[i]);
                index++;
            }
            ValidateCompaniesVolume();
            TryEndUpdateBindingData();
        }
        void UpdateSparklineViewModelCompany() {
            SparklineTileViewModel.CompanyIndex = SelectedCompany?.CompanyName;
            double delta = 0;
            double increace = CalcIncrease(SelectedCompany?.CompanyName, ref delta);
            SparklineTileViewModel.Arrow = increace > 0 ? "▲" : "▼";
            SparklineTileViewModel.Persent = Math.Abs(increace) * 100 + "%";
        }
        void ValidateCompaniesVolume() {
            List<string> volumeCompanies = volumeChartBindingData.Select(c => c.CompanyName).ToList();
            List<string> exceptCompanies = companies.Except(volumeCompanies).ToList();
            for (int i = 0; i < volumeChartBindingData.Count; i++) {
                CompaniesVolumeData volumeData = volumeChartBindingData[i];
                if (!companies.Contains(volumeData.CompanyName)) {
                    var res = watchLisBindingData.Where(c => exceptCompanies.Contains(c.CompanyName)).ToList();
                    if (res.Count > 0) {
                        double maxVolume = res.Max(c => c.Volume);
                        CompanyTradingDataViewModel vm = watchLisBindingData.Where(c => c.Volume == maxVolume).Select(c => c).FirstOrDefault();
                        exceptCompanies.Remove(vm.CompanyName);
                        volumeChartBindingData[i] = new CompaniesVolumeData() {
                            CompanyName = vm.CompanyName,
                            Volume = (int)maxVolume
                        };
                    }
                }
            }
        }
        void SetVolumeOfSelectedCompany() {
            if (volumeChartBindingData.Count == 0 && SelectedCompany != null) {
                CompaniesVolumeData cvd = new CompaniesVolumeData();
                cvd.CompanyName = SelectedCompany.CompanyName;
                cvd.Volume = (int)SelectedCompany.Volume;
                volumeChartBindingData.Add(cvd);
            }
            else if (SelectedCompany != null) {
                volumeChartBindingData[0].CompanyName = SelectedCompany.CompanyName;
                volumeChartBindingData[0].Volume = (int)SelectedCompany.Volume;
            }
        }
        void TryEndUpdateBindingData() {
            if (canEndUpdate)
                EndUpdateBindingData();
        }
        void EndUpdateBindingData() {
            if (!TimerCore.Enabled && !isAllBindingDataUpdate)
                StartTimer();
        }
        void UpdateOnTimer(object sender, EventArgs e) {
            if (!IsSuspendUpdating)
                UpdateData();
        }
        void UpdateAllBindingData(bool needUpdateVolumeDynamics = true) {
            if (canUpdate) {
                InitProperties();
                model.ChangeUserState();
                defferedUpdate.Clear();
                tickCount = 0;
                if (needUpdateVolumeDynamics)
                    GetVolumeDynamicsDataAsync(currentDate);
                
                UpdateCompaniesVolumeAsync();
                UpdateWatchListBindingDataAsync();

                InitializeChartBindingData();
                GetStockChartBindingDataAsync();
            }
        }
        void UpdateData() {
            lock (sem) {
                int dateLocal = currentDate;
                if (dates == null || dateLocal < 0 || dateLocal > dates.Count -1) return;
                StopTimer();
                DateTime date = dates[dateLocal];
                switch (totalTicks) {
                    case 5:
                        RemoveOldCompanyStockChart(date, 1);
                        break;
                    case 10:
                        RemoveOldCompanyStockChart(date, 2);
                        break;
                    case 20:
                        RemoveOldCompanyStockChart(date, 4);
                        break;
                }
                UpdateBindingData();
            }
        }
        void RemoveOldCompanyStockChart(DateTime date, int count) {
            if (date.DayOfWeek == DayOfWeek.Monday && countOfWeek == count) {
                tickCount = 0;
                if (stockChartBindingData != null && stockChartBindingData.Count > 1) stockChartBindingData.Remove(stockChartBindingData[0]);
                foreach (CompanyTradingDataViewModel vm in watchLisBindingData) {
                    if (vm.VolumeDynamics != null && ((IList)vm.VolumeDynamics).Count > 0)
                        ((IList)vm.VolumeDynamics).RemoveAt(0);
                }
                return;
            }
        }
        void UpdateBindingData() {
            UpdateStockChartBindingDataAsync();
            UpdateWatchListBindingDataAsync();
            UpdateCompaniesVolumeAsync();
            UpdateVolumeDynamicsAsync();
            UpdateTransactionBindingData();
        }
        void UpdateVolumeDynamicsAsync() {
            if (companies != null)
                UpdateVolumeDynamicsAsyncCompleted(model.Service.GetStockDataFromDateByCompanyList(dates[currentDate], companies.ToArray()));
        }
        void UpdateVolumeDynamicsAsyncCompleted(CompanyStockData[] cd) {
            foreach (CompanyStockData companynStockData in cd) {
                try {
                    if (companynStockData.Data.Length == 0) continue;
                    DateTime current = dates[currentDate];
                    CompanyTradingData ctd = GetCompanyTradingData(companynStockData.Data[0], current);
                    CompanyTradingDataViewModel vm = watchLisBindingData.Where(c => c.CompanyName == companynStockData.CompanyName).Select(c => c).FirstOrDefault();
                    if (vm == null) continue;
                    IList<TradingDataViewModel> volDyn = vm.VolumeDynamics as IList<TradingDataViewModel>;

                    if (vm.VolumeDynamics == null || ((IList)vm.VolumeDynamics).Count == 0) return;
                    if (tickCount == 2) {
                        ctd.Volume = Math.Round((ctd.Volume / 1000000), 2);
                        volDyn.Add(new TradingDataViewModel(ctd));
                    }
                    if (tickCount != 2) {
                        TradingDataViewModel tdvm = new TradingDataViewModel(volDyn[volDyn.Count - 1].TradingData);
                        tdvm.Volume = Math.Round((ctd.Volume / 1000000), 2);
                        tdvm.Close = ctd.Close;
                        tdvm.Low = lowestPrice;
                        tdvm.High = highestPrice;
                        tdvm.Price = ctd.Price;
                        volDyn[volDyn.Count - 1] = tdvm;
                    }
                }
                catch {
                    currentDate++;
                    UpdateStockChartBindingDataAsync();
                }
            }
            TryEndUpdateBindingData();
        }
        void UpdateStockChartBindingDataAsync() {
            UpdateStockChartBindingDataAsyncCompleted(model.Service.GetCompanyStockData(dates[currentDate], selectedCompanyName));
        }
        void UpdateStockChartBindingDataAsyncCompleted(StockData[] data) {
            if (data.Length == 0) {
                IncrementDateAndUpdateStockChartBindingData();
            }
            else {
                try {
                    UpdateStockChart(data[0]);
                    UpdateSparklineViewModelSource();
                    TryEndUpdateBindingData();
                }
                catch {
                    IncrementDateAndUpdateStockChartBindingData();
                }
            }
        }
        void IncrementDateAndUpdateStockChartBindingData() {
            currentDate++;
            UpdateStockChartBindingDataAsync();
        }
        void UpdateStockChart(StockData newChartData) {
            tickCount++;
            DateTime current = dates[currentDate];
            CompanyTradingData ctd = GetCompanyTradingData(newChartData, current);
            switch (totalTicks) {
                case 5:
                    AddStockChart(current, ctd, 1);
                    break;
                case 10:
                    AddStockChart(current, ctd, 2);
                    break;
                default:
                    AddStockChart(current, ctd, 4);
                    break;
            }
            currentDate++;
        }
        void AddStockChart(DateTime current, CompanyTradingData ctd, int count) {
            if (current.DayOfWeek == DayOfWeek.Monday && countOfWeek == count) {
                ctd.Volume = Math.Round((ctd.Volume / 1000000), 2);
                stockChartBindingData.Add(new TradingDataViewModel(ctd));
                highestPrice = ctd.High;
                lowestPrice = ctd.Low;
                countOfWeek = 1;
                return;
            }
            if (current.DayOfWeek == DayOfWeek.Monday && countOfWeek != count) {
                SetStockChartBindingData(ctd);
                countOfWeek++;
                return;
            }
            if (current.DayOfWeek != DayOfWeek.Monday) SetStockChartBindingData(ctd);
        }
        void TryResetCurrentDate() {
            if (dates != null && currentDate + totalTicks > dates.Count - 1) {
                currentDate = 0;
                tickCount = 0;
            }
        }
        void CreateChartBindingData(List<CompanyData> newStockChartData) {
            TryResetCurrentDate();
            int index = 0;
            DateTime firstDate = newStockChartData[0].Data.Date;
            DateTime startDate = new DateTime(firstDate.Year, firstDate.Month, 1);
            foreach (CompanyData candleData in newStockChartData) {
                CompanyTradingData ctd = new CompanyTradingData(candleData.Data, "");
                ctd.Close = candleData.ClosePrice;
                ctd.Volume = Math.Round(((double)ctd.Volume / 1000000), 2);
                ctd.Low = lowestPrice = candleData.LowPrice;
                ctd.High = highestPrice = candleData.HighPrice;
                TradingDataViewModel viewModel = new TradingDataViewModel(ctd) { Date = startDate };
                if (stockChartBindingData.Count < candlesCount) {
                    stockChartBindingData.Add(viewModel);
                }
                else
                    stockChartBindingData[index] = viewModel;
                startDate = UpdateDate(startDate, true);
                index++;
            }
            DateTime search = UpdateDate(startDate, false);
            while (true) {
                int dateIndex = dates.IndexOf(search);
                if (dateIndex != -1) {
                    currentDate = dateIndex;
                    break;
                }
                search = search.AddDays(-1);
            }
        }
        void UpdateWatchList(StockData[] watchListData) {
            int count = 0;
            int isRise = 0;
            oldWatchListData = new ObservableCollection<CompanyTradingDataViewModel>(watchLisBindingData as IEnumerable<CompanyTradingDataViewModel>);
            oldWatchListData = new ObservableCollection<CompanyTradingDataViewModel>();
            foreach (CompanyTradingDataViewModel item in watchLisBindingData) {
                oldWatchListData.Add(new CompanyTradingDataViewModel(item.TradingData, item.CompanyName, item.Rise, item.TotalRise));
            }
            watchLisBindingData.BeginUpdate();
            foreach (StockData dt in watchListData) {
                if (companies.Count <= (dt.CompanyID)) continue;
                CompanyTradingData ctd = new CompanyTradingData(dt, companies[dt.CompanyID]);
                if (watchLisBindingData.Count < companies.Count)
                    watchLisBindingData.Add(new CompanyTradingDataViewModel(ctd, ctd.CompanyName, isRise, 1));
                else {
                    SetWatchListBindingData(count, ctd);
                    count++;
                }
            }
            watchLisBindingData.EndUpdate();
            if (watchListChanged != null)
                watchListChanged(this, EventArgs.Empty);
        }
        void SetWatchListBindingData(int index, CompanyTradingData ctd) {
             watchLisBindingData[index].Rise = 0;
            if (ctd.Price > watchLisBindingData[index].Price) {
                watchLisBindingData[index].TotalRise = Math.Min(0.5 + (1 - watchLisBindingData[index].Price / ctd.Price) * 10, 1.3);
                watchLisBindingData[index].Rise = 180;
            }
            else if (ctd.Price < watchLisBindingData[index].Price) {
                watchLisBindingData[index].TotalRise = Math.Min(0.5 + (1 - ctd.Price / watchLisBindingData[index].Price) * 10, 1.3);
                watchLisBindingData[index].Rise = -180;
            }
            watchLisBindingData[index].Assign(ctd);
        }
        void SetStockChartBindingData(CompanyTradingData ctd)
        {
            TradingDataViewModel tdvm = null;
            if (stockChartBindingData.Count > 0)
                tdvm = new TradingDataViewModel(stockChartBindingData[stockChartBindingData.Count - 1].TradingData);
            else
                tdvm = new TradingDataViewModel();
            highestPrice = Math.Max(highestPrice, ctd.High);
            lowestPrice = Math.Min(lowestPrice, ctd.Low);
            tdvm.Volume = Math.Round((ctd.Volume / 1000000), 2);
            tdvm.Close = ctd.Close;
            tdvm.Low = lowestPrice;
            tdvm.High = highestPrice;
            tdvm.Price = ctd.Price;
            if (stockChartBindingData.Count > 0)
                stockChartBindingData[stockChartBindingData.Count - 1] = tdvm;
            else
                stockChartBindingData.Add(tdvm);
        }
        void UpdateTransactionBindingData() {
            TryResetCurrentDate();
            if (stockChartBindingData.Count < 1) return;
            List<TransactionData> transactions = model.GetTransactions(stockChartBindingData[stockChartBindingData.Count - 1].Price);
            SetTransactionGridBindingData(transactions);
            IsLoading = false;
            OnPropertyChanged("IsLoading");
        }
        void SetTransactionGridBindingData(List<TransactionData> transactions) {
            transactionGridBindingData.Clear();
            transactionGridBindingData.BeginUpdate();
            foreach (TransactionData tdvm in transactions) {
                transactionGridBindingData.Add(tdvm);
            }
            transactionGridBindingData.EndUpdate();
            CurrentPriceIndex = model.CurrentPriceIndex;
            RaiseCurrentPriceIndexChanged();
        }
        void RaiseCurrentPriceIndexChanged() {
            if (currentPriceIndexChanged != null)
                currentPriceIndexChanged(this, EventArgs.Empty);
        }
        void SetSelectedCompany() {
            StopTimer();
            int delta = currentDate - candlesCount * totalTicks;
            currentDate = delta < 0 ? 0 : delta;
            UpdateAllBindingData(true);
        }
        void InitProperties() {
            TryResetCurrentDate();
            isAllBindingDataUpdate = true;
            IsLoading = true;
            model.ClearTransactions();
            OnPropertyChanged("IsLoading");
        }
        double CalcIncrease(string company, ref double delta) {
            var companyData = watchLisBindingData.Where(c => c.CompanyName == company).Select(c => c).FirstOrDefault();
            var oldCompanyData = oldWatchListData.Where(c => c.CompanyName == company).Select(c => c).FirstOrDefault();
            if (companyData != null && oldCompanyData != null) {
                double newPrice = companyData.Price;
                double oldPrice = oldCompanyData.Price;
                delta = newPrice - oldPrice;
                return Math.Round(delta / newPrice, 3);
            }
            return 0;
        }
        CompanyTradingData GetCompanyTradingData(StockData newData, DateTime current) {
            CompanyTradingData ctd = new CompanyTradingData(newData, "");
            return ctd;
        }
        DateTime UpdateDate(DateTime startDate, bool add) {
            DateTime returnDate = new DateTime();
            switch (totalTicks) {
                case 1:
                    if (add) startDate = startDate.AddDays(1);
                    if (!add) returnDate = startDate.AddDays(-1);
                    break;
                case 5:
                    if (add) startDate = startDate.AddDays(7);
                    if (!add) returnDate = startDate.AddDays(-7);
                    break;
                case 10:
                    if (add) startDate = startDate.AddDays(14);
                    if (!add) returnDate = startDate.AddDays(-14);
                    break;
                case 20:
                    if (add) startDate = startDate.AddMonths(1);
                    if (!add) returnDate = startDate.AddMonths(-1);
                    break;
            }
            if (add) return startDate;
            return returnDate;
        }
        Delegate GetDefferedDelegate(string key) {
            if (defferedUpdate.ContainsKey(key) && defferedUpdate[key].Count != 0)
                return defferedUpdate[key].Dequeue();
            return null;

        }
        List<CompaniesVolumeData> GetTopThreeVolume() {
            List<CompaniesVolumeData> result = new List<CompaniesVolumeData>();
            if (volumeChartBindingData != null && volumeChartBindingData.Count > 0) {
                for (int i = 0; i < 3; i++)
                    if (volumeChartBindingData.Count >= i + 1)
                        result.Add(volumeChartBindingData[i]);
            }
            return result;
        }
        LockableCollection<TradingDataViewModel> CreateVolumeDynamicsBindingData(StockData[] data) {
            LockableCollection<TradingDataViewModel> result = new LockableCollection<TradingDataViewModel>();
            foreach (StockData currentData in data) {
                CompanyTradingData ctd = new CompanyTradingData(currentData, "");
                ctd.Close = double.Parse(currentData.CloseP.ToString());
                ctd.Volume = Math.Round(((double)ctd.Volume / 1000000), 2);
                ctd.Low = double.Parse(currentData.LowP.ToString());
                ctd.High = double.Parse(currentData.HighP.ToString());
                result.Add(new TradingDataViewModel(ctd));
            }
            return result;
        }
        public void OnCandlesCountChanged() {
            OnCandlesCountChangedCallBack();
        }
        public void SetTicks(int numberOfTicks) {
            Ticks = numberOfTicks;
            countOfWeek = 1;
        }
    }
}
