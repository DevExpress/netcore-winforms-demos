namespace DevExpress.DevAV.Modules {
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using DevExpress.DevAV;
    
    using DevExpress.DevAV.ViewModels;
    using DevExpress.XtraPrinting;
    using DevExpress.XtraReports.Parameters;
    using DevExpress.XtraReports.UI;

    public partial class EmployeesPrint : BaseModuleControl {
        XtraReport report;
        public EmployeesPrint()
            : base(typeof(EmployeesReportViewModel)) {
            InitializeComponent();
            ViewModel.ReportTypeChanged += ViewModel_ReportTypeChanged;
            ViewModel.ReportEntityKeyChanged += ViewModel_ReportEntityKeyChanged;
            ViewModel.Reload += ViewModel_Reload;
            printSettingsControl.SelectedPrinterName = PageSettingsHelper.DefaultPageSettings.PrinterSettings.PrinterName;
        }
        protected override void OnMVVMContextReleasing() {
            ViewModel.Reload -= ViewModel_Reload;
            ViewModel.ReportEntityKeyChanged -= ViewModel_ReportEntityKeyChanged;
            ViewModel.ReportTypeChanged -= ViewModel_ReportTypeChanged;
        }
        protected override void OnDisposing() {
            previewControl.DocumentSource = null;
            report = null;
            ReleaseModuleReports<EmployeeReportType>();
            base.OnDisposing();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if(ViewModel != null) 
                ViewModel.OnLoad();
            UpdatePreview();
        }
        public EmployeesReportViewModel ViewModel {
            get { return GetViewModel<EmployeesReportViewModel>(); }
        }
        public EmployeeCollectionViewModel CollectionViewModel {
            get { return GetParentViewModel<EmployeeCollectionViewModel>(); }
        }
        Parameter GetParameter(string name, Type type) {
            if(report != null) {
                if(report.Parameters[name] == null || report.Parameters[name].Type != type)
                    throw new Exception("Invalid report parameter.");
                return report.Parameters[name];
            }
            return null;
        }
        Parameter ParamAscending {
            get { return GetParameter("paramAscending", typeof(bool)); }
        }
        Parameter ParamEvaluations {
            get { return GetParameter("paramEvaluations", typeof(bool)); }
        }
        Parameter ParamDueDate {
            get { return GetParameter("paramDueDate", typeof(bool)); }
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
        void UpdatePreview() {
            if(ViewModel == null || ViewModel.ReportType == EmployeeReportType.None)
                return;
            this.report = CreateAndInitializeReport(ViewModel.ReportType);
            previewControl.DocumentSource = report;
            CreateDocument(report);
            printSettingsControl.SetSettings(GetSettingsEditor(ViewModel.ReportType));
            printSettingsControl.PrintEnabled = false;
        }
        Control GetSettingsEditor(EmployeeReportType reportType) {
            switch(reportType) {
                case EmployeeReportType.Profile:
                    return new EvaluationsControl(value => SetParameter(ParamEvaluations, value), (bool)ParamEvaluations.Value);
                case EmployeeReportType.Directory:
                case EmployeeReportType.Summary:
                    return new SortOrderControl(value => SetParameter(ParamAscending, value), (bool)ParamAscending.Value);
                case EmployeeReportType.TaskList:
                    return new TasksSortControl(value => SetParameter(ParamDueDate, value), (bool)ParamDueDate.Value);
            }
            return null;
        }
        void SetParameter(Parameter parameter, bool value) {
            if(parameter != null) {
                parameter.Value = value;
                CreateDocument(report);
            }
        }
        XtraReport CreateAndInitializeReport(EmployeeReportType reportType) {
            var locator = GetService<Services.IReportLocator>();
            var report = locator.GetReport(reportType) as XtraReport;
            switch(reportType) {
                case EmployeeReportType.Profile:
                    report.DataSource = new List<Employee> { CollectionViewModel.SelectedEntity };
                    break;
                case EmployeeReportType.TaskList:
                    report.DataSource = ViewModel.Tasks;
                    break;
                case EmployeeReportType.Directory:
                case EmployeeReportType.Summary:
                    report.DataSource = CollectionViewModel.Entities;
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
            printSettingsControl.PrintEnabled = ((PrintingSystemBase)sender).PageCount > 0;
            previewControl.Visible = true;
        }
        void settingsControl_PrintClick(object sender, EventArgs e) {
            using(ReportPrintTool tool = new ReportPrintTool(report)) {
                tool.Print(printSettingsControl.SelectedPrinterName);
            }
        }
        void settingsControl_PrintOptionsClick(object sender, EventArgs e) {
            using(ReportPrintTool tool = new ReportPrintTool(report)) {
                tool.PrintDialog(FindForm(), LookAndFeel);
            }
        }
    }
}