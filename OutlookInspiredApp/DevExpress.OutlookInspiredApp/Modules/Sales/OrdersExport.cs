namespace DevExpress.DevAV.Modules {
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using DevExpress.DevAV;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.XtraPrinting;
    using DevExpress.XtraReports.Parameters;
    using DevExpress.XtraReports.UI;

    public partial class OrdersExport : BaseModuleControl {
        public OrdersExport()
            : base(typeof(OrdersReportViewModel)) {
            InitializeComponent();
            ViewModel.ReportTypeChanged += ViewModel_ReportTypeChanged;
            ViewModel.ReportEntityKeyChanged += ViewModel_ReportEntityKeyChanged;
            ViewModel.Reload += ViewModel_Reload;
            exportSettingsControl.ExportClick += exportSettings_Export;
        }
        protected override void OnMVVMContextReleasing() {
            ViewModel.Reload -= ViewModel_Reload;
            ViewModel.ReportEntityKeyChanged -= ViewModel_ReportEntityKeyChanged;
            ViewModel.ReportTypeChanged -= ViewModel_ReportTypeChanged;
        }
        protected override void OnDisposing() {
            exportSettingsControl.ExportClick -= exportSettings_Export;
            previewControl.DocumentSource = null;
            base.OnDisposing();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if(ViewModel != null) ViewModel.OnLoad();
            UpdatePreview();
        }
        public OrdersReportViewModel ViewModel {
            get { return GetViewModel<OrdersReportViewModel>(); }
        }
        public OrderCollectionViewModel CollectionViewModel {
            get { return GetParentViewModel<OrderCollectionViewModel>(); }
        }
        Parameter GetParameter(string name, Type type) {
            if(report != null) {
                if(report.Parameters[name] == null || report.Parameters[name].Type != type)
                    throw new Exception("Invalid report parameter.");
                return report.Parameters[name];
            }
            return null;
        }
        Parameter ParamShowHeader {
            get { return GetParameter("paramShowHeader", typeof(bool)); }
        }
        Parameter ParamShowFooter {
            get { return GetParameter("paramShowFooter", typeof(bool)); }
        }
        Parameter ParamShowComments {
            get { return GetParameter("paramShowComments", typeof(bool)); }
        }
        Parameter ParamShowStatus {
            get { return GetParameter("paramShowStatus", typeof(bool)); }
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
        void ViewModel_ReportEntityKeyChanged(object sender, EventArgs e) {
            UpdatePreview();
        }
        void ViewModel_ReportTypeChanged(object sender, System.EventArgs e) {
            UpdatePreview();
        }
        void ViewModel_Reload(object sender, EventArgs e) {
            UpdatePreview();
        }
        XtraReport report;
        void UpdatePreview() {
            if(ViewModel == null || ViewModel.ReportType == SalesReportType.None)
                return;
            this.report = CreateAndInitializeReport(ViewModel.ReportType);
            previewControl.DocumentSource = report;
            CreateDocument(report);
            exportSettingsControl.SetSettings(GetSettingsEditor(ViewModel.ReportType));
            exportSettingsControl.ExportEnabled = false;
        }
        Control GetSettingsEditor(SalesReportType reportType) {
            switch(reportType) {
                case SalesReportType.Invoice:
                    return new InvoiceSettingsControl(new List<Tuple<string, bool, Action<bool>>>() {
                        new Tuple<string, bool, Action<bool>>("Show Header", (bool)ParamShowHeader.Value, value => SetParameter(ParamShowHeader, value)),
                        new Tuple<string, bool, Action<bool>>("Show Footer", (bool)ParamShowFooter.Value, value => SetParameter(ParamShowFooter, value)),
                        new Tuple<string, bool, Action<bool>>("Show Status", (bool)ParamShowStatus.Value, value => SetParameter(ParamShowStatus, value)),
                        new Tuple<string, bool, Action<bool>>("Show Comments", (bool)ParamShowComments.Value, value => SetParameter(ParamShowComments, value))
                    });
                ////TODO use all 4 params
                //System.Diagnostics.Debug.Assert(false);
                //return new SortOrderControl(value => SetParameter(ParamShowHeader, value), (bool)ParamShowHeader.Value);
                case SalesReportType.SalesReport:
                    return new SortFilterControl(value => SetParameter(ParamOrderDate, value), (bool)ParamOrderDate.Value,
                        fromDate => SetParameter(ParamFromDate, fromDate), (DateTime)ParamFromDate.Value,
                        toDate => SetParameter(ParamToDate, toDate), (DateTime)ParamToDate.Value);
                case SalesReportType.SalesByStore:
                    return new YearsControl(value => SetParameter(ParamYears, value), (string)ParamYears.Value);
            }
            return null;
        }
        void SetParameter(Parameter parameter, object value) {
            if(parameter != null) {
                parameter.Value = value;
                CreateDocument(report);
            }
        }
        void exportSettings_Export(object sender, EventArgs e) {
            previewControl.DocumentViewer.PrintingSystem.ExportOptions.PrintPreview.ShowOptionsBeforeExport = Control.ModifierKeys == Keys.Control ? true : false;
            switch(exportSettingsControl.SelectedExport) {
                case ExportTarget.Pdf:
                    previewControl.DocumentViewer.ExecCommand(PrintingSystemCommand.ExportPdf);
                    break;
                case ExportTarget.Html:
                    previewControl.DocumentViewer.ExecCommand(PrintingSystemCommand.ExportHtm);
                    break;
                case ExportTarget.Mht:
                    previewControl.DocumentViewer.ExecCommand(PrintingSystemCommand.ExportMht);
                    break;
                case ExportTarget.Rtf:
                    previewControl.DocumentViewer.ExecCommand(PrintingSystemCommand.ExportRtf);
                    break;
                case ExportTarget.Xls:
                    previewControl.DocumentViewer.ExecCommand(PrintingSystemCommand.ExportXls);
                    break;
                case ExportTarget.Xlsx:
                    previewControl.DocumentViewer.ExecCommand(PrintingSystemCommand.ExportXlsx);
                    break;
                case ExportTarget.Csv:
                    previewControl.DocumentViewer.ExecCommand(PrintingSystemCommand.ExportCsv);
                    break;
                case ExportTarget.Text:
                    previewControl.DocumentViewer.ExecCommand(PrintingSystemCommand.ExportTxt);
                    break;
                case ExportTarget.Image:
                    previewControl.DocumentViewer.ExecCommand(PrintingSystemCommand.ExportGraphic);
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Export");
            }
        }
        XtraReport CreateAndInitializeReport(SalesReportType reportType) {
            var locator = GetService<Services.IReportLocator>();
            var report = locator.GetReport(reportType) as XtraReport;
            switch(reportType) {
                case SalesReportType.Invoice:
                    report.DataSource = new List<Order> { CollectionViewModel.SelectedEntity };
                    break;
                case SalesReportType.SalesReport:
                    report.DataSource = CollectionViewModel.GetSaleSummaryInfos();
                    break;                        
                case SalesReportType.SalesByStore:
                    report.DataSource = CollectionViewModel.GetSaleAnalisysInfos();
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
            exportSettingsControl.ExportEnabled = ((PrintingSystemBase)sender).PageCount > 0;
            previewControl.Visible = true;
        }
    }
}