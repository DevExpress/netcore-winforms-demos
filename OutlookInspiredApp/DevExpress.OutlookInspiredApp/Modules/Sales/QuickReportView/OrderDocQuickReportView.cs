using System;
using DevExpress.DevAV.ViewModels;
using DevExpress.XtraRichEdit;
using DevExpress.Mvvm;

namespace DevExpress.DevAV.Modules {
    public partial class OrderDocQuickReportView : BaseModuleControl, IRibbonModule {
        public OrderDocQuickReportView()
            : base(typeof(OrderQuickReportsViewModel)) {
            InitializeComponent();

        }
        public OrderQuickReportsViewModel ViewModel {
            get { return GetViewModel<OrderQuickReportsViewModel>(); }
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            richEditControl1.LoadDocument(ViewModel.DocumentStream, DocumentFormat.Rtf);
        }
        #region
        XtraBars.Ribbon.RibbonControl IRibbonModule.Ribbon {
            get {
                if(string.IsNullOrEmpty(ribbonControl.ApplicationDocumentCaption))
                    ribbonControl.ApplicationDocumentCaption = (string)(ViewModel as IDocumentContent).Title;
                return ribbonControl;
            }
        }
        #endregion
    }
}