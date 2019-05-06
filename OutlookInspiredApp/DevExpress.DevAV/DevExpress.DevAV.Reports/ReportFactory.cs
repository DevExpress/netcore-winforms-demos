using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DevExpress.DevAV.Reports {
    public static class ReportFactory {
        #region Employee
        public static XtraReport EmployeeTaskList(IEnumerable<EmployeeTask> tasks, bool dueDate) {
            var report = new EmployeeTaskList();
            report.DataSource = tasks;
            report.Parameters["paramDueDate"].Value = dueDate;
            return report;
        }
        public static XtraReport EmployeeProfile(Employee employee, bool addEvaluations) {
            var report = new EmployeeProfile();
            report.DataSource = new ArrayList { employee };
            report.Parameters["paramEvaluations"].Value = addEvaluations;
            return report;
        }
        public static XtraReport EmployeeSummary(IEnumerable<Employee> employees, bool sortAscending) {
            var report = new EmployeeSummary();
            report.DataSource = employees;
            report.Parameters["paramAscending"].Value = sortAscending;
            return report;
        }
        public static XtraReport EmployeeDirectory(IEnumerable<Employee> employees, bool sortAscending) {
            var report = new EmployeeDirectory();
            report.DataSource = employees;
            report.Parameters["paramAscending"].Value = sortAscending;
            return report;
        }
        #endregion

        #region Customer
        public static XtraReport CustomerProfile(Customer customer, bool printContacts) {
            var report = new CustomerProfile();
            report.DataSource = new ArrayList() { customer };
            report.Parameters["paramContacts"].Value = printContacts;
            return report;
        }

        public static XtraReport CustomerContactsDirectory(IEnumerable<CustomerEmployee> customerContacts, bool sortAscending) {
            var report = new CustomerContactsDirectory();
            report.DataSource = customerContacts;
            report.Parameters["paramAscending"].Value = sortAscending;
            return report;
        }

        public static XtraReport CustomerSalesDetail(IEnumerable<Order> orders, IEnumerable<OrderItem> salesDetail, bool sortByOrderDate, DateTime fromDate, DateTime toDate) {
            var report = new CustomerSalesDetail();
            report.SetChartData(salesDetail);
            report.DataSource = orders;
            report.Parameters["paramOrderDate"].Value = sortByOrderDate;
            report.Parameters["paramFromDate"].Value = fromDate;
            report.Parameters["paramToDate"].Value = toDate;
            return report;
        }
        public static XtraReport CustomerSalesDetailReport(IEnumerable<CustomerSaleDetailOrderInfo> orders, IEnumerable<CustomerSaleDetailOrderItemInfo> salesDetail, bool sortByOrderDate, DateTime fromDate, DateTime toDate) {
            var report = new CustomerSalesDetailReport();
            report.SetChartData(salesDetail);
            report.DataSource = orders;
            report.Parameters["paramOrderDate"].Value = sortByOrderDate;
            report.Parameters["paramFromDate"].Value = fromDate;
            report.Parameters["paramToDate"].Value = toDate;
            return report;
        }

        public static XtraReport CustomerSalesSummary(IEnumerable<OrderItem> sales, bool sortByOrderDate, DateTime fromDate, DateTime toDate) {
            var report = new CustomerSalesSummary();
            report.DataSource = sales;
            report.Parameters["paramOrderDate"].Value = sortByOrderDate;
            report.Parameters["paramFromDate"].Value = fromDate;
            report.Parameters["paramToDate"].Value = toDate;
            return report;
        }
        public static XtraReport CustomerSalesSummaryReport(IEnumerable<CustomerSaleDetailOrderItemInfo> sales, bool sortByOrderDate, DateTime fromDate, DateTime toDate) {
            var report = new CustomerSalesSummaryReport();
            report.DataSource = sales;
            report.Parameters["paramOrderDate"].Value = sortByOrderDate;
            report.Parameters["paramFromDate"].Value = fromDate;
            report.Parameters["paramToDate"].Value = toDate;
            return report;
        }

        public static XtraReport CustomerLocationsDirectory(IEnumerable<Customer> customers, bool sortAscending) {
            var report = new CustomerLocationsDirectory();
            report.DataSource = customers;
            report.Parameters["paramAscending"].Value = sortAscending;
            return report;
        }
        #endregion

        #region Sales
        public static XtraReport SalesInvoice(Order order, bool showHeader, bool showFooter, bool showStatus, bool showComments) {
            var report = new SalesInvoice();
            report.DataSource = new ArrayList { order };
            report.Parameters["paramShowHeader"].Value = showHeader;
            report.Parameters["paramShowFooter"].Value = showFooter;
            report.Parameters["paramShowStatus"].Value = showStatus;
            report.Parameters["paramShowComments"].Value = showComments;
            return report;
        }

        public static XtraReport SalesOrdersSummary(IEnumerable<OrderItem> sales, bool sortByOrderDate, DateTime fromDate, DateTime toDate) {
            var report = new SalesOrdersSummary();
            report.DataSource = sales;
            report.Parameters["paramOrderDate"].Value = sortByOrderDate;
            report.Parameters["paramFromDate"].Value = fromDate;
            report.Parameters["paramToDate"].Value = toDate;
            return report;
        }

        public static XtraReport SalesOrdersSummaryReport(IEnumerable<SaleSummaryInfo> sales, bool sortByOrderDate, DateTime fromDate, DateTime toDate) {
            var report = new SalesOrdersSummaryReport();
            report.DataSource = sales;
            report.Parameters["paramOrderDate"].Value = sortByOrderDate;
            report.Parameters["paramFromDate"].Value = fromDate;
            report.Parameters["paramToDate"].Value = toDate;
            return report;
        }

        public static XtraReport SalesAnalysis(IEnumerable<OrderItem> sales, string years) {
            var report = new SalesAnalysis();
            report.DataSource = sales;
            report.Parameters["paramYears"].Value = years;
            return report;
        }

        public static XtraReport SalesAnalysisReport(IEnumerable<SaleAnalisysInfo> sales, string years) {
            var report = new SalesAnalysisReport();
            report.DataSource = sales;
            report.Parameters["paramYears"].Value = years;
            return report;
        }

        public static XtraReport SalesRevenueAnalysisReport(IEnumerable<OrderItem> sales, bool sortByOrderDate) {
            var report = new SalesRevenueAnalysisReport();
            report.DataSource = sales;
            report.Parameters["paramOrderDate"].Value = sortByOrderDate;
            return report;
        }

        public static XtraReport SalesRevenueReport(IEnumerable<OrderItem> sales, bool sortByOrderDate) {
            var report = new SalesRevenueReport();
            report.DataSource = sales;
            report.Parameters["paramOrderDate"].Value = sortByOrderDate;
            return report;
        }
        #endregion

        #region Product
        public static XtraReport ProductProfile(Product product, bool useImages) {
            var report = new ProductProfile();
            report.DataSource = new ArrayList { product };
            report.Parameters["paramImages"].Value = useImages;
            return report;
        }
        public static XtraReport ProductOrders(IEnumerable<OrderItem> sales, IList<State> states, bool sortByOrderDate, DateTime fromDate, DateTime toDate) {
            var report = new ProductOrders();
            report.DataSource = sales;
            report.SetStates(states);
            report.Parameters["paramOrderDate"].Value = sortByOrderDate;
            report.Parameters["paramFromDate"].Value = fromDate;
            report.Parameters["paramToDate"].Value = toDate;
            return report;
        }
        public static XtraReport ProductSalesSummary(IEnumerable<OrderItem> sales, string years) {
            var report = new ProductSalesSummary();
            report.DataSource = sales;
            report.Parameters["paramYears"].Value = years;
            return report;
        }
        public static XtraReport ProductTopSalesPerson(IEnumerable<OrderItem> sales, bool sortAscending) {
            var report = new ProductTopSalesperson();
            report.DataSource = sales;
            report.Parameters["paramAscending"].Value = sortAscending;
            return report;
        }
        #endregion

        #region Task
        public static XtraReport TaskListReport(IEnumerable<EmployeeTask> tasks, bool dueDate) {
            var report = new TaskListReport();
            report.DataSource = tasks;
            report.Parameters["paramDueDate"].Value = dueDate;
            return report;
        }
        public static XtraReport TaskDetailReport(EmployeeTask task) {
            var report = new TaskDetailReport();
            report.DataSource = new ArrayList { task };
            return report;
        }
        #endregion

        #region Shipping
        public static XtraReport ShippingDetail(Order order) {
            var report = new FedExGroundLabel();
            report.DataSource = new ArrayList { order };
            return report;
        }
        #endregion
    }
}
