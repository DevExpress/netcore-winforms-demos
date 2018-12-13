namespace DevExpress.DevAV.ViewModels {
    using DevExpress.DevAV;
    using DevExpress.DevAV.DevAVDbDataModel;
    
    using DevExpress.Mvvm;
    using System;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;

    public class OrderQuickReportsViewModel : IDocumentContent, ISupportParameter {
        object ISupportParameter.Parameter {
            get { return new object[] { Format, Order }; }
            set {
                Format = (ReportFormat)((object[])value)[0];
                Order = (Order)((object[])value)[1];
                LoadDocument(Order);
            }
        }

        protected IDocumentOwner DocumentOwner { get; private set; }

        public void Close() {
            if(DocumentOwner != null)
                DocumentOwner.Close(this);
        }
        public void LoadDocument(Order order) {
            var documentStream = new MemoryStream();
            //var report = ReportFactory.SalesInvoice(order, true, false, false, false);
            //switch(Format) {
            //    case ReportFormat.Pdf:
            //        report.ExportToPdf(documentStream);
            //        break;
            //    case ReportFormat.Xls:
            //        report.ExportToXls(documentStream);
            //        break;
            //    case ReportFormat.Doc:
            //        report.ExportToRtf(documentStream, new XtraPrinting.RtfExportOptions() { ExportMode = XtraPrinting.RtfExportMode.SingleFilePageByPage });
            //        break;
            //}
            DocumentStream = documentStream;
            DocumentStream.Seek(0, SeekOrigin.Begin);
        }

        public virtual Stream DocumentStream { get; set; }
        public ReportFormat? Format { get; set; }
        public Order Order { get; set; }

        #region IDocumentContent
        void IDocumentContent.OnClose(CancelEventArgs e) {
            DocumentStream.Dispose();
        }
        void IDocumentContent.OnDestroy() { }
        IDocumentOwner IDocumentContent.DocumentOwner {
            get { return DocumentOwner; }
            set { DocumentOwner = value; }
        }
        object IDocumentContent.Title { get { return string.Format("Invoice# {0}", Order.InvoiceNumber); } }

        #endregion
    }
    public enum ReportFormat {
        Pdf,
        Xls,
        Doc
    }
}
