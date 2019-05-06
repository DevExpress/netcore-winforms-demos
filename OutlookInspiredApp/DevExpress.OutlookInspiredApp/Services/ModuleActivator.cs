namespace DevExpress.DevAV.Services {
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using DevExpress.DevAV.ViewModels;

    public interface IModuleActivator {
        object CreateModule(string moduleTypeName);
        object CreateModule(string moduleTypeName, object viewModel);
    }
    class ModuleActivator : IModuleActivator {
        Assembly moduleAssembly;
        string rootNamespace;
        public ModuleActivator(Assembly moduleAssembly, string rootNamespace) {
            this.moduleAssembly = moduleAssembly;
            this.rootNamespace = rootNamespace;
        }
        public object CreateModule(string moduleTypeName) {
            Type moduleType = moduleAssembly.GetType(rootNamespace + '.' + moduleTypeName);
            return Activator.CreateInstance(moduleType);
        }
        public object CreateModule(string moduleTypeName, object viewModel) {
            Type moduleType = moduleAssembly.GetType(rootNamespace + '.' + moduleTypeName);
            return Activator.CreateInstance(moduleType, new object[] { viewModel });
        }
    }
    public interface IReportActivator {
        object CreateReport(object reportKey);
    }
    class ReportActivator : IReportActivator {
        IDictionary<object, Type> reportTypes;

        public ReportActivator() {
            this.reportTypes = new Dictionary<object, Type>();
            reportTypes.Add(EmployeeReportType.Directory, typeof(DevExpress.DevAV.Reports.EmployeeDirectory));
            reportTypes.Add(EmployeeReportType.Profile, typeof(DevExpress.DevAV.Reports.EmployeeProfile));
            reportTypes.Add(EmployeeReportType.Summary, typeof(DevExpress.DevAV.Reports.EmployeeSummary));
            reportTypes.Add(EmployeeReportType.TaskList, typeof(DevExpress.DevAV.Reports.EmployeeTaskList));

            reportTypes.Add(CustomerReportType.Profile, typeof(DevExpress.DevAV.Reports.CustomerProfile));
            reportTypes.Add(CustomerReportType.SelectedContactDirectory, typeof(DevExpress.DevAV.Reports.CustomerContactsDirectory));
            reportTypes.Add(CustomerReportType.ContactDirectory, typeof(DevExpress.DevAV.Reports.CustomerContactsDirectory));
            reportTypes.Add(CustomerReportType.LocationsDirectory, typeof(DevExpress.DevAV.Reports.CustomerLocationsDirectory));
            reportTypes.Add(CustomerReportType.SalesSummary, typeof(DevExpress.DevAV.Reports.CustomerSalesSummaryReport));
            reportTypes.Add(CustomerReportType.SalesDetail, typeof(DevExpress.DevAV.Reports.CustomerSalesDetailReport));

            reportTypes.Add(ProductReportType.SpecificationSummary, typeof(DevExpress.DevAV.Reports.ProductProfile));
            reportTypes.Add(ProductReportType.OrderDetail, typeof(DevExpress.DevAV.Reports.ProductOrders));
            reportTypes.Add(ProductReportType.SalesSummary, typeof(DevExpress.DevAV.Reports.ProductSalesSummary));
            reportTypes.Add(ProductReportType.TopSalesperson, typeof(DevExpress.DevAV.Reports.ProductTopSalesperson));

            reportTypes.Add(SalesReportType.Invoice, typeof(DevExpress.DevAV.Reports.SalesInvoice));
            reportTypes.Add(SalesReportType.SalesReport, typeof(DevExpress.DevAV.Reports.SalesOrdersSummaryReport));
            reportTypes.Add(SalesReportType.SalesByStore, typeof(DevExpress.DevAV.Reports.SalesAnalysisReport));
        }
        public object CreateReport(object reportKey) {
            Type reportType;
            if(reportTypes.TryGetValue(reportKey, out reportType))
                return Activator.CreateInstance(reportType);
            throw new ArgumentException("reportKey");
        }
    }
}
