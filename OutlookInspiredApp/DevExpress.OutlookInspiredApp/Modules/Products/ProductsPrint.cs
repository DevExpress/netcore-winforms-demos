namespace DevExpress.DevAV.Modules {
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using DevExpress.DevAV;
    using DevExpress.DevAV.Reports;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.XtraPrinting;
    using DevExpress.XtraReports.Parameters;
    using DevExpress.XtraReports.UI;

    public partial class ProductsPrint : BaseModuleControl {
        XtraReport report;
        public ProductsPrint()
            : base(typeof(ProductsReportViewModel)) {
            InitializeComponent();
            ViewModel.ReportTypeChanged += ViewModel_ReportTypeChanged;
            ViewModel.ReportEntityKeyChanged += ViewModel_ReportEntityKeyChanged;
            ViewModel.Reload += ViewModel_Reload;
            printControl.SelectedPrinterName = PageSettingsHelper.DefaultPageSettings.PrinterSettings.PrinterName;
        }
        protected override void OnMVVMContextReleasing() {
            ViewModel.ReportTypeChanged -= ViewModel_ReportTypeChanged;
            ViewModel.ReportEntityKeyChanged -= ViewModel_ReportEntityKeyChanged;
            ViewModel.Reload -= ViewModel_Reload;
        }
        protected override void OnDisposing() {
            previewControl.DocumentSource = null;
            report = null;
            ReleaseModuleReports<ProductReportType>();
            base.OnDisposing();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if(ViewModel != null) ViewModel.OnLoad();
            UpdatePreview();
        }
        public ProductsReportViewModel ViewModel {
            get { return GetViewModel<ProductsReportViewModel>(); }
        }
        public ProductCollectionViewModel CollectionViewModel {
            get { return GetParentViewModel<ProductCollectionViewModel>(); }
        }
        Parameter GetParameter(string name, Type type) {
            if(report != null) {
                if(report.Parameters[name] == null || report.Parameters[name].Type != type)
                    throw new Exception("Invalid report parameter.");
                return report.Parameters[name];
            }
            return null;
        }
        Parameter ParamImages {
            get { return GetParameter("paramImages", typeof(bool)); }
        }
        Parameter ParamYears {
            get { return GetParameter("paramYears", typeof(string)); }
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
        Parameter ParamAscending {
            get { return GetParameter("paramAscending", typeof(bool)); }
        }
        void ViewModel_ReportEntityKeyChanged(object sender, EventArgs e) {
            UpdatePreview();
        }
        void ViewModel_Reload(object sender, EventArgs e) {
            UpdatePreview();
        }
        void ViewModel_ReportTypeChanged(object sender, System.EventArgs e) {
            UpdatePreview();
        }
        void UpdatePreview() {
            if(ViewModel == null || ViewModel.ReportType == ProductReportType.None)
                return;
            this.report = CreateAndInitializeReport(ViewModel.ReportType);
            previewControl.DocumentSource = report;
            CreateDocument(report);
            printControl.SetSettings(GetSettingsEditor(ViewModel.ReportType));
            printControl.PrintEnabled = false;
        }
        Control GetSettingsEditor(ProductReportType reportType) {
            switch(reportType) {
                case ProductReportType.SpecificationSummary:
                    return new ImagesControl(value => SetParameter(ParamImages, value), (bool)ParamImages.Value);
                case ProductReportType.SalesSummary:
                    return new YearsControl(value => SetParameter(ParamYears, value), (string)ParamYears.Value);
                case ProductReportType.TopSalesperson:
                    return new SortOrderControl(value => SetParameter(ParamAscending, value), (bool)ParamAscending.Value);
                case ProductReportType.OrderDetail:
                    return new SortFilterControl(
                        value => SetParameter(ParamOrderDate, value), (bool)ParamOrderDate.Value,
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
        XtraReport CreateAndInitializeReport(ProductReportType reportType) {
            var locator = GetService<Services.IReportLocator>();
            var report = locator.GetReport(reportType) as XtraReport;
            switch(reportType) {
                case ProductReportType.SpecificationSummary:
                    report.DataSource = new List<Product> { CollectionViewModel.SelectedEntity };
                    break;
                case ProductReportType.SalesSummary:
                case ProductReportType.TopSalesperson:
                    report.DataSource = ViewModel.GetOrderItems((long)CollectionViewModel.SelectedEntityKey);
                    break;
                case ProductReportType.OrderDetail:
                    report.DataSource = ViewModel.GetOrderItems((long)CollectionViewModel.SelectedEntityKey);
                    (report as ProductOrders).SetStates(ViewModel.GetStates());
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
            using(ReportPrintTool tool = new ReportPrintTool(report)) {
                tool.Print(printControl.SelectedPrinterName);
            }
        }
        void settingsControl_PrintOptionsClick(object sender, EventArgs e) {
            using(ReportPrintTool tool = new ReportPrintTool(report)) {
                tool.PrintDialog(FindForm(), LookAndFeel);
            }
        }
    }
}