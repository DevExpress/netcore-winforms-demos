namespace DevExpress.DevAV.Modules {
    using System.Windows.Forms;
    using DevExpress.DevAV;
    using DevExpress.DevAV.Presenters;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.Skins;
    using DevExpress.Utils;
    using DevExpress.XtraLayout.Utils;

    public partial class Employees : BaseModuleControl, IRibbonModule {
        public Employees()
            : base(typeof(EmployeeCollectionViewModel)) {
            InitializeComponent();
            GalleryItemAppearances.Apply(galleryQuickLetters);
            layoutView.Appearance.FieldCaption.ForeColor = ColorHelper.DisabledTextColor;
            layoutView.Appearance.FieldCaption.Options.UseForeColor = true;
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
            base.OnDisposing();
        }
        public EmployeeCollectionViewModel ViewModel {
            get { return GetViewModel<EmployeeCollectionViewModel>(); }
        }
        protected EmployeeCollectionPresenter CollectionPresenter {
            get;
            private set;
        }
        protected virtual EmployeeCollectionPresenter CreateCollectionPresenter() {
            return new EmployeeCollectionPresenter(gridControl, ViewModel, UpdateEntitiesCountRelatedUI);
        }
        protected override void OnInitServices() {
            mvvmContext.RegisterService("View Settings", new ViewSettingsDialogDocumentManagerService(() => CollectionUIViewModel));
            mvvmContext.RegisterService(new DetailFormDocumentManagerService(ModuleType.EmployeeEditView));
        }
        void BindCommands() {
            //New
            biNewEmployee.BindCommand(() => ViewModel.New(), ViewModel);
            biNewGroup.BindCommand(() => ViewModel.GroupSelection(), ViewModel);
            bmiNewEmployee.BindCommand(() => ViewModel.New(), ViewModel);
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
            bmiPrintSummary.BindCommand(() => ViewModel.PrintSummary(), ViewModel);
            bmiPrintDirectory.BindCommand(() => ViewModel.PrintDirectory(), ViewModel);
            bmiPrintTaskList.BindCommand(() => ViewModel.PrintTaskList(), ViewModel);
            //Mail Merge
            biMailMerge.BindCommand(() => ViewModel.MailMerge(), ViewModel);
            //Quick Letters
            BindGalleryQuickLettersItem(0, EmployeeMailTemplate.ThankYouNote);
            BindGalleryQuickLettersItem(1, EmployeeMailTemplate.EmployeeOfTheMonth);
            BindGalleryQuickLettersItem(2, EmployeeMailTemplate.ServiceExcellence);
            BindGalleryQuickLettersItem(3, EmployeeMailTemplate.ProbationNotice);
            BindGalleryQuickLettersItem(4, EmployeeMailTemplate.WelcomeToDevAV);
            //
            biMeeting.BindCommand(() => ViewModel.ShowMeeting(), ViewModel);
            biTask.BindCommand(() => ViewModel.ShowTask(), ViewModel);
            //Settings
            biViewSettings.BindCommand(() => ViewModel.ShowViewSettings(), ViewModel);
        }
        void BindGalleryQuickLettersItem(int index, EmployeeMailTemplate parameter) {
            galleryQuickLetters.Gallery.Groups[0].Items[index].BindCommand(() => ViewModel.QuickLetter(parameter), ViewModel, () => parameter);
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
            CollectionPresenter.ReverseSort(colDepartment, colFullName1);
        }
        EmployeeView employeeView;
        protected override void OnLoad(System.EventArgs e) {
            base.OnLoad(e);
            var moduleLocator = GetService<Services.IModuleLocator>();
            employeeView = moduleLocator.GetModule(ModuleType.EmployeeView) as EmployeeView;
            ViewModelHelper.EnsureModuleViewModel(employeeView, ViewModel, ViewModel.SelectedEntityKey);
            employeeView.Dock = DockStyle.Fill;
            employeeView.Parent = pnlView;
        }
        void InitEditors() {
            colPrefix.ColumnEdit = EditorHelpers.CreatePersonPrefixImageComboBox(null, gridControl.RepositoryItems);
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
            else
                gridControl.MainView = gridView;
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
                employeeView.IsHorizontalLayout = CollectionUIViewModel.IsHorizontalLayout;
            }
        }
        #endregion
        #region
        XtraBars.Ribbon.RibbonControl IRibbonModule.Ribbon { get { return ribbonControl; } }
        #endregion
        void layoutView_CustomDrawCardFieldValue(object sender, XtraGrid.Views.Base.RowCellCustomDrawEventArgs e) {
            if(e.Column != colPhoto) return;
            e.DefaultDraw();
            e.Cache.DrawRectangle(e.Cache.GetPen(layoutView.Appearance.FieldCaption.ForeColor, ScaleDPI.ScaleHLine(1)), e.Bounds);
            e.Handled = true;
        }
    }
}