using System;
using DevExpress.DevAV.ViewModels;
using DevExpress.XtraReports.UI;
using DevExpress.Mvvm;

namespace DevExpress.DevAV.Modules {
    public partial class OrderRevenueView : BaseModuleControl, IRibbonModule {
        public OrderRevenueView() : base(typeof(OrderRevenueViewModel)) {
            InitializeComponent();
        }
        public OrderRevenueViewModel ViewModel {
            get { return GetViewModel<OrderRevenueViewModel>(); }
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            documentViewer1.DocumentSource = ViewModel.Report;
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

        private void showDesignerBarItem_ItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            using(var tool = new ReportDesignTool(ViewModel.Report)) {
                tool.ShowRibbonDesignerDialog();
            }
        }
    }
}
