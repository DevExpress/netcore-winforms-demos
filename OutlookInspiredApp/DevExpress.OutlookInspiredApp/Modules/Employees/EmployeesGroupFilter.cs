namespace DevExpress.DevAV.Modules {
    using DevExpress.DevAV.Presenters;
    using DevExpress.DevAV.ViewModels;

    public partial class EmployeesGroupFilter : BaseModuleControl {
        EmployeesGroupFilterPresenter presenterCore;
        public EmployeesGroupFilter(GroupFilterViewModel groupFilterViewModel)
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
        public EmployeesGroupFilterPresenter Presenter {
            get { return presenterCore; }
        }
        protected virtual EmployeesGroupFilterPresenter CreatePresenter() {
            return new EmployeesGroupFilterPresenter(winExplorerView, ViewModel);
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