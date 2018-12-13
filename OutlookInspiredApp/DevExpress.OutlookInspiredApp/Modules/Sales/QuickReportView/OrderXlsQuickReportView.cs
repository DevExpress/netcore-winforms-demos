using System;
using DevExpress.DevAV.ViewModels;
using DevExpress.Mvvm;

namespace DevExpress.DevAV.Modules {
    public partial class OrderXlsQuickReportView : BaseModuleControl, IRibbonModule {
        public OrderXlsQuickReportView()
            :base(typeof(OrderQuickReportsViewModel)) {
            InitializeComponent();
        }
        public OrderQuickReportsViewModel ViewModel {
            get { return GetViewModel<OrderQuickReportsViewModel>(); }
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            spreadsheetControl1.LoadDocument(ViewModel.DocumentStream);
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