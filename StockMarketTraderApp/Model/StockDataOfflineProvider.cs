using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Xml;
using DevExpress.StockMarketTrader.StockDataServiceReference;

namespace DevExpress.StockMarketTrader.Model.Offline {
    public class Company {
        public int ID { get; set; }
        public string CompanyName { get; set; }

        public Company() {
        }
    }

    public class OfflineStockData {
        public double CloseP { get; set; }
        public double HighP { get; set; }
        public double LowP { get; set; }
        public double OpenP { get; set; }
        public double Price { get; set; }
        public int CompanyID { get; set; }
        public int Volume { get; set; }
        public DateTime Date { get; set; }

        public OfflineStockData() {
        }
    }

    public class XmlStockDataProvider {
        const string companiesPath = "DevExpress.StockMarketTrader.Data.Companies.xml";
        const string dataPath = "DevExpress.StockMarketTrader.Data.StockData.xml";

        static List<Company> companies;
        static List<OfflineStockData> stockData;

        static XmlStockDataProvider() {
            PopulateCompanies();
            PopulateStockData();
        }
        static void PopulateStockData() {
            Stream stream = GetResourceStream(dataPath);
            if (stream != null) {
                stockData = new List<OfflineStockData>();
                XmlDocument doc = new XmlDocument();
                doc.Load(stream);
                var nodes = doc.LastChild.SelectNodes("//StockData");
                foreach (XmlNode node in nodes) {
                    var data = new OfflineStockData() {
                        CompanyID = Int32.Parse(node.Attributes["Name"].Value),
                        Date = DateTime.Parse(node.Attributes["Date"].Value, CultureInfo.InvariantCulture),
                        Price = Double.Parse(node.Attributes["Price"].Value, CultureInfo.InvariantCulture),
                        OpenP = Double.Parse(node.Attributes["Open"].Value, CultureInfo.InvariantCulture),
                        CloseP = Double.Parse(node.Attributes["Close"].Value, CultureInfo.InvariantCulture),
                        HighP = Double.Parse(node.Attributes["High"].Value, CultureInfo.InvariantCulture),
                        LowP = Double.Parse(node.Attributes["Low"].Value, CultureInfo.InvariantCulture),
                        Volume = int.Parse(node.Attributes["Volume"].Value, CultureInfo.InvariantCulture),
                    };
                    stockData.Add(data);
                }
            }
            stream.Close();
        }
        static void PopulateCompanies() {
            Stream stream = GetResourceStream(companiesPath);
            if (stream != null) {
                XmlDocument doc = new XmlDocument();
                doc.Load(stream);
                var nodes = doc.LastChild.SelectNodes("//Company");
                companies = new List<Company>();
                foreach (XmlNode node in nodes) {
                    companies.Add(new Company() { ID = Int32.Parse(node.Attributes["Id"].Value), CompanyName = node.Attributes["Name"].Value });
                }
                stream.Close();
            }
           
        }
        static Stream GetResourceStream(string path) {
            return Assembly.GetExecutingAssembly().GetManifestResourceStream(path);
        }

        public List<Company> Companies { get { return companies; } }
        public List<OfflineStockData> StockData { get { return stockData; } }
    }

    public class StockDataOfflineService :/* ClientBase<IStockDataService>,*/ IStockDataService {
        static DateTime[] dates;

        readonly XmlStockDataProvider dataProvider;
        readonly Dictionary<IAsyncResult, Delegate> executions;
        readonly List<string> sem = new List<string>();

