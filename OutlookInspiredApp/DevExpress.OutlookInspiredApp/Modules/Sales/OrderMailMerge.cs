namespace DevExpress.DevAV.Modules {
    using System;
    using System.IO;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.Snap.Core.API;
    using DevExpress.XtraRichEdit;

    public partial class OrderMailMerge : BaseModuleControl, IRibbonModule {
        public OrderMailMerge()
            : base(typeof(OrderMailMergeViewModel)) {
            InitializeComponent();
            BindCommands();
            UpdateUI();
            //
            ViewModel.MailTemplateChanged += ViewModel_MailTemplateChanged;
            ViewModel.MailTemplateSelectedChanged += ViewModel_MailTemplateSelectedChanged;
            ViewModel.PeriodChanged += ViewModel_PeriodChanged;
            ViewModel.Save += ViewModel_Save;
            ViewModel.Modified = snapControl.Modified;
            snapControl.ModifiedChanged += snapControl_ModifiedChanged;
        }
        protected override void OnMVVMContextReleasing() {
            ViewModel.Save -= ViewModel_Save;
            ViewModel.PeriodChanged -= ViewModel_PeriodChanged;
            ViewModel.MailTemplateChanged -= ViewModel_MailTemplateChanged;
            ViewModel.MailTemplateSelectedChanged -= ViewModel_MailTemplateSelectedChanged;
        }
        protected override void OnDisposing() {
            snapControl.ModifiedChanged -= snapControl_ModifiedChanged;
            base.OnDisposing();
        }
        void ViewModel_MailTemplateSelectedChanged(object sender, EventArgs e) {
            UpdateUI();
        }
        void ViewModel_MailTemplateChanged(object sender, EventArgs e) {
            UpdateUI();
            ShowReport();
        }
        void ViewModel_PeriodChanged(object sender, EventArgs e) {
            if(ViewModel.MailTemplate.GetValueOrDefault() == SalesReportType.SalesReport)
                ShowReportByMonth(GetSalesReportPeriod());
        }
        DateTime GetSalesReportPeriod() {
            return (ViewModel.Period.GetValueOrDefault() == OrderMailMergePeriod.ThisMonth) ? DateTime.Now : DateTime.Now.AddMonths(-1);
        }
        void LoadTemplate(SnapDocument document, SalesReportType mailTemplate) {
            string template = (mailTemplate.ToFileName() + ".snx");
            using(var stream = MailMergeTemplatesHelper.GetTemplateStream(template))
                document.LoadDocument(stream, DevExpress.Snap.Core.API.SnapDocumentFormat.Snap);
            ribbonControl.ApplicationDocumentCaption = DevExpress.XtraEditors.EnumDisplayTextHelper.GetDisplayText(mailTemplate);
            ViewModel.Modified = snapControl.Modified;
        }
        void UpdateUI() {
            mailMergeRibbonPage1.Visible = !ViewModel.IsMailTemplateSelected;
            rpbReportRange.Visible = ViewModel.IsMailTemplateSelected && ViewModel.MailTemplate.GetValueOrDefault() == SalesReportType.SalesReport;
        }
        public OrderMailMergeViewModel ViewModel {
            get { return GetViewModel<OrderMailMergeViewModel>(); }
        }
        public OrderCollectionViewModel CollectionViewModel {
            get { return GetParentViewModel<OrderCollectionViewModel>(); }
        }
        protected override void OnLoad(EventArgs ea) {
            base.OnLoad(ea);
            bindingSource.DataSource = CollectionViewModel.SelectedEntity;
            if(snapControl.Document.IsEmpty)
                ShowReport();
        }
        void ShowReport() {
            bindingSource.DataSource = CollectionViewModel.SelectedEntity;
            switch(ViewModel.MailTemplate.GetValueOrDefault()) {
                case SalesReportType.SalesReport:
                    snapControl.DataSource = CollectionViewModel.GetOrderItems();
                    ShowReportByMonth(GetSalesReportPeriod());
                    break;
                case SalesReportType.SalesByStore:
                    snapControl.DataSource = CollectionViewModel.GetOrderItems(CollectionViewModel.SelectedEntity.StoreId);
                    GenerateReport(null);
                    break;
                case SalesReportType.Invoice:
                case SalesReportType.OrderFollowUp:
                    LoadTemplate(snapControl.Document, ViewModel.MailTemplate.GetValueOrDefault());
                    snapControl.DataSource = bindingSource;
                    break;
            }
        }
        void ShowReportByMonth(DateTime month) {
            DateTime start = new DateTime(month.Year, month.Month, 1);
            DateTime end = start.AddMonths(1);
            GenerateReport(document =>
            {
                document.Parameters["startDate"].Value = start;
                document.Parameters["endDate"].Value = end;
            });
        }
        void GenerateReport(Action<SnapDocument> initAction) {
            snapControl.BeginUpdate();
            LoadTemplate(snapControl.Document, ViewModel.MailTemplate.GetValueOrDefault());
            if(initAction != null)
                initAction(snapControl.Document);
            snapControl.EndUpdate();
            using(MemoryStream ms = new MemoryStream()) {
                snapControl.Document.ExportDocument(ms, DocumentFormat.OpenXml);
                ms.Position = 0;
                snapControl.Document.LoadDocument(ms, DocumentFormat.OpenXml);
            }
            ViewModel.Modified = snapControl.Modified;
        }
        void BindCommands() {
            biClose.BindCommand(() => ViewModel.Close(), ViewModel);
            bbiThisMonth.BindCommand(() => ViewModel.SetThisMonthPeriod(), ViewModel);
            bbiPrevMonth.BindCommand(() => ViewModel.SetLastMonthPeriod(), ViewModel);
        }
        void snapControl_ModifiedChanged(object sender, EventArgs e) {
            ViewModel.Modified = snapControl.Modified;
        }
        void ViewModel_Save(object sender, EventArgs e) {
            snapControl.SaveDocumentAs();
        }
        #region
        XtraBars.Ribbon.RibbonControl IRibbonModule.Ribbon {
            get { return ribbonControl; }
        }
        #endregion
    }
}