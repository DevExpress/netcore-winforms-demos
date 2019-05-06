namespace DevExpress.DevAV.Modules {
    using System.Windows.Forms;
    using DevExpress.DevAV;
    using DevExpress.DevAV.Presenters;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.Skins;
    using DevExpress.Utils;
    using DevExpress.XtraGrid.Views.Base;
    using DevExpress.XtraGrid.Views.Layout;
    using DevExpress.XtraLayout.Utils;

    public partial class Products : BaseModuleControl, IRibbonModule, ISupportZoom {
        public Products()
            : base(typeof(ProductCollectionViewModel)) {
            InitializeComponent();
            GalleryItemAppearances.Apply(galleryQuickReports);
            layoutView.Appearance.FieldCaption.ForeColor = ColorHelper.DisabledTextColor;
            layoutView.Appearance.FieldCaption.Options.UseForeColor = true;
            colDescription.AppearanceCell.ForeColor = ColorHelper.DisabledTextColor;
            colDescription.AppearanceCell.Options.UseForeColor = true;
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
            UnsubscribeProductView();
            base.OnDisposing();
        }
        public ProductCollectionViewModel ViewModel {
            get { return GetViewModel<ProductCollectionViewModel>(); }
        }
        protected ProductCollectionPresenter CollectionPresenter {
            get;
            private set;
        }
        protected virtual ProductCollectionPresenter CreateCollectionPresenter() {
            return new ProductCollectionPresenter(gridControl, ViewModel, UpdateEntitiesCountRelatedUI);
        }
        protected override void OnInitServices() {
            mvvmContext.RegisterService("View Settings", new ViewSettingsDialogDocumentManagerService(() => CollectionUIViewModel));
            mvvmContext.RegisterService(new NotImplementedDetailFormDocumentManagerService(ModuleType.ProductEditView));
        }
        void BindCommands() {
            //New
            biNewProduct.BindCommand(() => ViewModel.New(), ViewModel);
            biNewGroup.BindCommand(() => ViewModel.GroupSelection(), ViewModel);
            bmiNewProduct.BindCommand(() => ViewModel.New(), ViewModel);
            bmiNewGroup.BindCommand(() => ViewModel.GroupSelection(), ViewModel);
            //Edit & Delete
            biEdit.BindCommand((e) => ViewModel.Edit(e), ViewModel, () => ViewModel.SelectedEntity);
            biDelete.BindCommand((e) => ViewModel.Delete(e), ViewModel, () => ViewModel.SelectedEntity);
            //Map
            biMap.BindCommand(() => ViewModel.ShowMap(), ViewModel);
            //Filter
            biNewCustomFilter.BindCommand(() => ViewModel.NewCustomFilter(), ViewModel);
            //Print
            bmiPrintOrderDetail.BindCommand(() => ViewModel.PrintOrderDetail(), ViewModel);
            bmiPrintSalesSummary.BindCommand(() => ViewModel.PrintSalesSummary(), ViewModel);
            bmiPrintSpecificationSummary.BindCommand(() => ViewModel.PrintSpecificationSummary(), ViewModel);
            //Quick Reports
            BindGalleryQuickReportsItem(0, ProductReportType.OrderDetail);
            BindGalleryQuickReportsItem(1, ProductReportType.SalesSummary);
            BindGalleryQuickReportsItem(2, ProductReportType.SpecificationSummary);
            BindGalleryQuickReportsItem(3, ProductReportType.TopSalesperson);
            //Analysis
            biSalesAnalysis.BindCommand(() => ViewModel.ShowAnalysis(), ViewModel);
            //Settings
            biViewSettings.BindCommand(() => ViewModel.ShowViewSettings(), ViewModel);
        }
        void BindGalleryQuickReportsItem(int index, ProductReportType parameter) {
            galleryQuickReports.Gallery.Groups[0].Items[index].BindCommand(() => ViewModel.QuickReport(parameter), ViewModel, () => parameter);
        }
        void UpdateEntitiesCountRelatedUI(int count) {
            hiItemsCount.Caption = string.Format("RECORDS: {0}", count);
            UpdateAdditionalButtons(count > 0);
        }
        void UpdateAdditionalButtons(bool hasRecords) {
            biReverseSort.Enabled = hasRecords;
            biAddColumns.Enabled = biExpandCollapse.Enabled = hasRecords && (CollectionUIViewModel.ViewKind == CollectionViewKind.ListView);
        }
        void biExpandCollapse_ItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            CollectionPresenter.ExpandCollapseGroups();
        }
        void biAddColumns_ItemCheckedChanged(object sender, XtraBars.ItemClickEventArgs e) {
            CollectionPresenter.AddColumns(biAddColumns);
        }
        void biReverseSort_ItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            CollectionPresenter.ReverseSort(colCategory, colName1);
        }
        ProductView productView;
        protected override void OnLoad(System.EventArgs e) {
            base.OnLoad(e);
            UnsubscribeProductView();
            var moduleLocator = GetService<Services.IModuleLocator>();
            productView = moduleLocator.GetModule(ModuleType.ProductView) as ProductView;
            SubscribeProductView();
            ViewModelHelper.EnsureModuleViewModel(productView, ViewModel, ViewModel.SelectedEntityKey);
            productView.Dock = DockStyle.Fill;
            productView.Parent = pnlView;
        }
        void SubscribeProductView() {
            if(productView != null)
                productView.ZoomLevelChanged += productView_ZoomLevelChanged;
        }
        void UnsubscribeProductView() {
            if(productView != null)
                productView.ZoomLevelChanged -= productView_ZoomLevelChanged;
        }
        void InitEditors() {
            colCategory.ColumnEdit = EditorHelpers.CreateEnumImageComboBox<ProductCategory>(gridControl);
        }
        #region ViewKind
        protected CollectionUIViewModel CollectionUIViewModel { get; private set; }
        void InitViewKind() {
            CollectionUIViewModel.ViewKindChanged += ViewModel_ViewKindChanged;
            biShowCard.BindCommand(() => CollectionUIViewModel.ShowCard(), CollectionUIViewModel);
            biShowList.BindCommand(() => CollectionUIViewModel.ShowList(), CollectionUIViewModel);
            biShowCarousel.BindCommand(() => CollectionUIViewModel.ShowCarousel(), CollectionUIViewModel);
            bmiShowCard.BindCommand(() => CollectionUIViewModel.ShowCard(), CollectionUIViewModel);
            bmiShowList.BindCommand(() => CollectionUIViewModel.ShowList(), CollectionUIViewModel);
            bmiShowCarousel.BindCommand(() => CollectionUIViewModel.ShowCarousel(), CollectionUIViewModel);
            biResetView.BindCommand(() => CollectionUIViewModel.ResetView(), CollectionUIViewModel);
        }
        void ViewModel_ViewKindChanged(object sender, System.EventArgs e) {
            switch(CollectionUIViewModel.ViewKind) {
                case CollectionViewKind.ListView:
                    gridControl.MainView = gridView;
                    break;
                case CollectionViewKind.CardView:
                    layoutView.OptionsView.ViewMode = LayoutViewMode.MultiRow;
                    gridControl.MainView = layoutView;
                    break;
                case CollectionViewKind.Carousel:
                    layoutView.OptionsView.ViewMode = LayoutViewMode.Carousel;
                    gridControl.MainView = layoutView;
                    break;
            }
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
            detailItem.Visibility = detailHidden ? LayoutVisibility.Never : LayoutVisibility.Always;
            if(!detailHidden) {
                if(splitterItem.IsVertical != CollectionUIViewModel.IsHorizontalLayout)
                    layoutControlGroup1.RotateLayout();
            }
        }
        #endregion
        #region
        XtraBars.Ribbon.RibbonControl IRibbonModule.Ribbon { get { return ribbonControl; } }
        #endregion
        #region ISupportZoom Members
        int ISupportZoom.ZoomLevel {
            get { return (productView != null) ? productView.ZoomLevel : 100; }
            set {
                if(productView != null)
                    productView.ZoomLevel = value;
            }
        }
        static readonly object zoomLevelChanged = new object();
        event System.EventHandler ISupportZoom.ZoomChanged {
            add { Events.AddHandler(zoomLevelChanged, value); }
            remove { Events.RemoveHandler(zoomLevelChanged, value); }
        }
        void productView_ZoomLevelChanged(object sender, System.EventArgs e) {
            RaiseZoomLevelChanged();
        }
        void RaiseZoomLevelChanged() {
            var handler = Events[zoomLevelChanged] as System.EventHandler;
            if(handler != null)
                handler(this, System.EventArgs.Empty);
        }
        #endregion
        void gridView_RowStyle(object sender, XtraGrid.Views.Grid.RowStyleEventArgs e) {
            Product product = gridView.GetRow(e.RowHandle) as Product;
            if(product != null && !product.Available)
                e.Appearance.ForeColor = ColorHelper.DisabledTextColor;
        }
        void layoutView_CustomDrawCardFieldValue(object sender, RowCellCustomDrawEventArgs e) {
            if(e.Column.FieldName != colImage.FieldName) return;
            e.DefaultDraw();
            e.Cache.DrawRectangle(e.Cache.GetPen(layoutView.Appearance.FieldCaption.ForeColor, ScaleDPI.ScaleHLine(1)), e.Bounds);
            e.Handled = true;
        }
    }
}