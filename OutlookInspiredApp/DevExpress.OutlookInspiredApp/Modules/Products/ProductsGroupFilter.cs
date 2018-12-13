namespace DevExpress.DevAV.Modules {
    using DevExpress.DevAV.Presenters;
    using DevExpress.DevAV.ViewModels;

    public partial class ProductsGroupFilter : BaseModuleControl {
        ProductsGroupFilterPresenter presenterCore;
        public ProductsGroupFilter(GroupFilterViewModel groupFilterViewModel)
            : base(typeof(GroupFilterViewModel), groupFilterViewModel) {
            InitializeComponent();
            GroupFiltersListViewAppearances.Apply(winExplorerView);
            presenterCore = CreatePresenter();
            //
            BindEditors();
            BindCommands();
        }
        protected override void OnDisposing() {
            Presenter.Dispose();
            base.OnDisposing();
        }
        protected override void OnLoad(System.EventArgs e) {
            base.OnLoad(e);
            Presenter.Load();
        }
        public ProductsGroupFilterPresenter Presenter {
            get { return presenterCore; }
        }
        protected virtual ProductsGroupFilterPresenter CreatePresenter() {
            return new ProductsGroupFilterPresenter(winExplorerView, ViewModel);
        }
        public GroupFilterViewModel ViewModel {
            get { return GetViewModel<GroupFilterViewModel>(); }
        }
        void BindEditors() {
            bindingSource.DataSource = ViewModel;
            //
            var errorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider();
            errorProvider.ContainerControl = this;
            errorProvider.DataSource = bindingSource;
        }
        void BindCommands() {
            this.okBtn.BindCommand(() => ViewModel.OK(), ViewModel);
            this.cancelBtn.BindCommand(() => ViewModel.Cancel(), ViewModel);
        }
    }
}