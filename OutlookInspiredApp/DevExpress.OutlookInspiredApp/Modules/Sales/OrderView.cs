using DevExpress.Utils.MVVM;

namespace DevExpress.DevAV.Modules {
    using System;
    using DevExpress.DevAV;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.XtraBars.Docking2010;
    using DevExpress.XtraRichEdit;
    using DevExpress.XtraBars;

    public partial class OrderView : BaseModuleControl {
        public OrderView()
            : base(typeof(SynchronizedOrderViewModel)) {
            InitializeComponent();
            TitleLabel.Appearance.ForeColor = ColorHelper.DisabledTextColor;
            ItemForTitleLabel.AppearanceItemCaption.ForeColor = ColorHelper.DisabledTextColor;
            ItemForTitleLabel.AppearanceItemCaption.Options.UseForeColor = true;
            modueLayout.Visible = false;
            snapControl.BackColor = ColorHelper.GetControlColor(LookAndFeel);
            LookAndFeel.StyleChanged += LookAndFeel_StyleChanged;
            ViewModel.EntityChanged += ViewModel_EntityChanged;
            snapControl.ZoomChanged += snapControl_ZoomChanged;
        }
        protected override void OnMVVMContextReleasing() {
            ViewModel.EntityChanged -= ViewModel_EntityChanged;
        }
        protected override void OnDisposing() {
            LookAndFeel.StyleChanged -= LookAndFeel_StyleChanged;
            snapControl.ZoomChanged -= snapControl_ZoomChanged;
            base.OnDisposing();
        }
        public OrderViewModel ViewModel {
            get { return GetViewModel<OrderViewModel>(); }
        }
        void BindCommands() {
            var fluentAPI = mvvmContext.OfType<OrderViewModel>();
            fluentAPI.SetBinding(paidBBI, x => x.Caption, x => x.MarkPaidToolTip);
            fluentAPI.SetBinding(refundBBI, x => x.Caption, x => x.IssueFullRefundToolTip);
            editBBI.BindCommand(() => ViewModel.Edit(), ViewModel);
            deleteBBI.BindCommand(() => ViewModel.Delete(), ViewModel);
            emailBBI.BindCommand(() => ViewModel.MailTo(), ViewModel);
            printBBI.BindCommand(() => ViewModel.Print(), ViewModel);
            paidBBI.BindCommand(() => ViewModel.MarkPaid(), ViewModel);
            refundBBI.BindCommand(() => ViewModel.IssueFullRefund(), ViewModel);
        }
        void ViewModel_EntityChanged(object sender, System.EventArgs e) {
            QueueUIUpdate();
        }
        void LookAndFeel_StyleChanged(object sender, EventArgs e) {
            snapControl.BackColor = ColorHelper.GetControlColor(LookAndFeel);
        }
        protected override int GetUIUpdateDelay() {
            return 500;
        }
        protected override void OnDelayedUIUpdate() {
            base.OnDelayedUIUpdate();
            UpdateUI(ViewModel.Entity);
        }
        protected override void OnLoad(System.EventArgs e) {
            base.OnLoad(e);
            BindCommands();
            LoadOrderTemplate();
            UpdateUI(ViewModel.Entity);
        }
        void LoadOrderTemplate() {
            if(!snapControl.Document.IsEmpty) 
                return;
            using(var stream = MailMergeTemplatesHelper.GetTemplateStream("Order.snx"))
                snapControl.LoadDocumentTemplate(stream, DevExpress.Snap.Core.API.SnapDocumentFormat.Snap);
            snapControl.Paint += snapControl_Paint;
        }
        void snapControl_Paint(object sender, System.Windows.Forms.PaintEventArgs e) {
            snapControl.Paint -= snapControl_Paint;
            PrintLayoutView view = snapControl.ActiveView as PrintLayoutView;
            if(view != null)
                view.FitToPage();
        }
        void snapControl_ZoomChanged(object sender, EventArgs e) {
            RaiseZoomLevelChanged();
        }
        void UpdateUI(Order order) {
            if(order != null) {
                if(!object.Equals(bindingSource.DataSource, order))
                    bindingSource.DataSource = order;
                else
                    bindingSource.ResetBindings(false);
                snapControl.Document.Fields.Update();
            }
            modueLayout.Visible = (order != null);
        }
        public int ZoomLevel {
            get { return (int)System.Math.Ceiling(snapControl.ActiveView.ZoomFactor * 100.0f); }
            set {
                if(ZoomLevel == value) return;
                snapControl.ActiveView.ZoomFactor = ((float)value) / 100.0f;
            }
        }
        public BarButtonItem MovePrevButton {
            get {
                return previousBBI;
            }
        }
        public BarButtonItem MoveNextButton {
            get {
                return nextBBI;
            }
        }
        public event EventHandler ZoomLevelChanged;
        void RaiseZoomLevelChanged() {
            EventHandler handler = ZoomLevelChanged;
            if(handler != null) handler(this, EventArgs.Empty);
        }
    }
}