        public StockDataOfflineService() {
            dataProvider = new XmlStockDataProvider();
            executions = new Dictionary<IAsyncResult, Delegate>();
        }
        #region IStockDataService Members
        string IStockDataService.Test() {
            return string.Empty;
        }
        void IStockDataService.Initialize() {
            throw new NotImplementedException();
        }
        void StockDataServiceReference.IStockDataService.EndInitialize(IAsyncResult result) {
            throw new NotImplementedException();
        }
        int[] IStockDataService.GetTopRatedCompanyIDs(DateTime date) {
            throw new NotImplementedException();
        }
        int[] IStockDataService.EndGetTopRatedCompanyIDs(IAsyncResult result) {
            throw new NotImplementedException();
        }
        double IStockDataService.GetHighestPrice(string companyName, DateTime start, DateTime end) {
            throw new NotImplementedException();
        }
        double IStockDataService.EndGetHighestPrice(IAsyncResult result) {
            throw new NotImplementedException();
        }
        double IStockDataService.GetLowestPrice(string companyName, DateTime start, DateTime end) {
            throw new NotImplementedException();
        }
        double IStockDataService.EndGetLowestPrice(IAsyncResult result) {
            throw new NotImplementedException();
        }
        string IStockDataService.EndTest(IAsyncResult result) {
            throw new NotImplementedException();
        }
        StockData[] IStockDataService.GetAllPeriodData(string companyName) {
            throw new NotImplementedException();
        }
        StockData[] IStockDataService.EndGetCompanyStockDataSL(IAsyncResult result) {
            throw new NotImplementedException();
        }
        StockData[] IStockDataService.EndGetAllPeriodData(IAsyncResult result) {
            throw new NotImplementedException();
        }
        StockData[] IStockDataService.GetCompanyStockDataSL(DateTime newDate, DateTime oldDate, string companyName) {
            throw new NotImplementedException();
        }
        IAsyncResult IStockDataService.BeginInitialize(AsyncCallback callback, object asyncState) {
            throw new NotImplementedException();
        }
        IAsyncResult IStockDataService.BeginTest(AsyncCallback callback, object asyncState) {
            throw new NotImplementedException();
        }
        IAsyncResult IStockDataService.BeginGetAllPeriodData(string companyName, AsyncCallback callback, object asyncState) {
            throw new NotImplementedException();
        }
        IAsyncResult IStockDataService.BeginGetCompanyStockDataSL(DateTime newDate, DateTime oldDate, string companyName, AsyncCallback callback, object asyncState) {
            throw new NotImplementedException();
        }
        IAsyncResult IStockDataService.BeginGetHighestPrice(string companyName, DateTime start, DateTime end, AsyncCallback callback, object asyncState) {
            throw new NotImplementedException();
        }
        IAsyncResult IStockDataService.BeginGetLowestPrice(string companyName, DateTime start, DateTime end, AsyncCallback callback, object asyncState) {
            throw new NotImplementedException();
        }
        IAsyncResult IStockDataService.BeginGetTopRatedCompanyIDs(DateTime date, AsyncCallback callback, object asyncState) {
            throw new NotImplementedException();
        }
        IAsyncResult IStockDataService.BeginGetTopRatedCompaniesDataSL(DateTime start, DateTime end, string selectedCompany, AsyncCallback callback, object asyncState) {
            throw new NotImplementedException();
        }
        IAsyncResult IStockDataService.BeginGetCompanyData(DateTime newDate, DateTime oldDate, string companyName, AsyncCallback callback, object asyncState) {
            throw new NotImplementedException();
        }
        CompanyData IStockDataService.GetCompanyData(DateTime newDate, DateTime oldDate, string companyName) {
            throw new NotImplementedException();
        }
        CompanyData IStockDataService.EndGetCompanyData(IAsyncResult result) {
            throw new NotImplementedException();
        }
        TopRatedCompanyData[] IStockDataService.GetTopRatedCompaniesDataSL(DateTime start, DateTime end, string selectedCompany) {
            throw new NotImplementedException();
        }
        TopRatedCompanyData[] IStockDataService.EndGetTopRatedCompaniesDataSL(IAsyncResult result) {
            throw new NotImplementedException();
        }
        #endregion
        void AddExecution(Delegate d, IAsyncResult result) {
            executions.Add(result, d);
        }
        void RemoveExecution(IAsyncResult result) {
            executions.Remove(result);
        }
        string GetCompanyNameByID(int id) {
            lock (sem) {
                return GetCompanies().Where(e => e.ID == id).Select(e => e.CompanyName).ToArray()[0];
            }
        }
        double GetHighLowPriceBetweenDates(OfflineStockData[] data, DateTime start, DateTime end, string companyName, bool isMax) {
            int id = GetCompanyID(companyName);
            if (isMax)
                return (double)data.Where(e => e.Date >= start && e.Date <= end && e.CompanyID == id).Select(e => e.HighP).Max();
            else
                return (double)data.Where(e => e.Date >= start && e.Date <= end && e.CompanyID == id).Select(e => e.LowP).Min();
        }
        int GetCompanyID(string companyName) {
            lock (sem) {
                return GetCompanies().Where(e => e.CompanyName == companyName).Select(e => e.ID).ToList().FirstOrDefault();
            }
        }
        int[] GetTopRatedCompanyIDs(DateTime date) {
            IOrderedEnumerable<OfflineStockData> data = GetStockDataByDate2(date).OrderByDescending((e => e.Volume));
            int[] ids = data.Select(e => e.CompanyID).ToArray();
            int[] result = new int[ids.Length];
            for (int i = 0; i < result.Length; i++) {
                result[i] = ids[i];
            }
            return result;
        }
        Delegate GetExecution(IAsyncResult result) {
            return executions[result];
        }
        StockData GetServiceStockData(OfflineStockData data) {
            return new StockData() {
                CompanyID = data.CompanyID,
                Date = data.Date,
                Price = Convert.ToDecimal(data.Price),
                OpenP = Convert.ToDecimal(data.OpenP),
                CloseP = Convert.ToDecimal(data.CloseP),
                HighP = Convert.ToDecimal(data.HighP),
                LowP = Convert.ToDecimal(data.LowP),
                Volumne = data.Volume
            };
        }
        OfflineStockData[] GetMultipleCompanyStockData(List<DateTime> datesList, string companyName) {
            int id = GetCompanyID(companyName);
            return GetStockData().Where(e => e.CompanyID == id && datesList.Contains(e.Date)).Select(e => e).OrderBy(e => e.Date).ToArray();
        }
        OfflineStockData[] GetStockDataByDate2(DateTime currentDate) {
            List<OfflineStockData> data = GetStockData();
            OfflineStockData[] result = data.Where(e => e.Date == currentDate).OrderBy(e => e.CompanyID).ToArray();
            return result;
        }
        public string[] GetCompaniesName() {
            lock (sem) {
                return GetCompanies().Select(e => e.CompanyName).ToArray();
            }
        }
        public string[] EndGetCompaniesName(IAsyncResult result) {
            var endResult = ((Func<string[]>)GetExecution(result)).EndInvoke(result);
            RemoveExecution(result);
            return endResult;
        }
        public IAsyncResult BeginGetCompanyMultipleDataFromPeriod(int currentDate, int count, int periodSize, string companyName, AsyncCallback callback, object asyncState) {
            Func<int, int, int, string, CompanyData[]> f = new Func<int, int, int, string, CompanyData[]>(GetCompanyMultipleDataFromPeriod);
            var result = f.BeginInvoke(currentDate, count, periodSize, companyName, callback, asyncState);
            AddExecution(f, result);
            return result;
        }
        public IAsyncResult BeginGetStockDataFromPeriodByCompanyList(int currentDate, int count, int periodSize, string[] companies, AsyncCallback callback, object asyncState) {
            Func<int, int, int, string[], CompanyStockData[]> f = new Func<int, int, int, string[], CompanyStockData[]>(GetStockDataFromPeriodByCompanyList);
            var result = f.BeginInvoke(currentDate, count, periodSize, companies, callback, asyncState);
            AddExecution(f, result);
            return result;
        }
        public IAsyncResult BeginGetStockDataFromDateByCompanyList(DateTime date, string[] companies, AsyncCallback callback, object asyncState) {
            Func<DateTime, string[], StockDataServiceReference.CompanyStockData[]> f = new Func<DateTime, string[], StockDataServiceReference.CompanyStockData[]>(GetStockDataFromDateByCompanyList);
            var result = f.BeginInvoke(date, companies, callback, asyncState);
            AddExecution(f, result);
            return result;
        }
        public IAsyncResult BeginGetDates(AsyncCallback callback, object asyncState) {
            Func<DateTime[]> f = new Func<DateTime[]>(GetDates);
            var result = f.BeginInvoke(callback, asyncState);
            AddExecution(f, result);
            return result;
        }
        public IAsyncResult BeginGetStockDataByDate(DateTime currentDate, AsyncCallback callback, object asyncState) {
            Func<DateTime, StockData[]> f = new Func<DateTime, StockData[]>(GetStockDataByDate);
            var result = f.BeginInvoke(currentDate, callback, asyncState);
            AddExecution(f, result);
            return result;
        }
        public IAsyncResult BeginGetCompaniesName(AsyncCallback callback, object asyncState) {
            Func<string[]> f = new Func<string[]>(GetCompaniesName);
            var result = f.BeginInvoke(callback, asyncState);
            AddExecution(f, result);
            return result;
        }
        public IAsyncResult BeginGetCompanyStockData(DateTime date, string companyName, AsyncCallback callback, object asyncState) {
            Func<DateTime, string, StockData[]> f = new Func<DateTime, string, StockData[]>(GetCompanyStockData);
            var result = f.BeginInvoke(date, companyName, callback, asyncState);
            AddExecution(f, result);
            return result;
        }
        public IAsyncResult BeginGetCompaniesVolumeFromPeriod(DateTime start, DateTime end, AsyncCallback callback, object asyncState) {
            Func<DateTime, DateTime, CompaniesVolumeData[]> f = new Func<DateTime, DateTime, CompaniesVolumeData[]>(GetCompaniesVolumeFromPeriod);
            var result = f.BeginInvoke(start, end, callback, asyncState);
            AddExecution(f, result);
            return result;
        }
        public CompanyData[] GetCompanyMultipleDataFromPeriod(int currentDate, int count, int periodSize, string companyName) {
            lock (sem) {
                List<DateTime> datesList = new List<DateTime>();
                int dateCount = currentDate;
                for (int i = 0; i < (count + 1) * periodSize; i++) {
                    if (dateCount < dates.Length) {
                        datesList.Add(dates[dateCount]);
                        dateCount++;
                    }
                }
                OfflineStockData[] data = GetMultipleCompanyStockData(datesList, companyName);
                List<CompanyData> result = new List<CompanyData>();
                for (int i = 0; i < count; i++) {
                    DateTime nextDate = datesList[(i + 1) * periodSize];
                    double closePrice = (double)data[(i + 1) * periodSize].CloseP;
                    double highPrice = GetHighLowPriceBetweenDates(data, dates[currentDate], dates[currentDate + periodSize], companyName, true);
                    double lowPrice = GetHighLowPriceBetweenDates(data, dates[currentDate], dates[currentDate + periodSize], companyName, false);
                    currentDate += periodSize;
                    result.Add(new CompanyData() { Data = GetServiceStockData(data[i * periodSize]), HighPrice = highPrice, LowPrice = lowPrice, ClosePrice = closePrice });
                }
                return result.ToArray();
            }
        }
        public CompanyData[] EndGetCompanyMultipleDataFromPeriod(IAsyncResult result) {
            var endResult = ((Func<int, int, int, string, CompanyData[]>)GetExecution(result)).EndInvoke(result);
            RemoveExecution(result);
            return endResult;
        }
        public CompanyStockData[] GetStockDataFromPeriodByCompanyList(int currentDate, int count, int periodSize, string[] companies) {
            lock(sem) {
                List<CompanyStockData> result = new List<CompanyStockData>();
                foreach (string company in companies)
                {
                    var data = GetCompanyMultipleDataFromPeriod(currentDate, count, periodSize, company);
                    if (data != null)
                        result.Add(new CompanyStockData() { Data = data.Select(d => d.Data).ToArray(), CompanyName = company });
                }
                return result.ToArray();
            }
        }
        public CompanyStockData[] EndGetStockDataFromPeriodByCompanyList(IAsyncResult result) {
            var endResult = ((Func<int, int, int, string[], CompanyStockData[]>)GetExecution(result)).EndInvoke(result);
            RemoveExecution(result);
            return endResult;
        }
        public CompanyStockData[] GetStockDataFromDateByCompanyList(DateTime date, string[] companies) {
            lock(sem) {
                List<CompanyStockData> result = new List<CompanyStockData>();
                foreach(string company in companies) {
                    StockData[] data = ((IStockDataService)this).GetCompanyStockData(date, company);
                    result.Add(new CompanyStockData() { Data = data, CompanyName = company });
                }
                return result.ToArray();
            }
        }
        public CompanyStockData[] EndGetStockDataFromDateByCompanyList(IAsyncResult result) {
            var endResult = ((Func<DateTime, string[], StockDataServiceReference.CompanyStockData[]>)GetExecution(result)).EndInvoke(result);
            RemoveExecution(result);
            return endResult;
        }
        public List<Company> GetCompanies() {
            return dataProvider.Companies;
        }
        public List<OfflineStockData> GetStockData() {
            return dataProvider.StockData;
        }
        public DateTime[] GetDates() {
            if (dates == null || dates.Length == 0) {
                lock (sem) {
                    dates = GetStockData().Select(e => e.Date).Distinct().OrderBy(e => e.Date).ToArray();
                }
            }
            return dates;
        }
        public DateTime[] EndGetDates(IAsyncResult result) {
            var endResult = ((Func<DateTime[]>)executions[result]).EndInvoke(result);
            RemoveExecution(result);
            return endResult;
        }
        public StockData[] GetStockDataByDate(DateTime currentDate) {
            lock (sem) {
                StockData[] result = GetStockData().Where(e => e.Date == currentDate).OrderBy(e => e.CompanyID).Select(e => GetServiceStockData(e)).ToArray();
                return result;
            }
        }
        public StockData[] EndGetStockDataByDate(IAsyncResult result) {
            var endResult = ((Func<DateTime, StockData[]>)GetExecution(result)).EndInvoke(result);
            RemoveExecution(result);
            return endResult;
        }
        public StockData[] GetCompanyStockData(DateTime date, string companyName) {
            lock (sem) {
                int id = GetCompanyID(companyName);
                return GetStockData().Where(e => e.CompanyID == id && e.Date == date).Select(e => GetServiceStockData(e)).ToArray();
            }
        }
        public StockData[] EndGetCompanyStockData(IAsyncResult result) {
            var endresult = ((Func<DateTime, string, StockData[]>)GetExecution(result)).EndInvoke(result);
            RemoveExecution(result);
            return endresult;
        }
        public CompaniesVolumeData[] GetCompaniesVolumeFromPeriod(DateTime start, DateTime end) {
            lock (sem) {
                int[] topIds = GetTopRatedCompanyIDs(start);
                CompaniesVolumeData[] result = new CompaniesVolumeData[topIds.Length];
                for (int i = 0; i < topIds.Length; i++) {
                    int volume = GetStockData().Where(e => e.Date >= start && e.CompanyID == topIds[i]).Select(e => e.Volume).ToArray()[0];
                    CompaniesVolumeData data = new CompaniesVolumeData() { CompanyName = GetCompanyNameByID(topIds[i]), Volume = (int)volume };
                    result[i] = data;
                }
                return result;
            }
        }
        public CompaniesVolumeData[] EndGetCompaniesVolumeFromPeriod(IAsyncResult result) {
            var endResult = ((Func<DateTime, DateTime, CompaniesVolumeData[]>)GetExecution(result)).EndInvoke(result);
            RemoveExecution(result);
            return endResult;
        }
    }
}
