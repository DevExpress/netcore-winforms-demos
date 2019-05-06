namespace DevExpress.DevAV.Modules {
    using System.Windows.Forms;
    using DevExpress.DevAV;
    using DevExpress.DevAV.Presenters;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.Skins;
    using DevExpress.Utils;
    using DevExpress.XtraGrid.Views.Base;
    using DevExpress.XtraLayout.Utils;

    public partial class Customers : BaseModuleControl, IRibbonModule {
        public Customers()
            : base(typeof(CustomerCollectionViewModel)) {
            InitializeComponent();
            GalleryItemAppearances.Apply(galleryQuickReports);
            layoutView.Appearance.FieldCaption.ForeColor = ColorHelper.DisabledTextColor;
            layoutView.Appearance.FieldCaption.Options.UseForeColor = true;
            lvEmployees.Appearance.FieldCaption.ForeColor = ColorHelper.DisabledTextColor;
            lvEmployees.Appearance.FieldCaption.Options.UseForeColor = true;
            //
            CollectionUIViewModel = DevExpress.Mvvm.POCO.ViewModelSource.Create<CollectionUIViewModel>();
            CollectionPresenter = CreateCollectionPresenter();
            CollectionPresenter.ReloadEntities(mvvmContext);
            //
            BindCommands();
            //
            InitViewKind();
            InitViewLayout();
        }
        protected override void OnDisposing() {
            CollectionPresenter.Dispose();
            base.OnDisposing();
        }
        public CustomerCollectionViewModel ViewModel {
            get { return GetViewModel<CustomerCollectionViewModel>(); }
        }
        protected CustomerCollectionPresenter CollectionPresenter {
            get;
            private set;
        }
        protected virtual CustomerCollectionPresenter CreateCollectionPresenter() {
            return new CustomerCollectionPresenter(gridControl, ViewModel, UpdateEntitiesCountRelatedUI);
        }
        protected override void OnInitServices() {
            mvvmContext.RegisterService("View Settings", new ViewSettingsDialogDocumentManagerService(() => CollectionUIViewModel));
            mvvmContext.RegisterService(new NotImplementedDetailFormDocumentManagerService(ModuleType.CustomerEditView));
        }
        void BindCommands() {
            //New
            biNewCustomer.BindCommand(() => ViewModel.New(), ViewModel);
            biNewGroup.BindCommand(() => ViewModel.GroupSelection(), ViewModel);
            bmiNewCustomer.BindCommand(() => ViewModel.New(), ViewModel);
            bmiNewGroup.BindCommand(() => ViewModel.GroupSelection(), ViewModel);
            //Edit & Delete
            biEdit.BindCommand((e) => ViewModel.Edit(e), ViewModel, () => ViewModel.SelectedEntity);
            biDelete.BindCommand((e) => ViewModel.Delete(e), ViewModel, () => ViewModel.SelectedEntity);
            //Map
            biMap.BindCommand(() => ViewModel.ShowMap(), ViewModel);
            //Filter
            biNewCustomFilter.BindCommand(() => ViewModel.NewCustomFilter(), ViewModel);
            //Print
            bmiPrintProfile.BindCommand(() => ViewModel.PrintProfile(), ViewModel);
            bmiPrintContactDirectory.BindCommand(() => ViewModel.PrintContactDirectory(), ViewModel);
            bmiPrintSalesSummary.BindCommand(() => ViewModel.PrintSalesSummary(), ViewModel);
            bmiPrintSalesDetail.BindCommand(() => ViewModel.PrintSalesDetail(), ViewModel);
            //Quick Reports
            BindGalleryQuickReportsItem(0, CustomerReportType.SalesSummary);
            BindGalleryQuickReportsItem(1, CustomerReportType.LocationsDirectory);
            BindGalleryQuickReportsItem(2, CustomerReportType.SelectedContactDirectory);
            //Analysis
            biSalesAnalysis.BindCommand(() => ViewModel.ShowAnalysis(), ViewModel);
            //Settings
            biViewSettings.BindCommand(() => ViewModel.ShowViewSettings(), ViewModel);
        }
        void BindGalleryQuickReportsItem(int index, CustomerReportType parameter) {
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
            CollectionPresenter.ExpandCollapseMasterRows();
        }
        void biAddColumns_ItemCheckedChanged(object sender, XtraBars.ItemClickEventArgs e) {
            CollectionPresenter.AddColumns(biAddColumns);
        }
        void biReverseSort_ItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            CollectionPresenter.ReverseSort(colName, colName1);
        }
        CustomerView customerView;
        protected override void OnLoad(System.EventArgs e) {
            base.OnLoad(e);
            var moduleLocator = GetService<Services.IModuleLocator>();
            customerView = moduleLocator.GetModule(ModuleType.CustomerView) as CustomerView;
            ViewModelHelper.EnsureModuleViewModel(customerView, ViewModel, ViewModel.SelectedEntityKey);
            customerView.Dock = DockStyle.Fill;
            customerView.Parent = pnlView;
            gridView.ExpandMasterRow(0);
        }
        #region ViewKind
        protected CollectionUIViewModel CollectionUIViewModel { get; private set; }
        void InitViewKind() {
            CollectionUIViewModel.ViewKindChanged += ViewModel_ViewKindChanged;
            biShowCard.BindCommand(() => CollectionUIViewModel.ShowCard(), CollectionUIViewModel);
            biShowList.BindCommand(() => CollectionUIViewModel.ShowList(), CollectionUIViewModel);
            bmiShowCard.BindCommand(() => CollectionUIViewModel.ShowCard(), CollectionUIViewModel);
            bmiShowList.BindCommand(() => CollectionUIViewModel.ShowList(), CollectionUIViewModel);
            biResetView.BindCommand(() => CollectionUIViewModel.ResetView(), CollectionUIViewModel);
        }
        void ViewModel_ViewKindChanged(object sender, System.EventArgs e) {
            if(CollectionUIViewModel.ViewKind == CollectionViewKind.CardView)
                gridControl.MainView = layoutView;
            else {
                gridControl.MainView = gridView;
                gridView.ExpandMasterRow(0);
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
                customerView.IsHorizontalLayout = CollectionUIViewModel.IsHorizontalLayout;
            }
        }
        #endregion
        #region
        XtraBars.Ribbon.RibbonControl IRibbonModule.Ribbon { get { return ribbonControl; } }
        #endregion
        void lvEmployees_CustomDrawCardFieldValue(object sender, RowCellCustomDrawEventArgs e) {
            if(e.Column.FieldName != colPhoto.FieldName) return;
            e.DefaultDraw();
            e.Cache.DrawRectangle(e.Cache.GetPen(lvEmployees.Appearance.FieldCaption.ForeColor, ScaleDPI.ScaleHLine(1)), e.Bounds);
            e.Handled = true;
        }
    }
}