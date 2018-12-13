namespace DevExpress.DevAV.ViewModels {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using DevExpress.DevAV.DevAVDbDataModel;

    public static class AnalysisPeriod {
        public static readonly DateTime Start = new DateTime(DateTime.Now.Year - 3, 10, 1);
        public static readonly DateTime End = new DateTime(DateTime.Now.Year, 09, 30);
        public static int MonthOffsetFromStart(DateTime dateTime) {
            return (dateTime.Year - Start.Year) * 12 + dateTime.Month - Start.Month;
        }
        public class Item {
            public decimal Total { get; set; }
            public int Year { get; set; }
            public int Month { get; set; }
            public DateTime Date {
                get { return new DateTime(Year, Month, 1); }
            }
        }
    }
    public static class ProductsAnalysis {
        public static IEnumerable<Item> GetFinancialReport(this IDevAVDbUnitOfWork UnitOfWork) {
            var orders = UnitOfWork.Orders;
            var orderItems =
                from oi in UnitOfWork.OrderItems
                join o in orders on oi.OrderId equals o.Id
                where (o.OrderDate >= AnalysisPeriod.Start && o.OrderDate <= AnalysisPeriod.End)
                select new
                {
                    Product = oi.Product,
                    Total = oi.Total,
                    FY = ((o.OrderDate.Year - AnalysisPeriod.Start.Year) * 12 + (o.OrderDate.Month - AnalysisPeriod.Start.Month)) / 12
                };
            return
                from oi in orderItems
                group oi by new { oi.Product, oi.FY } into g
                select new Item
                {
                    ProductName = g.Key.Product.Name,
                    Year = AnalysisPeriod.Start.Year + g.Key.FY,
                    Month = AnalysisPeriod.Start.Month,
                    Total = g.Select(o => (decimal?)o.Total).Sum() ?? 0
                };
        }
        public static IEnumerable<Item> GetFinancialData(this IDevAVDbUnitOfWork UnitOfWork) {
            var orders = UnitOfWork.Orders;
            var orderItems =
                from oi in UnitOfWork.OrderItems
                join o in orders on oi.OrderId equals o.Id
                where (o.OrderDate >= AnalysisPeriod.Start && o.OrderDate <= AnalysisPeriod.End)
                select new { Product = oi.Product, Date = o.OrderDate, Total = oi.Total };
            return
                from oi in orderItems
                group oi by new { oi.Product.Category, oi.Date.Year, oi.Date.Month } into g
                select new Item { ProductCategory = g.Key.Category, Year = g.Key.Year, Month = g.Key.Month, Total = g.Select(o => (decimal?)o.Total).Sum() ?? 0 };
        }
        public class Item : AnalysisPeriod.Item {
            public string ProductName { get; set; }
            public ProductCategory ProductCategory { get; set; }
        }
    }
    public static class CustomersAnalysis {
        public static IEnumerable<Item> GetSalesReport(this IDevAVDbUnitOfWork UnitOfWork) {
            var orders = UnitOfWork.Orders;
            var orderItems =
                from oi in UnitOfWork.OrderItems
                join o in orders on oi.OrderId equals o.Id
                where (o.OrderDate >= AnalysisPeriod.Start && o.OrderDate <= AnalysisPeriod.End)
                select new
                {
                    Customer = o.Customer,
                    Total = oi.Total,
                    FY = ((o.OrderDate.Year - AnalysisPeriod.Start.Year) * 12 + (o.OrderDate.Month - AnalysisPeriod.Start.Month)) / 12
                };
            return
                from oi in orderItems
                group oi by new { oi.Customer, oi.FY } into g
                select new Item
                {
                    CustomerName = g.Key.Customer.Name,
                    Year = AnalysisPeriod.Start.Year + g.Key.FY,
                    Month = AnalysisPeriod.Start.Month,
                    Total = g.Select(o => (decimal?)o.Total).Sum() ?? 0
                };
        }
        public static IEnumerable<Item> GetSalesData(this IDevAVDbUnitOfWork UnitOfWork) {
            var orders = UnitOfWork.Orders;
            var orderItems =
                from oi in UnitOfWork.OrderItems
                join o in orders on oi.OrderId equals o.Id
                where (o.OrderDate >= AnalysisPeriod.Start && o.OrderDate <= AnalysisPeriod.End)
                select new { State = o.Store.Address.State, Date = o.OrderDate, Total = oi.Total };
            return
                from oi in orderItems
                group oi by new { oi.State, oi.Date.Year, oi.Date.Month } into g
                select new Item { State = g.Key.State, Year = g.Key.Year, Month = g.Key.Month, Total = g.Select(o => (decimal?)o.Total).Sum() ?? 0 };
        }
        public class Item : AnalysisPeriod.Item {
            public string CustomerName { get; set; }
            public StateEnum State { get; set; }
        }
    }
}