namespace DevExpress.DevAV.Modules {
    using System.Drawing;
    using System.Windows.Forms;
    using DevExpress.DevAV.Presenters;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.XtraEditors.Repository;
    using DevExpress.XtraLayout.Utils;
    using DevExpress.Utils.Svg;

    public partial class Orders : BaseModuleControl, IRibbonModule, ISupportZoom {
        public Orders()
            : base(typeof(OrderCollectionViewModel)) {
            InitializeComponent();
            GalleryItemAppearances.Apply(galleryQuickReports);
            //
            CollectionUIViewModel = DevExpress.Mvvm.POCO.ViewModelSource.Create<CollectionUIViewModel>();
            CollectionPresenter = CreateCollectionPresenter();
            CollectionPresenter.ReloadEntities(mvvmContext);
            //
            BindCommands();
            //
            InitViewKind();
            InitViewLayout();
            InitEditors();
        }
        protected override void OnDisposing() {
            CollectionPresenter.Dispose();
            UnsubscribeOrderViewEvents();
            base.OnDisposing();
        }
        public OrderCollectionViewModel ViewModel {
            get { return GetViewModel<OrderCollectionViewModel>(); }
        }
        protected OrderCollectionPresenter CollectionPresenter {
            get;
            private set;
        }
        protected virtual OrderCollectionPresenter CreateCollectionPresenter() {
            return new OrderCollectionPresenter(gridControl, ViewModel, UpdateEntitiesCountRelatedUI);
        }
        protected override void OnInitServices() {
            mvvmContext.RegisterService("View Settings", new ViewSettingsDialogDocumentManagerService(() => CollectionUIViewModel));
            mvvmContext.RegisterService(new DetailFormDocumentManagerService(ModuleType.OrderEditView));
        }
        void BindCommands() {
            //New
            biNewOrder.BindCommand(() => ViewModel.New(), ViewModel);
            //Map
            biMap.BindCommand(() => ViewModel.ShowMap(), ViewModel);
            //Filter
            biNewCustomFilter.BindCommand(() => ViewModel.NewCustomFilter(), ViewModel);
            //Print
            bmiPrintInvoice.BindCommand(() => ViewModel.PrintInvoice(), ViewModel);
            bmiPrintSalesSummary.BindCommand(() => ViewModel.PrintSalesReport(), ViewModel);
            bmiPrintSalesAnalysis.BindCommand(() => ViewModel.PrintSalesByStore(), ViewModel);
            //Quick Reports
            //BindGalleryQuickReportsItem(0, SalesReportType.SalesReport);
            BindGalleryQuickReportsItem(1, SalesReportType.OrderFollowUp);
            //BindGalleryQuickReportsItem(2, SalesReportType.SalesByStore);
            BindGalleryQuickReportsFormatItem(3, ReportFormat.Doc);
            BindGalleryQuickReportsFormatItem(4, ReportFormat.Xls);
            BindGalleryQuickReportsFormatItem(5, ReportFormat.Pdf);
            galleryQuickReports.Gallery.Groups[0].Items[0].BindCommand(() => ViewModel.ShowRevenueReport(), ViewModel);
            galleryQuickReports.Gallery.Groups[0].Items[2].BindCommand(() => ViewModel.ShowRevenueAnalysisReport(), ViewModel);
            //Settings
            biViewSettings.BindCommand(() => ViewModel.ShowViewSettings(), ViewModel);
        }
        void BindGalleryQuickReportsItem(int index, SalesReportType parameter) {
            galleryQuickReports.Gallery.Groups[0].Items[index].BindCommand(() => ViewModel.QuickReport(parameter), ViewModel, () => parameter);
        }
        void BindGalleryQuickReportsFormatItem(int index, ReportFormat parameter) {
            galleryQuickReports.Gallery.Groups[0].Items[index].BindCommand(() => ViewModel.QuickReportFormat(parameter), ViewModel, () => parameter);
        }
        void UpdateEntitiesCountRelatedUI(int count) {
            hiItemsCount.Caption = string.Format("RECORDS: {0}", count);
            UpdateAdditionalButtons(count > 0);
        }
        void UpdateAdditionalButtons(bool hasRecords) {
            biReverseSort.Enabled = hasRecords;
            biExpandCollapse.Enabled = hasRecords && (CollectionUIViewModel.ViewKind == CollectionViewKind.MasterDetailView);
            biAddColumns.Enabled = hasRecords && (CollectionUIViewModel.ViewKind != CollectionViewKind.CardView);
        }
        void biExpandCollapse_ItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            CollectionPresenter.ExpandCollapseMasterRows();
        }
        void biAddColumns_ItemCheckedChanged(object sender, XtraBars.ItemClickEventArgs e) {
            CollectionPresenter.AddColumns(biAddColumns);
        }
        void biReverseSort_ItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            CollectionPresenter.ReverseSort(gridView, colOrderDate);
        }
        OrderView orderView;
        protected override void OnLoad(System.EventArgs e) {
            base.OnLoad(e);
            UnsubscribeOrderViewEvents();
            var moduleLocator = GetService<Services.IModuleLocator>();
            orderView = moduleLocator.GetModule(ModuleType.OrderView) as OrderView;
            SubscribeOrderViewEvents();
            ViewModelHelper.EnsureModuleViewModel(orderView, ViewModel, ViewModel.SelectedEntityKey);
            orderView.Dock = DockStyle.Fill;
            orderView.Parent = pnlView;
            gridView.ExpandMasterRow(0);
            gridView.ActiveFilterString = "IsOutlookIntervalYesterday([OrderDate]) Or IsOutlookIntervalToday([OrderDate])";
        }
        const string statusResourcePath = "DevExpress.DevAV.Resources.Orders.";
        void InitEditors() {
            colPaymentStatus.ImageOptions.SvgImage = SvgImage.FromResources(statusResourcePath + "Payment.svg", GetType().Assembly);
            colPaymentStatus.ColumnEdit = EditorHelpers.CreatePaymentStatusImageComboBox(LookAndFeel, null, gridControl.RepositoryItems);
            colShipmentStatus.ImageOptions.SvgImage = SvgImage.FromResources(statusResourcePath + "Shipment.svg", GetType().Assembly);
            colShipmentStatus.ColumnEdit = EditorHelpers.CreateShipmentStatusImageComboBox(LookAndFeel, null, gridControl.RepositoryItems);
        }
        void UnsubscribeOrderViewEvents() {
            if(orderView != null) {
                orderView.ZoomLevelChanged -= orderView_ZoomLevelChanged;
                orderView.MoveNextButton.ItemClick -= MoveNextButton_Click;
                orderView.MovePrevButton.ItemClick -= MovePrevButton_Click;
            }
        }
        void SubscribeOrderViewEvents() {
            if(orderView != null) {
                orderView.ZoomLevelChanged += orderView_ZoomLevelChanged;
                orderView.MoveNextButton.ItemClick += MoveNextButton_Click;
                orderView.MovePrevButton.ItemClick += MovePrevButton_Click;
                gridView.FocusedRowChanged += GridView_FocusedRowChanged;
            }
        }

        private void GridView_FocusedRowChanged(object sender, XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
            if(orderView != null) {
                orderView.MoveNextButton.Enabled = !gridView.IsLastRow;
                orderView.MovePrevButton.Enabled = !gridView.IsFirstRow;
            }
        }

        void MovePrevButton_Click(object sender, System.EventArgs e) {
            gridView.FocusedRowHandle--;
        }

        void MoveNextButton_Click(object sender, System.EventArgs e) {
            gridView.FocusedRowHandle++;
        }
        #region ViewKind
        protected CollectionUIViewModel CollectionUIViewModel { get; private set; }
        void InitViewKind() {
            CollectionUIViewModel.DefaultViewKind = CollectionViewKind.MasterDetailView;
            CollectionUIViewModel.ViewKind = CollectionViewKind.MasterDetailView;
            CollectionUIViewModel.ViewKindChanged += ViewModel_ViewKindChanged;
            biShowMasterDetail.BindCommand(() => CollectionUIViewModel.ShowMasterDetail(), CollectionUIViewModel);
            biShowList.BindCommand(() => CollectionUIViewModel.ShowList(), CollectionUIViewModel);
            biShowCard.BindCommand(() => CollectionUIViewModel.ShowCard(), CollectionUIViewModel);
            bmiShowMasterDetail.BindCommand(() => CollectionUIViewModel.ShowMasterDetail(), CollectionUIViewModel);
            bmiShowList.BindCommand(() => CollectionUIViewModel.ShowList(), CollectionUIViewModel);
            bmiShowCard.BindCommand(() => CollectionUIViewModel.ShowCard(), CollectionUIViewModel);
            biResetView.BindCommand(() => CollectionUIViewModel.ResetView(), CollectionUIViewModel);
        }
        void ViewModel_ViewKindChanged(object sender, System.EventArgs e) {
            bool showDetails = CollectionUIViewModel.ViewKind != CollectionViewKind.ListView;
            gridView.OptionsDetail.EnableMasterViewMode = showDetails;
            if(CollectionUIViewModel.ViewKind != CollectionViewKind.CardView) {
                gridView.OptionsDetail.DetailMode = XtraGrid.Views.Grid.DetailMode.Embedded;
                gridControl.LevelTree.Nodes[0].LevelTemplate = gridViewOrderItems;
            }
            else {
                gridView.OptionsDetail.DetailMode = XtraGrid.Views.Grid.DetailMode.Default;
                gridControl.LevelTree.Nodes[0].LevelTemplate = tileViewOrderItems;
            }
            if(showDetails)
                gridView.ExpandMasterRow(0);
            UpdateAdditionalButtons(ViewModel.Entities.Count > 0);
            GridHelper.SetFindControlImages(gridControl);
        }
        #endregion
        #region ViewLayout
        void InitViewLayout() {
            CollectionUIViewModel.ViewLayoutChanged += ViewModel_ViewLayoutChanged;
            bmiHorizontalLayout.BindCommand(() => CollectionUIViewModel.ShowHorizontalLayout(), CollectionUIViewModel);
            bmiVerticalLayout.BindCommand(() => CollectionUIViewModel.ShowVerticalLayout(), CollectionUIViewModel);
            bmiHideDetail.BindCommand(() => CollectionUIViewModel.HideDetail(), CollectionUIViewModel);
        }
        void ViewModel_ViewLayoutChanged(object sender, System.EventArgs e) {
            bool detailHidden = CollectionUIViewModel.IsDetailHidden;
            splitterItem.Visibility = detailHidden ? LayoutVisibility.Never : LayoutVisibility.Always;
            masterItem.Visibility = detailHidden ? LayoutVisibility.Never : LayoutVisibility.Always;
            if(!detailHidden) {
                if(splitterItem.IsVertical != CollectionUIViewModel.IsHorizontalLayout)
                    layoutControlGroup1.RotateLayout();
            }
        }
        #endregion
        #region ISupportZoom Members
        int ISupportZoom.ZoomLevel {
            get { return (orderView != null) ? orderView.ZoomLevel : 100; }
            set {
                if(orderView != null)
                    orderView.ZoomLevel = value;
            }
        }
        static readonly object zoomLevelChanged = new object();
        event System.EventHandler ISupportZoom.ZoomChanged {
            add { Events.AddHandler(zoomLevelChanged, value); }
            remove { Events.RemoveHandler(zoomLevelChanged, value); }
        }
        void orderView_ZoomLevelChanged(object sender, System.EventArgs e) {
            RaiseZoomLevelChanged();
        }
        void RaiseZoomLevelChanged() {
            var handler = Events[zoomLevelChanged] as System.EventHandler;
            if(handler != null) handler(this, System.EventArgs.Empty);
        }
        #endregion
        #region
        XtraBars.Ribbon.RibbonControl IRibbonModule.Ribbon { get { return ribbonControl; } }
        #endregion
    }
}