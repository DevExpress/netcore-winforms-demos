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

    public partial class EmployeesExport : BaseModuleControl {
        public EmployeesExport()
            : base(typeof(EmployeesReportViewModel)) {
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
            if(!(report is EmployeeProfile)) return;
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
            if(ViewModel == null || ViewModel.ReportType == EmployeeReportType.None)
                return;
            this.report = CreateAndInitializeReport(ViewModel.ReportType);
            previewControl.DocumentSource = report;
            CreateDocument(report);
            exportSettingsControl.SetSettings(GetSettingsEditor(ViewModel.ReportType));
            exportSettingsControl.ExportEnabled = false;   
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
            exportSettingsControl.ExportEnabled = ((PrintingSystemBase)sender).PageCount > 0;
            previewControl.Visible = true;
        }
    }
}