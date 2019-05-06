namespace DevExpress.DevAV.Modules {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using DevExpress.DevAV;
    using DevExpress.DevAV.Reports;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.XtraPrinting;
    using DevExpress.XtraReports.Parameters;
    using DevExpress.XtraReports.UI;

    public partial class CustomersPrint : BaseModuleControl {
        XtraReport report;
        public CustomersPrint()
            : base(typeof(CustomersReportViewModel)) {
            InitializeComponent();
            ViewModel.ReportTypeChanged += ViewModel_ReportTypeChanged;
            ViewModel.ReportEntityKeyChanged += ViewModel_ReportEntityKeyChanged;
            ViewModel.Reload += ViewModel_Reload;
            printControl.SelectedPrinterName = PageSettingsHelper.DefaultPageSettings.PrinterSettings.PrinterName;
        }
        protected override void OnMVVMContextReleasing() {
            ViewModel.Reload -= ViewModel_Reload;
            ViewModel.ReportTypeChanged -= ViewModel_ReportTypeChanged;
            ViewModel.ReportEntityKeyChanged -= ViewModel_ReportEntityKeyChanged;
        }
        protected override void OnDisposing() {
            previewControl.DocumentSource = null;
            report = null;
            ReleaseModuleReports<CustomerReportType>();
            base.OnDisposing();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if(ViewModel != null) ViewModel.OnLoad();
            UpdatePreview();
        }
        public CustomersReportViewModel ViewModel {
            get { return GetViewModel<CustomersReportViewModel>(); }
        }
        public CustomerCollectionViewModel CollectionViewModel {
            get { return GetParentViewModel<CustomerCollectionViewModel>(); }
        }
        Parameter GetParameter(string name, Type type) {
            if(report != null) {
                if(report.Parameters[name] == null || report.Parameters[name].Type != type)
                    throw new Exception("Invalid report parameter.");
                return report.Parameters[name];
            }
            return null;
        }
        Parameter ParamContacts {
            get { return GetParameter("paramContacts", typeof(bool)); }
        }
        Parameter ParamAscending {
            get { return GetParameter("paramAscending", typeof(bool)); }
        }
        Parameter ParamOrderDate {
            get { return GetParameter("paramOrderDate", typeof(bool)); }
        }
        Parameter ParamFromDate {
            get { return GetParameter("paramFromDate", typeof(DateTime)); }
        }
        Parameter ParamToDate {
            get { return GetParameter("paramToDate", typeof(DateTime)); }
        }
        void ViewModel_ReportEntityKeyChanged(object sender, EventArgs e) {
            if(ViewModel.ReportType == CustomerReportType.Profile ||
                ViewModel.ReportType == CustomerReportType.SalesDetail ||
                ViewModel.ReportType == CustomerReportType.SalesSummary ||
                ViewModel.ReportType == CustomerReportType.SelectedContactDirectory)
                UpdatePreview();
        }
        void ViewModel_ReportTypeChanged(object sender, System.EventArgs e) {
            UpdatePreview();
        }
        void ViewModel_Reload(object sender, EventArgs e) {
            UpdatePreview();
        }
        void UpdatePreview() {
            if(ViewModel == null || ViewModel.ReportType == CustomerReportType.None)
                return;
            this.report = CreateAndInitializeReport(ViewModel.ReportType);
            previewControl.DocumentSource = report;
            CreateDocument(report);
            printControl.SetSettings(GetSettingsEditor(ViewModel.ReportType));
            printControl.PrintEnabled = false;
        }
        Control GetSettingsEditor(CustomerReportType reportType) {
            switch(reportType) {
                case CustomerReportType.Profile:
                    return new ContactsControl(value => SetParameter(ParamContacts, value), (bool)ParamContacts.Value);
                case CustomerReportType.LocationsDirectory:
                case CustomerReportType.ContactDirectory:
                case CustomerReportType.SelectedContactDirectory:
                    return new SortOrderControl(value => SetParameter(ParamAscending, value), (bool)ParamAscending.Value);
                case CustomerReportType.SalesDetail:
                case CustomerReportType.SalesSummary:
                    return new SortFilterControl(value => SetParameter(ParamOrderDate, value), (bool)ParamOrderDate.Value,
                        fromDate => SetParameter(ParamFromDate, fromDate), (DateTime)ParamFromDate.Value,
                        toDate => SetParameter(ParamToDate, toDate), (DateTime)ParamToDate.Value);
            }
            return null;
        }
        void SetParameter(Parameter parameter, object value) {
            if(parameter != null) {
                parameter.Value = value;
                CreateDocument(report);
            }
        }
        XtraReport CreateAndInitializeReport(CustomerReportType reportType) {
            var locator = GetService<Services.IReportLocator>();
            var report = locator.GetReport(reportType) as XtraReport;

            switch(reportType) {
                case CustomerReportType.SelectedContactDirectory:
                    report.DataSource = CollectionViewModel.SelectedEntity.Employees;
                    break;
                case CustomerReportType.ContactDirectory:
                    report.DataSource = ViewModel.CustomerEmployees;
                    break;
                case CustomerReportType.LocationsDirectory:
                    report.DataSource = CollectionViewModel.Entities;
                    break;
                case CustomerReportType.SalesDetail:
                    var orders = QueriesHelper.GetCustomerSaleDetails(CollectionViewModel.SelectedEntityKey, CollectionViewModel.GetOrderItems());
                    ((CustomerSalesDetailReport)report).SetChartData(orders.SelectMany(x => x.OrderItems).ToArray());
                    report.DataSource = orders;
                    break;
                case CustomerReportType.Profile:
                    report.DataSource = new List<Customer> { CollectionViewModel.SelectedEntity };
                    break;
                case CustomerReportType.SalesSummary:
                    report.DataSource = QueriesHelper.GetCustomerSaleOrderItemDetails(CollectionViewModel.SelectedEntity.Id, CollectionViewModel.GetOrderItems());
                    break;
            }
            return report;
        }
        void CreateDocument(XtraReport report) {
            if(report != null) {
                report.PrintingSystem.ClearContent();
                report.CreateDocument(true);
                report.PrintingSystem.AfterBuildPages -= PrintingSystem_AfterBuildPages;
                report.PrintingSystem.AfterBuildPages += PrintingSystem_AfterBuildPages;
            }
        }
        void PrintingSystem_AfterBuildPages(object sender, EventArgs e) {
            printControl.PrintEnabled = ((PrintingSystemBase)sender).PageCount > 0;
        }
        void settingsControl_PrintClick(object sender, EventArgs e) {
            using(ReportPrintTool tool = new ReportPrintTool(report))
                tool.Print(printControl.SelectedPrinterName);
        }
        void settingsControl_PrintOptionsClick(object sender, EventArgs e) {
            using(ReportPrintTool tool = new ReportPrintTool(report))
                tool.PrintDialog(FindForm(), LookAndFeel);
        }
    }
}