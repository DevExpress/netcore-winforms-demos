namespace DevExpress.DevAV.Modules {
    using DevExpress.DevAV.Presenters;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.XtraLayout.Utils;

    public partial class QuotesFilterPane : BaseModuleControl, ISupportCompactLayout {
        QuoteFilterTreeListPresenter presenterCore;
        public QuotesFilterPane(QuoteCollectionViewModel collectionViewModel)
            : base(typeof(QuotesFilterTreeViewModel), new object[] { collectionViewModel }) {
            InitializeComponent();
            FiltersTreeListAppearances.Apply(treeList);
            this.presenterCore = CreatePresenter();
            BindCommands();
        }
        protected override void OnDisposing() {
            Presenter.Dispose();
            base.OnDisposing();
        }
        public QuotesFilterTreeViewModel ViewModel {
            get { return GetViewModel<QuotesFilterTreeViewModel>(); }
        }
        public QuoteFilterTreeListPresenter Presenter {
            get { return presenterCore; }
        }
        protected virtual QuoteFilterTreeListPresenter CreatePresenter() {
            return new QuoteFilterTreeListPresenter(treeList, ViewModel);
        }
        protected override void OnInitServices() {
            mvvmContext.RegisterService("Custom Filter", new FilterDialogDocumentManagerService(ModuleType.QuotesCustomFilter));
        }
        protected virtual void BindCommands() {
            btnNewQuote.BindCommand(() => Presenter.CollectionViewModel.New(), Presenter.CollectionViewModel);
        }
        #region ISupportCompactLayout Members
        bool compactLayout = true;
        bool ISupportCompactLayout.Compact {
            get { return compactLayout; }
            set {
                if(compactLayout == value) return;
                compactLayout = value;
                UpdateCompactLayout();
            }
        }
        void UpdateCompactLayout() {
            btnNewQuoteLayoutControlItem.Visibility = compactLayout ? LayoutVisibility.Never : LayoutVisibility.Always;
        }
        #endregion
    }
}