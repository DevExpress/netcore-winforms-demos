using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DevExpress.DevAV {
    public class SaleSummaryInfo {
        public DateTime OrderDate { get; set; }
        public string InvoiceNumber { get; set; }
        public int ProductUnits { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public long StoreId { get; set; }
        public string StoreCity { get; set; }
        public string StoreCustomerName { get; set; }
    }

    public class SaleAnalisysInfo {
        public DateTime OrderDate { get; set; }
        public decimal ProductCost { get; set; }
        public int ProductUnits { get; set; }
        public decimal Total { get; set; }
    }

    public class CustomerSaleDetailOrderItemInfo {
        public long OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string InvoiceNumber { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public string PONumber { get; set; }
        public long StoreId { get; set; }
        public string StoreCity { get; set; }
        public string EmployeeFullName { get; set; }
        public decimal ShippingAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerFax { get; set; }
        public byte[] CustomerLogo { get; set; }
        Image img = null;
        public Image CustomerImage { get { return img ?? (img = Customer.CreateImage(CustomerLogo)); } }

        public decimal Discount { get; set; }
        public int ProductUnits { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal Total { get; set; }

        public string CustomerHomeOfficeLine { get; set; }
        public string CustomerHomeOfficeCity { get; set; }
        public StateEnum CustomerHomeOfficeState { get; set; }
        public string CustomerHomeOfficeZipCode { get; set; }
        public string CustomerHomeOfficeCityLine { get { return Address.GetCityLine(CustomerHomeOfficeCity, CustomerHomeOfficeState, CustomerHomeOfficeZipCode); } }

        public string CustomerBillingAddressLine { get; set; }
        public string CustomerBillingAddressCity { get; set; }
        public StateEnum CustomerBillingAddressState { get; set; }
        public string CustomerBillingAddressZipCode { get; set; }
        public string CustomerBillingAddressCityLine { get { return Address.GetCityLine(CustomerBillingAddressCity, CustomerBillingAddressState, CustomerBillingAddressZipCode); } }
    }
    public class CustomerSaleDetailOrderInfo {
        public CustomerSaleDetailOrderItemInfo[] OrderItems { get; set; }

        public long OrderId { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public DateTime OrderDate { get; set; }
        public string InvoiceNumber { get; set; }
        public string PONumber { get; set; }
        public long StoreId { get; set; }
        public string StoreCity { get; set; }
        public string EmployeeFullName { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerFax { get; set; }
        public Image CustomerImage { get; set; }
        public decimal ShippingAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public string CustomerHomeOfficeLine { get; set; }
        public string CustomerHomeOfficeCityLine { get; set; }
        public string CustomerBillingAddressLine { get; set; }
        public string CustomerBillingAddressCityLine { get; set; }
    }
    public class QuoteInfo {
        public long Id { get; set; }
        public StateEnum State { get; set; }
        public string City { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public double Opportunity { get; set; }
        public decimal MoneyOpportunity { get { return Total * (decimal)Opportunity; } }
        public decimal Percentage { get { return 100M * (decimal)Opportunity; } }
    }
    public class OrderInfo {
        public string InvoiceNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string Company { get; set; }
        public string Store { get; set; }
        public decimal TotalAmount { get; set; }
    }
    public class SalesProductInfo {
        public string Name { get; set; }
        public decimal Value { get; set; }
    }

    public class SalesInfo {
        public string Caption { get; set; }
        public List<SalesProductInfo> ListProductInfo { get; set; }
        public DateTime time { get; set; }
        public SalesInfo() {
            ListProductInfo = new List<SalesProductInfo>();
        }
    }
    public class ProductInfoWithSales {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public decimal SalePrice { get; set; }
        public decimal RetailPrice { get; set; }
        public int? CurrentInventory { get; set; }
        public int Backorder { get; set; }
        public IEnumerable<double> MonthlySales { get; set; }
        public decimal? TotalSales { get; set; }
    }
    public class CustomerInfoWithSales {
        public long Id { get; set; }
        public string Name { get; set; }
        public string HomeOfficeLine { get; set; }
        public string HomeOfficeCity { get; set; }
        public StateEnum HomeOfficeState { get; set; }
        public string HomeOfficeZipCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public decimal? TotalSales { get; set; }

        Lazy<IEnumerable<CustomerStore>> customerStores;
        public IEnumerable<CustomerStore> CustomerStores { get { return customerStores.Value; } }
        Lazy<IEnumerable<CustomerEmployee>> customerEmployees;
        public IEnumerable<CustomerEmployee> Employees { get { return customerEmployees.Value; } }
        public IEnumerable<decimal> MonthlySales { get; private set; }
        public void Init(Func<IEnumerable<CustomerStore>> getStores, Func<IEnumerable<CustomerEmployee>> getEmployees, IEnumerable<decimal> monthlySales) {
            this.customerStores = new Lazy<IEnumerable<CustomerStore>>(getStores);
            this.customerEmployees = new Lazy<IEnumerable<CustomerEmployee>>(getEmployees);
            this.MonthlySales = monthlySales;
        }
    }
    public class MapItem {
        public Address Address { get; set; }
        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public decimal Total { get; set; }
        public string City { get { return Address.City; } }
        public double Latitude { get { return Address.Latitude; } }
        public double Longitude { get { return Address.Longitude; } }
        public string CustomerName { get { return Customer.Name; } }
        public string ProductName { get { return Product.Name; } }
        public ProductCategory ProductCategory { get { return Product.Category; } }
    }
    public class QuoteMapItem {
        public Address Address { get; set; }
        public Stage Stage { get; set; }
        public DateTime Date { get; set; }
        public string City { get { return Address.City; } }
        public double Latitude { get { return Address.Latitude; } }
        public double Longitude { get { return Address.Longitude; } }
        public string Name { get { return Enum.GetName(typeof(Stage), Stage); } }
        public int Index { get { return (int)Stage; } }
        public decimal Value { get; set; }
    }
    public enum Stage {
        High,
        Medium,
        Low,
        Unlikely,
        Summary
    }
    public class SalesSummaryItem {
        public ProductCategory Category { get; set; }
        public decimal Sales { get; set; }
    }
    public class QuoteSummaryItem {
        public string StageName { get; set; }
        public decimal Summary { get; set; }
    }
    public class CostAverageItem {
        public ProductCategory Category { get; set; }
        public decimal Cost { get; set; }
    }
    public static class QueriesHelper {
        public static IQueryable<Order> ActualOrders(this IQueryable<Order> orders) {
            var actualDateTime = DateTime.Now.AddHours(0.5);
            return orders.Where(x => x.OrderDate <= actualDateTime);
        }
        public static IQueryable<Quote> ActualQuotes(this IQueryable<Quote> quotes) {
            var actualDateTime = DateTime.Now.AddHours(0.5);
            return quotes.Where(x => x.Date <= actualDateTime);
        }
        public static IQueryable<QuoteInfo> GetQuoteInfo(IQueryable<Quote> quotes) {
            return quotes.ActualQuotes().Select(x => new QuoteInfo {
                Id = x.Id,
                State = x.CustomerStore.Address.State,
                City = x.CustomerStore.Address.City,
                Date = x.Date,
                Total = x.Total,
                Opportunity = x.Opportunity,
            });
        }
        public static decimal CustomSum<T>(this IEnumerable<T> query, Expression<Func<T, decimal>> selector) {
            return query.AsQueryable<T>().Select(selector).DefaultIfEmpty(0).Sum();
        }
        public static IEnumerable<CustomerSaleDetailOrderInfo> GetCustomerSaleDetails(long customerId, IQueryable<OrderItem> orderItems) {
            List<CustomerSaleDetailOrderItemInfo> detailInfo = GetCustomerSaleOrderItemDetails(customerId, orderItems);
            return detailInfo
                .GroupBy(x => x.OrderId)
                .Select(x => new CustomerSaleDetailOrderInfo() {
                    OrderId = x.Key,
                    OrderItems = x.ToArray(),
                    ProductCategory = x.First().ProductCategory,
                    OrderDate = x.First().OrderDate,
                    InvoiceNumber = x.First().InvoiceNumber,
                    PONumber = x.First().PONumber,
                    StoreCity = x.First().StoreCity,
                    StoreId = x.First().StoreId,
                    EmployeeFullName = x.First().EmployeeFullName,
                    CustomerName = x.First().CustomerName,
                    CustomerPhone = x.First().CustomerPhone,
                    CustomerFax = x.First().CustomerFax,
                    CustomerImage = x.First().CustomerImage,
                    ShippingAmount = x.First().ShippingAmount,
                    TotalAmount = x.First().TotalAmount,
                    CustomerHomeOfficeLine = x.First().CustomerHomeOfficeLine,
                    CustomerHomeOfficeCityLine = x.First().CustomerHomeOfficeCityLine,
                    CustomerBillingAddressLine = x.First().CustomerBillingAddressLine,
                    CustomerBillingAddressCityLine = x.First().CustomerBillingAddressCityLine
                }).ToArray();
        }
        public static List<CustomerSaleDetailOrderItemInfo> GetCustomerSaleOrderItemDetails(long customerId, IQueryable<OrderItem> orderItems) {
            return orderItems
                .Where(x => x.Order.CustomerId == customerId)
                .Select(x => new CustomerSaleDetailOrderItemInfo() {
                    ProductCategory = x.Product.Category,
                    OrderDate = x.Order.OrderDate,
                    OrderId = x.OrderId.Value,
                    InvoiceNumber = x.Order.InvoiceNumber,
                    PONumber = x.Order.PONumber,
                    StoreId = x.Order.Store.Id,
                    StoreCity = x.Order.Store.Address.City,
                    EmployeeFullName = x.Order.Employee.FullName,
                    CustomerName = x.Order.Customer.Name,
                    CustomerPhone = x.Order.Customer.Phone,
                    CustomerFax = x.Order.Customer.Fax,
                    CustomerLogo = x.Order.Customer.Logo,

                    CustomerHomeOfficeLine = x.Order.Customer.HomeOffice.Line,
                    CustomerHomeOfficeCity = x.Order.Customer.HomeOffice.City,
                    CustomerHomeOfficeZipCode = x.Order.Customer.HomeOffice.ZipCode,
                    CustomerHomeOfficeState = x.Order.Customer.HomeOffice.State,
                    CustomerBillingAddressLine = x.Order.Customer.BillingAddress.Line,
                    CustomerBillingAddressCity = x.Order.Customer.BillingAddress.City,
                    CustomerBillingAddressZipCode = x.Order.Customer.BillingAddress.ZipCode,
                    CustomerBillingAddressState = x.Order.Customer.BillingAddress.State,

                    Total = x.Total,
                    TotalAmount = x.Order.TotalAmount,
                    Discount = x.Discount,
                    ProductUnits = x.ProductUnits,
                    ProductPrice = x.ProductPrice,
                    ShippingAmount = x.Order.ShippingAmount,
                }).ToList();
        }

        public static IEnumerable<SaleSummaryInfo> GetSaleSummaries(IQueryable<OrderItem> orderItems) {
            return orderItems.Select(x => new SaleSummaryInfo() {
                OrderDate = x.Order.OrderDate,
                InvoiceNumber = x.Order.InvoiceNumber,
                ProductUnits = x.ProductUnits,
                ProductPrice = x.ProductPrice,
                Discount = x.Discount,
                Total = x.Total,
                ProductCategory = x.Product.Category,
                StoreId = x.Order.Store.Id,
                StoreCity = x.Order.Store.Address.City,
                StoreCustomerName = x.Order.Store.Customer.Name,
            }).ToList();
        }
        public static IEnumerable<SaleAnalisysInfo> GetSaleAnalysis(IQueryable<OrderItem> orderItems) {
            return orderItems.Select(x => new SaleAnalisysInfo() {
                OrderDate = x.Order.OrderDate,
                ProductCost = x.Product.Cost,
                ProductUnits = x.ProductUnits,
                Total = x.Total,
            }).ToList();
        }
        public static IEnumerable<string> GetStateNames(IQueryable<State> queryableStates, IEnumerable<StateEnum> states) {
            return
                from ss in queryableStates
                join s in states on ss.ShortName equals s
                select ss.LongName;
        }
        public static IList<OrderInfo> GetOrderInfo(IQueryable<Order> orders) {
            return orders.ActualOrders().Select(x => new OrderInfo {
                InvoiceNumber = x.InvoiceNumber,
                OrderDate = x.OrderDate,
                Company = x.Customer.Name,
                //Store = x.Customer.HomeOffice.City,
                TotalAmount = x.TotalAmount,
            }).ToList();
        }
        public static List<Order> GetAverageOrders(IQueryable<Order> orders, int NumberOfPoints) {
            DateTime startDate = orders.Min(q => q.OrderDate);
            DateTime endDate = orders.Max(q => q.OrderDate);
            int daysPerGroup = Math.Max(1, (endDate - startDate).Days / NumberOfPoints);
            var constDate = new DateTime(1990, 1, 1);
            List<decimal> groups = orders
                .Select(x => new { OrderDate = x.OrderDate, TotalAmount = x.TotalAmount })
                .ToList()
                .GroupBy(q => (q.OrderDate - constDate).Days / daysPerGroup)
                .Select(g => g.Average(q => q.TotalAmount))
                .ToList();
            DateTime currentDate = startDate;
            List<Order> averageOrders = new List<Order>();
            foreach(decimal total in groups) {
                averageOrders.Add(new Order { OrderDate = currentDate, TotalAmount = total });
                currentDate = currentDate.AddDays(daysPerGroup);
            }
            return averageOrders;
        }

        public static List<Quote> GetAverageQuotes(IQueryable<Quote> quotes, int NumberOfPoints) {
            var startDate = quotes.Min(q => q.Date);
            var endDate = quotes.Max(q => q.Date);
            int daysPerGroup = Math.Max(1, (endDate - startDate).Days / NumberOfPoints);
            var constDate = new DateTime(1990, 1, 1);
            List<decimal> groups = quotes
                .Select(x => new { Date = x.Date, Total = x.Total })
                .ToList()
                .GroupBy(q => (q.Date - constDate).Days / daysPerGroup)
                .Select(g => g.Average(q => q.Total))
                .ToList();
            DateTime currentDate = startDate;
            List<Quote> averageQuotes = new List<Quote>();
            foreach(decimal total in groups) {
                averageQuotes.Add(new Quote { Date = currentDate, Total = total });
                currentDate = currentDate.AddDays(daysPerGroup);
            }
            return averageQuotes;
        }

        public static List<SalesInfo> GetSales(IQueryable<OrderItem> orderItems) {
            var result = orderItems
                .Select(x => new { OrderDate = x.Order.OrderDate, ProductCategory = x.Product.Category, Total = x.Total })
                .OrderBy(x => x.OrderDate)
                .ToList()
                .GroupBy(x => x.OrderDate.Year)
                .Select(x => new SalesInfo() {
                    time = new DateTime(x.Key, 1, 1),
                    Caption = "Sales (FY" + x.Key + ")",
                    ListProductInfo = x
                        .GroupBy(y => y.ProductCategory)
                        .Select(y => new SalesProductInfo() {
                            Name = y.Key.ToString(),
                            Value = y.Sum(z => z.Total)
                        })
                        .ToList()
                }).ToList();

            return result;
        }
        public static IQueryable<ProductInfoWithSales> GetProductInfoWithSales(IQueryable<Product> products) {
            return products.Select(x => new ProductInfoWithSales {
                Id = x.Id,
                Name = x.Name,
                Cost = x.Cost,
                RetailPrice = x.RetailPrice,
                SalePrice = x.SalePrice,
                CurrentInventory = x.CurrentInventory,
                Backorder = x.Backorder,
                TotalSales = x.OrderItems.Sum(orderItem => orderItem.Total)
            });
        }
        public static void UpdateMonthlySales(IQueryable<OrderItem> orderItems, IEnumerable<ProductInfoWithSales> products) {
            foreach(var productInfo in products) {
                var sales = orderItems
                    .Where(x => x.Product.Id == productInfo.Id)
                    .GroupBy(x => x.Order.OrderDate.Month)
                    .Select(x => new { Month = x.Key, Sum = (double)x.Sum(i => i.Total) }).ToArray();
                double[] monthlySales = new double[12];
                for(int i = 0; i < sales.Length; i++)
                    monthlySales[sales[i].Month - 1] = sales[i].Sum;
                productInfo.MonthlySales = monthlySales;
            }
        }

        public static IQueryable<CustomerInfoWithSales> GetCustomerInfoWithSales(IQueryable<Customer> customers) {
            return customers.Select(x => new CustomerInfoWithSales {
                Id = x.Id,
                Name = x.Name,
                HomeOfficeLine = x.HomeOffice.Line,
                HomeOfficeCity = x.HomeOffice.City,
                HomeOfficeState = x.HomeOffice.State,
                HomeOfficeZipCode = x.HomeOffice.ZipCode,
                Phone = x.Phone,
                Fax = x.Fax,
                TotalSales = x.Orders.Sum(orderItem => orderItem.TotalAmount)
            });
        }
        public static void UpdateCustomerInfoWithSales(IEnumerable<CustomerInfoWithSales> entities, IQueryable<CustomerStore> stores, IQueryable<CustomerEmployee> employees, IQueryable<Order> orders) {
            foreach(var item in entities) {
                item.Init(
                    () => stores.Where(x => x.CustomerId == item.Id).ToArray(),
                    () => employees.Where(x => x.CustomerId == item.Id).ToArray(),
                    orders.Where(x => x.CustomerId == item.Id).GroupBy(o => o.OrderDate.Month).Select(g => g.Sum(i => i.TotalAmount)).ToArray()
                );
            }
        }

        public static IQueryable<Order> GetOrdersForPeriod(IQueryable<Order> orders, Period period, DateTime dateTime = new DateTime()) {
            switch(period) {
                case Period.ThisYear:
                    return orders.Where(o => o.OrderDate.Year == DateTime.Now.Year);
                case Period.ThisMonth:
                    return orders.Where(o => o.OrderDate.Month == DateTime.Now.Month && o.OrderDate.Year == DateTime.Now.Year);
                case Period.FixedDate:
                    return orders.Where(o => o.OrderDate.Month == dateTime.Month && o.OrderDate.Year == dateTime.Year
                        && o.OrderDate.Day == dateTime.Day);
            }
            return orders;
        }
        public static IQueryable<Order> GetCustomerOrdersForPeriod(IQueryable<Order> orders, Period period, long customerId) {
            return GetOrdersForPeriod(orders.Where(o => o.CustomerId == customerId), period);
        }

        public static IQueryable<OrderItem> GetOrderItemsForPeriod(IQueryable<OrderItem> orderItems, Period period, DateTime dateTime = new DateTime()) {
            return orderItems.Where(GetOrderItemsForPeriodFilter(period, dateTime));
        }
        public static Expression<Func<OrderItem, bool>> GetOrderItemsForPeriodFilter(Period period, DateTime dateTime = new DateTime()) {
            switch(period) {
                case Period.ThisYear:
                    return x => x.Order.OrderDate.Year == DateTime.Now.Year;
                case Period.ThisMonth:
                    return x => x.Order.OrderDate.Month == DateTime.Now.Month && x.Order.OrderDate.Year == DateTime.Now.Year;
                case Period.FixedDate:
                    return x => x.Order.OrderDate.Month == dateTime.Month && x.Order.OrderDate.Year == dateTime.Year
                        && x.Order.OrderDate.Day == dateTime.Day;
            }
            return x => true;
        }

        public static IEnumerable<CustomerStore> GetSalesStoresForPeriod(IQueryable<Order> orders, Period period = Period.Lifetime) {
            return QueriesHelper.GetOrdersForPeriod(orders, period).GroupBy(o => o.Store).Select(g => g.Key).Distinct();
        }

        public static IEnumerable<MapItem> GetSaleMapItemsByCity(IQueryable<OrderItem> orderItems, long productId, string city, Period period = Period.Lifetime) {
            return GetSaleMapItems(orderItems.Where(x => x.Order.Store.Address.City == city), productId, period);
        }
        public static IEnumerable<MapItem> GetSaleMapItems(IQueryable<OrderItem> orderItems, long productId, Period period = Period.Lifetime) {
            return GetSaleMapItemsCore(orderItems.Where(QueriesHelper.GetOrderItemsForPeriodFilter(period)).Where(x => x.ProductId == productId));
        }
        public static IEnumerable<MapItem> GetSaleMapItemsByCustomer(IQueryable<OrderItem> orderItems, long customerId, Period period = Period.Lifetime) {
            return GetSaleMapItemsCore(orderItems.Where(x => x.Order.CustomerId == customerId).Where(QueriesHelper.GetOrderItemsForPeriodFilter(period)));
        }
        public static IEnumerable<MapItem> GetSaleMapItemsByCustomerAndCity(IQueryable<OrderItem> orderItems, long customerId, string city, Period period = Period.Lifetime) {
            return GetSaleMapItemsByCustomer(orderItems.Where(x => x.Order.Store.Address.City == city), customerId, period);
        }
        static IEnumerable<MapItem> GetSaleMapItemsCore(IQueryable<OrderItem> orderItems) {
            return orderItems
                .Select(x => new MapItem {
                    Customer = x.Order.Customer,
                    Product = x.Product,
                    Total = x.Total,
                    Address = x.Order.Store.Address
                });
        }

        public static IEnumerable<SalesSummaryItem> GetSalesSummaryItems(IQueryable<OrderItem> orderItems, Period period, DateTime dateTime = new DateTime()) {
            return GetOrderItemsForPeriod(orderItems, period, dateTime)
                    .GroupBy(oi => oi.Product.Category)
                    .Select(g => new SalesSummaryItem { Category = g.Key, Sales = g.Sum(oi => oi.Total) })
                    .ToList();
        }
        public static IEnumerable<CostAverageItem> GetCostAverageItems(IQueryable<OrderItem> orderItems, Period period, DateTime dateTime = new DateTime()) {
            return GetOrderItemsForPeriod(orderItems, period, dateTime)
                    .GroupBy(oi => oi.Product.Category)
                    .Select(g => new CostAverageItem { Category = g.Key, Cost = g.Average(oi => oi.ProductPrice) })
                    .ToList();
        }
        public static IEnumerable<CustomerStore> GetDistinctStoresForPeriod(IQueryable<Order> orders, long customerId, Period period = Period.Lifetime) {
            return QueriesHelper.GetCustomerOrdersForPeriod(orders, period, customerId).GroupBy(o => o.Store).Select(g => g.Key).Distinct();
        }

        public static decimal GetQuotesTotal(IQueryable<Quote> quotes, CustomerStore store, DateTime begin, DateTime end) {
            return quotes.Where(x => x.CustomerStoreId == store.Id && x.Date >= begin && x.Date <= end).CustomSum(x => x.Total);
        }
        public static IEnumerable<QuoteSummaryItem> GetSummaryOpportunities(IQueryable<Quote> quotes) {
            yield return GetSummaryItem(quotes, Stage.High);
            yield return GetSummaryItem(quotes, Stage.Medium);
            yield return GetSummaryItem(quotes, Stage.Low);
            yield return GetSummaryItem(quotes, Stage.Unlikely);
        }
        public static IEnumerable<QuoteMapItem> GetOpportunities(IQueryable<Quote> quotes, IQueryable<Customer> customers, Stage stage) {
            string name = Enum.GetName(typeof(Stage), stage);
            return from q in GetQuotes(quotes, stage)
                   join c in customers on q.CustomerId equals c.Id
                   select new QuoteMapItem { Stage = stage, Address = q.CustomerStore.Address, Value = q.Total, Date = q.Date };
        }
        public static IEnumerable<QuoteMapItem> GetOpportunities(IQueryable<Quote> quotes) {
            yield return GetOpportunity(quotes, Stage.High);
            yield return GetOpportunity(quotes, Stage.Medium);
            yield return GetOpportunity(quotes, Stage.Low);
            yield return GetOpportunity(quotes, Stage.Unlikely);
        }
        static QuoteMapItem GetOpportunity(IQueryable<Quote> quotes, Stage stage) {
            return new QuoteMapItem {
                Stage = stage,
                Value = GetQuotes(quotes, stage).CustomSum(q => q.Total)
            };
        }
        public static decimal GetOpportunity(IQueryable<Quote> quotes, Stage stage, string city) {
            return GetQuotes(quotes, stage).Where(q => q.CustomerStore.Address.City == city).CustomSum(q => q.Total);
        }
        public static IEnumerable<CustomerStore> GetCustomerStore(IQueryable<CustomerStore> stores, IQueryable<Quote> quotes, Stage stage) {
            return from q in GetQuotes(quotes, stage)
                   join s in stores on q.CustomerStoreId equals s.Id
                   select s;
        }
        public static IEnumerable<OrderItem> GetRevenueReportItems(IQueryable<OrderItem> orderItems) {
            bool hasItemsInCurrentMonth = orderItems.Where(x => x.Order.OrderDate.Month == DateTime.Now.Month && x.Order.OrderDate.Year == DateTime.Now.Year).Any();
            var dateOfLastOrder = orderItems.Max(x => x.Order.OrderDate);
            var revenueMonth = hasItemsInCurrentMonth ? DateTime.Now.Month : dateOfLastOrder.Month;
            var revenueYear = hasItemsInCurrentMonth ? DateTime.Now.Year : dateOfLastOrder.Year;
            return orderItems.Where(x => x.Order.OrderDate.Month == revenueMonth && x.Order.OrderDate.Year == revenueYear).ToList();
        }
        public static IEnumerable<OrderItem> GetRevenueAnalysisReportItems(IQueryable<OrderItem> orderItems, long storeId) {
            return orderItems.Where(x => x.Order.StoreId.Value == storeId).ToList();
        }
        static QuoteSummaryItem GetSummaryItem(IQueryable<Quote> quotes, Stage stage) {
            var query = GetQuotes(quotes, stage);
            return new QuoteSummaryItem {
                StageName = stage.ToString(),
                Summary = !query.Any() ? 0 : query.CustomSum(q => q.Total)
            };
        }
        static IQueryable<Quote> GetQuotes(IQueryable<Quote> quotes, Stage stage) {
            double min, max;
            switch(stage) {
                case Stage.High:
                    max = 1.0;
                    min = 0.6;
                    break;
                case Stage.Medium:
                    min = 0.3;
                    max = 0.6;
                    break;
                case Stage.Low:
                    min = 0.12;
                    max = 0.3;
                    break;
                case Stage.Summary:
                    min = 0.0;
                    max = 1.0;
                    break;
                default:
                    min = 0.0;
                    max = 0.12;
                    break;
            }
            return quotes.Where(q => q.Opportunity > min && q.Opportunity < max);
        }
    }
    public enum Period {
        [Display(Name = "Lifetime")]
        Lifetime,
        [Display(Name = "This Year")]
        ThisYear,
        [Display(Name = "This Month")]
        ThisMonth,
        [Display(Name = "Fixed Date")]
        FixedDate
    }
}
