using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraReports.UI;

namespace DevExpress.DevAV.ViewModels {
    public class OrderRevenueViewModel : IDocumentContent, ISupportParameter {
        object ISupportParameter.Parameter {
            get { return new object[] { SelectedItems, Format }; }
            set {
                SelectedItems = (IEnumerable<OrderItem>)((object[])value)[0];
                Format = (RevenueReportFormat)((object[])value)[1];
                OnLoaded();
            }
        }
        public OrderRevenueViewModel() { }
        public void Close() {
            if(DocumentOwner != null)
                DocumentOwner.Close(this);
        }
        protected IDocumentManagerService DocumentManagerService { get { return this.GetService<IDocumentManagerService>(); } }

        protected IDocumentOwner DocumentOwner { get; private set; }

        public RevenueReportFormat Format { get; set; }
        public IEnumerable<OrderItem> SelectedItems { get; set; }
        public virtual XtraReport Report { get; set; }

        public virtual void OnLoaded() {
            Report = CreateReport();
            Report.CreateDocument();
        }

        public void ShowDesigner() {
            var viewModel = ReportDesignerViewModel.Create(CloneReport(Report));
            var doc = DocumentManagerService.CreateDocument("ReportDesignerView", viewModel, null, this);
            doc.Title = CreateTitle();
            doc.Show();

            if(viewModel.IsReportSaved) {
                Report = CloneReport(viewModel.Report);
                Report.CreateDocument();
                viewModel.Report.Dispose();
            }
        }

        XtraReport CloneReport(XtraReport report) {
            var clonedReport = CloneReportLayout(report);
            InitReport(clonedReport);
            return clonedReport;
        }
        void InitReport(XtraReport report) {
            report.DataSource = SelectedItems;
            report.Parameters["paramOrderDate"].Value = true;
        }
        XtraReport CreateReport() {
            return null;
            //return Format == RevenueReportFormat.Summary ? ReportFactory.SalesRevenueReport(SelectedItems, true) :
            //    ReportFactory.SalesRevenueAnalysisReport(SelectedItems, true);
        }
        string CreateTitle() {
            return string.Format("{0}", Format == RevenueReportFormat.Analysis ? "Revenue Analysis" : "Revenue");
        }
        static XtraReport CloneReportLayout(XtraReport report) {
            using(var stream = new MemoryStream()) {
                report.SaveLayoutToXml(stream);
                stream.Position = 0;
                return XtraReport.FromStream(stream, true);
            }
        }
        #region IDocumentContent
        void IDocumentContent.OnClose(CancelEventArgs e) {
            Report.Dispose();
        }
        void IDocumentContent.OnDestroy() { }
        IDocumentOwner IDocumentContent.DocumentOwner {
            get { return DocumentOwner; }
            set { DocumentOwner = value; }
        }
        object IDocumentContent.Title { get { return CreateTitle(); } }
        #endregion
    }
    public enum RevenueReportFormat {
        Summary,
        Analysis
    }
    public class ReportDesignerViewModel {
        public static ReportDesignerViewModel Create(XtraReport report) {
            return ViewModelSource.Create(() => new ReportDesignerViewModel(report));
        }
        protected ReportDesignerViewModel(XtraReport report) {
            Report = report;
        }

        public XtraReport Report { get; private set; }
        public bool IsReportSaved { get; private set; }

        public virtual void Save() {
            IsReportSaved = true;
        }
    }
}
